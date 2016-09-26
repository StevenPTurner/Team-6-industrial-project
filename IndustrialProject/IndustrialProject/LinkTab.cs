using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace IndustrialProject
{
    public partial class LinkTab : UserControl
    {
        public File file;
        TabPage tab;
        string tabType;

        uint errorsShown = ~(uint)Packet.ErrorType.NO_ERROR;

        //Perhaps put this in file?
        List<Tuple<int, Packet.ErrorType>> errorGraphIndexs = new List<Tuple<int, Packet.ErrorType>>();

        string graphType;
        bool[] graphTypes;

        CalloutAnnotation series0_annotation = new CalloutAnnotation();

        public LinkTab(TabPage tab, string filename, string tabType)
        {
            InitializeComponent();
            graphTypes = new bool[2];
            graphTypes[0] = true;
            checkedListBox1.SetItemChecked(0, true);
            graphType = "DataRate";

            this.tabType = tabType;

            this.tab = tab;
            chart1.Series[1].Color = Color.FromArgb(127, 255, 0, 0);
            chart1.Series[2].Enabled = false;

            series0_annotation.AllowMoving = true;
            series0_annotation.Visible = true;
            series0_annotation.Text = "";
            chart1.Annotations.Add(series0_annotation);

            var seriesPoints = this.chart1.Series[2];
            seriesPoints.XValueMember = "X";
            seriesPoints.YValueMembers = "Y";

            this.file = FileManager.loadAndParseFile(filename);
        }

        private void setVals(bool clearGraph)
        {
            double plotPoint = 0;

            Series series;
            if (clearGraph)
            {
                chart1.Series.Clear();
                series = new Series();
            } else
                series = chart1.Series[0];

            for (int i = 0; i < this.file.packets.Count; i++)
            {
                DataPoint point;
                if (clearGraph)
                    point = new DataPoint(series);
                else
                    point = series.Points[i];

                DateTime date1 = this.file.packets[i].timestamp;
                DateTime date2;
                if (i >= this.file.packets.Count - 1) {
                    // XXX: this is inaccurate
                    // FIX: won't work if count is less than 2
                    date1 = this.file.packets[i - 1].timestamp;
                    date2 = this.file.packets[i].timestamp;
                } else
                    date2 = this.file.packets[i + 1].timestamp;

                double timeDifference = (date2 - date1).TotalSeconds;
                plotPoint = plotPoint + timeDifference;

                //Console.WriteLine("This was... :" + (int)this.file.packets[i].error);
                //Perhaps refactor into another class (File?)
                if (((uint)this.file.packets[i].error & this.errorsShown) != 0)
                {
                    
                    point.MarkerColor = Color.Red;
                    point.MarkerSize = 25;
                } else
                {
                    point.MarkerColor = Color.Green;
                    point.MarkerSize = 15;
                }

                point.XValue = plotPoint;

                //Load data rate line. If blabla load packet rate line
                if (graphType.Equals("DataRate"))
                {
                    if (timeDifference == 0)
                        point.YValues = new double[] { 0 };
                    else
                        point.YValues = new double[] { (this.file.packets[i].data.Length) / timeDifference }; //Data rate
                }
                else if (graphType.Equals("PacketRate"))
                {
                    if (timeDifference == 0)
                        point.YValues = new double[] { 0 };
                    else
                        point.YValues = new double[] { 1 / timeDifference }; //Packet rate
                }
                //More graphs?

                if(clearGraph)
                    series.Points.Add(point);
            }

            chart1.ChartAreas[0].AxisY.Title = "Byte";
            chart1.ChartAreas[0].AxisX.Title = "millisec";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{ 00.00}";

            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Cross;

            if(clearGraph)
                chart1.Series.Add(series);

            errCountLabel.Text = " Seq: " + file.outOfSeqErrs + "\n CRC: " + file.crcErrs + "\n Data: " + file.dataErrs + "\n Parity: " + file.parityErrs + "\n EEPs + Timeouts " + file.eepAndTimeoutErrs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            DataPoint point = FindClosestPoint(chart1.Series[0], e.X);

            series0_annotation.AnchorDataPoint = point;
            series0_annotation.Text = "[Series 0]: " + point.YValues[0].ToString();
        }

        private DataPoint FindClosestPoint(Series series, int pixelX)
        {
            return series.Points[FindClosestPointIndex(series, pixelX)];
        }

        private int FindClosestPointIndex(Series series, int pixelX)
        {
            var xAxis = chart1.ChartAreas[0].AxisX;
            int xRight = (int)xAxis.ValueToPixelPosition(xAxis.Maximum);
            int xLeft = (int)xAxis.ValueToPixelPosition(xAxis.Minimum);

            double chartX;
            if (pixelX > xRight)
                chartX = xAxis.Maximum;
            else if (pixelX < xLeft)
                chartX = xAxis.Minimum;
            else
                chartX = xAxis.PixelPositionToValue(pixelX);

            // closest with binary search

            DataPointCollection points = series.Points;

            if (points.Count() <= 0)
                throw new Exception("FindClosestPoint needs at least one point.");

            /*int left = 0;
            int right = points.Count() - 1;
            int middle = 0;
            int lastMiddle = -1;
            while (middle != lastMiddle)
            {
                double leftX = points[left].XValue;
                double rightX = points[right].XValue;
                double middleX = (leftX + rightX) / 2.0;

                lastMiddle = middle;
                middle = (left + right) / 2;
                if (chartX > middleX)
                    left = middle;
                else if (chartX < middleX)
                    right = middle;
            }

            if (chartX - points[left].XValue < points[right].XValue - chartX)
                middle = left;
            else
                middle = right;

            Console.WriteLine(String.Format("{0} {1} {2}", left, middle, right));

            return middle;*/

            // XXX: temporary work-around

            int minIdx = -1;
            double minDist = 99999999999.0;

            for(int i=0;i<points.Count();i++)
            {
                double distX = Math.Abs(points[i].XValue - chartX);
                if(distX < minDist)
                {
                    minDist = distX;
                    minIdx = i;
                }
            }

            return minIdx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            this.chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
        }

        public void PostAdding()
        {
            var bindingList = new BindingList<Packet>(this.file.packets);
            var source = new BindingSource(bindingList, null);

            dataGridView1.DataSource = source;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 150;

            dataGridView1.Columns[0].HeaderText = "Date";
            dataGridView1.Columns[1].HeaderText = "Time";
            dataGridView1.Columns[2].HeaderText = "Data";
            dataGridView1.Columns[3].HeaderText = "Error";

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.DataBoundItem != null && ((Packet)row.DataBoundItem).error != Packet.ErrorType.NO_ERROR)
                    row.DefaultCellStyle.BackColor = Color.Red;

            this.setVals(true);
            packetCountA.Text = this.file.stats.noOfPackets.ToString();
            charCountA.Text = this.file.stats.noOfDataChars.ToString();
            dataRate.Text = this.file.stats.avgDataRate.ToString() + " B/s";
            packetRate.Text = this.file.stats.avgPacketRate.ToString() + " packet/s";
            errorCountA.Text = this.file.stats.totalNoOfErrors.ToString();
            errorRate.Text = this.file.stats.avgErrorRate.ToString() + " error/s";

            if (tabType.Equals("Overview"))
            {
                this.tab.Text = "Overview";
            }
            else
            {
                this.tab.Text = "Link " + this.file.port.ToString();
            }

            this.Refresh();
        }

        private void navigateToTableIndex(int index)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LinkTab_Load(object sender, EventArgs e)
        {

        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            int index = FindClosestPointIndex(chart1.Series[0], MousePosition.X - (int)chart1.ChartAreas[0].AxisX.ValueToPixelPosition(chart1.ChartAreas[0].AxisX.Minimum));
            this.navigateToTableIndex(index);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorsShown = 0;

           // Console.WriteLine("hELLO STEVEN");

            int idx = checkedListBox1.SelectedIndex;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string text = itemChecked.ToString();

                if (text == "All")
                {
                    this.errorsShown |= ~(uint)Packet.ErrorType.NO_ERROR;

                    checkedListBox1.ClearSelected();
                    checkedListBox1.SetSelected(checkedListBox1.Items.IndexOf(itemChecked), true);
                }
                else if (text == "EPPs and timeouts")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_TRUNCATED | Packet.ErrorType.ERROR_PARITY);
                else if (text == "CRCs")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_HEADER_CRC | Packet.ErrorType.ERROR_BODY_CRC);
                else if (text == "OutofSeq")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_OUT_OF_ORDER | Packet.ErrorType.ERROR_DUPLICATE);
                else if (text == "DataErrors")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_NOT_ENOUGH_BYTES | Packet.ErrorType.ERROR_TOO_MANY_BYTES);
                else if (text == "Disconnect")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_DISCONNECT);
            }

            this.setVals(false);
        }

        private void dataRateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(dataRateBtn.Checked)
            {
                graphType = "DataRate";
                this.setVals(false);
            }
        }

        private void packetRateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(packetRateBtn.Checked)
            {
                graphType = "PacketRate";
                this.setVals(false);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

        //Do not delete this code, may be useful later on.
        /**
            if (!graphTypes[0])
            {
                
                if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
                {
                    if (graphTypes[1])
                    {
                        checkedListBox2.SetItemChecked(1, false);
                    }
                    graphTypes[0] = true;
                }
            }

            if (graphTypes[0])
            {
               
                if (checkedListBox2.GetItemCheckState(0) == CheckState.Unchecked)
                {
                    checkedListBox2.SetItemChecked(0, true);
                }

                if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
                {
                    graphTypes[1] = true;
                    graphTypes[0] = false;
                    checkedListBox2.SetItemChecked(0, false);
                    Console.WriteLine("Hallo");
                }
            }
        
           /**
            if (!graphTypes[1])
            {
                if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
                {
                    Console.WriteLine("Why??????????????????????????????????????????????????????????????");

                    if (graphTypes[0])
                    {
                        Console.WriteLine("Whyz");
                        checkedListBox2.SetItemChecked(0, false);
                    }
                    graphTypes[1] = true;
                }
            }

            if(graphTypes[1])
            {
                if(checkedListBox2.GetItemCheckState(1) == CheckState.Unchecked)
                {
                    graphTypes[1] = false;
                }

            }

    PostAdding();
    */

