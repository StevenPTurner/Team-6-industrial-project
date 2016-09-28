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
        bool onlyErrors;

        public List<Dictionary<string, File>> allFiles = new List<Dictionary<string, File>>();

        uint errorsShown = ~(uint)Packet.ErrorType.NO_ERROR;

        int mouseX, mouseY;

        //Perhaps put this in file?
        //List<Tuple<int, Packet.ErrorType>> errorGraphIndexs = new List<Tuple<int, Packet.ErrorType>>();

        string graphType;
        bool[] graphTypes;
        public List<int> graphStartIndexs = new List<int>();
        public List<string> graphNames = new List<string>();
        public List<Color> graphColors = new List<Color>();

        CalloutAnnotation series0_annotation = new CalloutAnnotation();
        CalloutAnnotation series1_annotation = new CalloutAnnotation();

        public LinkTab(TabPage tab, string filename, string tabType)
        {
            InitializeComponent();
            graphTypes = new bool[2];
            graphTypes[0] = true;
            checkedListBox1.SetItemChecked(0, true);
            graphType = "DataRate";
            //onlyErrors = true;
            graphColors.Add(Color.Red);
            Console.WriteLine("Ok... " + graphColors[0]);

            this.tabType = tabType;           

            this.tab = tab;
            //chart1.Series[1].Color = Color.FromArgb(127, 255, 0, 0);
            //chart1.Series[2].Enabled = false;

            series0_annotation.AllowMoving = true;
            series0_annotation.Visible = true;
            series0_annotation.Text = "";
            chart1.Annotations.Add(series0_annotation);

            //var seriesPoints = this.chart1.Series[2];
            //seriesPoints.XValueMember = "X";
            //seriesPoints.YValueMembers = "Y";

            this.file = FileManager.loadAndParseFile(filename);
        }

        private void setTabs()
        {
            if (tabType.Equals("Link"))
            {
                chart1.Series.Clear();
                setVals(true, file, "Link");
                //errCountLabel.Text = " Seq: " + file.outOfSeqErrs + "\n CRC: "; //+ file.crcErrs + "\n Data: " + file.dataErrs + "\n Parity: " + file.parityErrs + "\n EEPs + Timeouts " + file.eepAndTimeoutErrs;
                totalErrorLabel.Text = " ----Link " + file.port.ToString() + "----\n Parity: " + file.parityErrs + "\n Seq: " + file.outOfSeqErrs + "\n Header CRC " + file.headCRCErrs + "\n Body CRC " + file.bodyCRCErrs + "\n Too Many Bytes: " + file.tooManyBytesErrs + "\n Not Enough Bytes: " + file.notEnoughBytesErrs + "\n EEPs and timeout: " + file.eepAndTimeoutErrs;
                errorCountLabel.Text = "";
                //Console.WriteLine("Link...");
            }
            else if (tabType.Equals("Overview"))
            {
                totalErrorLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                //Console.WriteLine("File list size: " + allFiles.Count);
                chart1.Series.Clear();
                errorCountLabel.Text = "\n----Link " + allFiles[0].ElementAt(0).Value.port.ToString() + ", Graph: " + 0.ToString() + "----\n Parity: " + allFiles[0].ElementAt(0).Value.parityErrs + "\n Seq: " + allFiles[0].ElementAt(0).Value.outOfSeqErrs + "\n Header CRC " + allFiles[0].ElementAt(0).Value.headCRCErrs + "\n Body CRC " + allFiles[0].ElementAt(0).Value.bodyCRCErrs + "\n Too Many Bytes: " + allFiles[0].ElementAt(0).Value.tooManyBytesErrs + "\n Not Enough Bytes: " + allFiles[0].ElementAt(0).Value.notEnoughBytesErrs + "\n EEPs and timeout: " + allFiles[0].ElementAt(0).Value.eepAndTimeoutErrs;
                //errorCountLabel.Text = totalErrorLabel.Text;

                int totalParityErrs = allFiles[0].ElementAt(0).Value.parityErrs;
                int totalOutOfSeqErrs = allFiles[0].ElementAt(0).Value.outOfSeqErrs;
                int totalHeadCRCErrs = allFiles[0].ElementAt(0).Value.headCRCErrs;
                int totalBodyCRCErrs = allFiles[0].ElementAt(0).Value.bodyCRCErrs;
                int totalTooManyBytesErrs = allFiles[0].ElementAt(0).Value.tooManyBytesErrs;
                int totalNotEnoughBytesErrs = allFiles[0].ElementAt(0).Value.notEnoughBytesErrs;
                int totalEepAndTimeoutErrs = allFiles[0].ElementAt(0).Value.eepAndTimeoutErrs;

                setVals(true, allFiles[0].ElementAt(0).Value, "Graph: " + 0.ToString());

                //graphStartIndexs.Clear();
                //graphStartIndexs.Add(allFiles[0].ElementAt(0).Value.packets.Count);

                for (int i = 1; i < allFiles.Count; i++)
                {
                    //Console.WriteLine("Next file... " + allFiles[i].ElementAt(0).Value.filename);
                    setVals(false, allFiles[i].ElementAt(0).Value, "Graph " + i.ToString());
                    errorCountLabel.Text = errorCountLabel.Text + "\n----Link " + allFiles[i].ElementAt(0).Value.port.ToString() + ". Graph: " + i.ToString() + "----\n Parity: " + allFiles[i].ElementAt(0).Value.parityErrs + "\n Seq: " + allFiles[i].ElementAt(0).Value.outOfSeqErrs + "\n Header CRC " + allFiles[i].ElementAt(0).Value.headCRCErrs + "\n Body CRC " + allFiles[i].ElementAt(0).Value.bodyCRCErrs + "\n Too Many Bytes: " + allFiles[i].ElementAt(0).Value.tooManyBytesErrs + "\n Not Enough Bytes: " + allFiles[i].ElementAt(0).Value.notEnoughBytesErrs + "\n EEPs and timeout: " + allFiles[i].ElementAt(0).Value.eepAndTimeoutErrs + "\n";
                    totalParityErrs = totalParityErrs + allFiles[i].ElementAt(0).Value.parityErrs;
                    totalOutOfSeqErrs = totalOutOfSeqErrs + allFiles[i].ElementAt(0).Value.outOfSeqErrs;
                    totalHeadCRCErrs = totalHeadCRCErrs + allFiles[i].ElementAt(0).Value.headCRCErrs;
                    totalBodyCRCErrs = totalBodyCRCErrs + allFiles[i].ElementAt(0).Value.bodyCRCErrs;
                    totalTooManyBytesErrs = totalTooManyBytesErrs + allFiles[i].ElementAt(0).Value.tooManyBytesErrs;
                    totalNotEnoughBytesErrs = totalNotEnoughBytesErrs + allFiles[i].ElementAt(0).Value.notEnoughBytesErrs;
                    totalEepAndTimeoutErrs = totalEepAndTimeoutErrs + allFiles[i].ElementAt(0).Value.eepAndTimeoutErrs;

                   // graphStartIndexs.Add(allFiles[i].ElementAt(0).Value.packets.Count);
                }

                Console.WriteLine("Size:... " + graphStartIndexs.Count);

                totalErrorLabel.Text = "----Total----" + "\n Parity: " + totalParityErrs + "\n Seq: " + totalOutOfSeqErrs + "\n Header CRC " + totalHeadCRCErrs + "\n Body CRC " + totalBodyCRCErrs + "\n Too Many Bytes: " + totalTooManyBytesErrs + "\n Not Enough Bytes: " + totalNotEnoughBytesErrs + "\n EEPs and timeout: " + totalEepAndTimeoutErrs;
            }
        }

        private void setVals(bool clearGraph, File filePassed, string seriesNo)
        {         
                Series series;
                series = chart1.Series.Add(seriesNo);

                graphNames.Add(seriesNo);

                double plotPoint = 0;

                if (clearGraph)
                {
                    chart1.Series.Clear();
                    
                }
                else
            { }
            //series = chart1.Series[0];
           

            for (int i = 0; i < filePassed.packets.Count; i++)
                {
                    DataPoint point;
                   // if (clearGraph)
                        point = new DataPoint(series);
                   // else
                     //   point = series.Points[i];

                    DateTime date1 = filePassed.packets[i].timestamp;
                    DateTime date2;

                    //Console.WriteLine("Series colour..." + series.Color);

                if (i >= filePassed.packets.Count - 1)
                    {
                        // XXX: this is inaccurate
                        // FIX: won't work if count is less than 2
                        date1 = filePassed.packets[i - 1].timestamp;
                        date2 = filePassed.packets[i].timestamp;
                    }
                    else
                        date2 = filePassed.packets[i + 1].timestamp;

                    double timeDifference = (date2 - date1).TotalSeconds;
                    plotPoint = plotPoint + timeDifference;

                    //Console.WriteLine("This was... :" + (int)this.file.packets[i].error);
                    //Perhaps refactor into another class (File?)
                    if (((uint)filePassed.packets[i].error & this.errorsShown) != 0)
                    {

                        point.MarkerColor = Color.Red;
                        point.MarkerSize = 10;
                    }
                    else
                    {
                    point.MarkerColor = series.Color;
                    //Console.WriteLine(point.MarkerColor.IsEmpty);
                    //Console.WriteLine("Hmm " + series.Color.ToString());
                    //Console.WriteLine("Series: " + series.Color.ToArgb());
                    //Console.WriteLine("Marker Color..." + point.MarkerColor);
                    // graphColors.Add(series.Color);
                    //Color color = graphColors[0];
                    //Color color1 = series.Color;
                    //Console.WriteLine(color1);
                    //Console.WriteLine("Color: " + color.ToString());
                    point.MarkerSize = 3;
                        point.MarkerStyle = MarkerStyle.Square;
                    }

                    point.XValue = plotPoint;

                    //Load data rate line. If blabla load packet rate line
                    if (graphType.Equals("DataRate"))
                    {
                        if (timeDifference == 0)
                            point.YValues = new double[] { 0 };
                        else
                            point.YValues = new double[] { (filePassed.packets[i].data.Length) / timeDifference }; //Data rate
                    }
                    else if (graphType.Equals("PacketRate"))
                    {
                        if (timeDifference == 0)
                            point.YValues = new double[] { 0 };
                        else
                            point.YValues = new double[] { 1 / timeDifference }; //Packet rate
                    }
                    //More graphs?

                   // if (clearGraph)
                        series.Points.Add(point);
                }

                if (series.Points.Count() > 100)
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 60);
                }

                //graphColors.Add(series.Color);  

                graphSetup();

                series.ChartType = SeriesChartType.Line;
                series.MarkerStyle = MarkerStyle.Cross;
                //series.Color = Color.Red;
                

                if (clearGraph)
                    chart1.Series.Add(series);



        }

        private void graphSetup()
        {

            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;

            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            chart1.ChartAreas[0].AxisY.Title = "Byte";
            chart1.ChartAreas[0].AxisX.Title = "Second";

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{ 00.00}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouseX = e.X;
            this.mouseY = e.Y;

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

            double chartX = 0;
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
            if (file.stats.noOfPackets > 100)
            {
                this.chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(60);
                this.chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
            }
            else
            {
                this.chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
                this.chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
            }
        }

        public void PostAdding()
        {
            var bindingList = new BindingList<Packet>(this.file.packets);
            BindingSource source = null;

            if (tabType.Equals("Link"))
            {
                source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                packetCountA.Text = "Packets: " + this.file.stats.noOfPackets.ToString();
                charCountA.Text = "Chars: " + this.file.stats.noOfDataChars.ToString();
                dataRate.Text = "Data Rate: " + this.file.stats.avgDataRate.ToString() + " B/s";
                packetRate.Text = "Packet Rate: " + this.file.stats.avgPacketRate.ToString() + " packet/s";
                errorCountA.Text = "Error Count: " + this.file.stats.totalNoOfErrors.ToString();
                errorRate.Text = "Error Rate: " + this.file.stats.avgErrorRate.ToString() + " error/s";
            }
            else
            {
                List<Packet> graphTableList = new List<Packet>();
                graphTableList = allFiles[0].ElementAt(0).Value.packets;
                packetCountA.Text = "Packets: " + this.allFiles[0].ElementAt(0).Value.stats.noOfPackets.ToString() + "\n";
                charCountA.Text = "Chars: " + this.allFiles[0].ElementAt(0).Value.stats.noOfDataChars.ToString() + "\n";
                dataRate.Text = "Data Rate : " + this.allFiles[0].ElementAt(0).Value.stats.avgDataRate.ToString() + "\n";
                packetRate.Text = "Packet Rate : " + this.allFiles[0].ElementAt(0).Value.stats.avgPacketRate.ToString() + "\n";
                errorCountA.Text = "Error Count: " + this.allFiles[0].ElementAt(0).Value.stats.totalNoOfErrors.ToString() + "\n";
                errorRate.Text = "Error Rate: " + this.allFiles[0].ElementAt(0).Value.stats.avgErrorRate.ToString() + "\n";

                graphStartIndexs.Clear();
                graphStartIndexs.Add(allFiles[0].ElementAt(0).Value.packets.Count);

                for (int i = 1; i < allFiles.Count; i++)
                {
                    graphTableList = graphTableList.Concat(allFiles[i].ElementAt(0).Value.packets).ToList();
                    //packetCountA.Text = packetCountA.Text + this.allFiles[i].ElementAt(0).Value.stats.noOfPackets.ToString() + "\n";
                    packetCountA.Text = packetCountA.Text + "Packets: " + this.allFiles[i].ElementAt(0).Value.stats.noOfPackets.ToString() + "\n";
                    charCountA.Text = charCountA.Text + "Chars: " + this.allFiles[i].ElementAt(0).Value.stats.noOfDataChars.ToString() + "\n";
                    dataRate.Text = dataRate.Text + "Data Rate : " + this.allFiles[i].ElementAt(0).Value.stats.avgDataRate.ToString() + "\n";
                    packetRate.Text = packetRate.Text + "Packet Rate : " + this.allFiles[i].ElementAt(0).Value.stats.avgPacketRate.ToString() + "\n";
                    errorCountA.Text = errorCountA.Text + "Error Count: " + this.allFiles[i].ElementAt(0).Value.stats.totalNoOfErrors.ToString() + "\n";
                    errorRate.Text = errorRate.Text + "Error Rate: " + this.allFiles[i].ElementAt(0).Value.stats.avgErrorRate.ToString() + "\n";

                    graphStartIndexs.Add(allFiles[i].ElementAt(0).Value.packets.Count);
                }

                var test = new BindingList<Packet>(graphTableList);
                dataGridView1.DataSource = test;


            }

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
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    if (onlyErrors && row.Index != 0)
                    {
                        row.Visible = false;
                    }
                }

                    //reference this properly
                    //4 lines below from: www.stackoverflow.com/questions/18942017/unable-to-set-row-visible-false-of-a-datagridview  Accessed: 19:55 on 27/07/2016.  
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[0].Visible = false;
           
        
            this.setTabs();

            if (tabType.Equals("Overview"))
            {
                this.tab.Text = "Overview";
            }
            else
            {
                this.tab.Text = "Link " + this.file.port.ToString();
            }

            if (graphStartIndexs != null)
            {
                int currIndex = 0;
             
                for (int i = 0; i < graphStartIndexs.Count; i++)
                {
                    for (int y = currIndex; y <= graphStartIndexs[i]; y++)
                    {
                        // dataGridView1.Rows[y].DefaultCellStyle.BackColor = chart1.Series[graphNames[i]].MarkerColor;
                        // dataGridView1.Rows[y]. = "ll";
                        Console.WriteLine("Size... : " + dataGridView1.RowCount);
                        //dataGridView1.Rows[31].DefaultCellStyle.BackColor = Color.Black;
                    }
                    Console.WriteLine("Color was..." + graphColors[0].ToString());
                    Console.WriteLine("Size was... " + graphColors.Count);
                    Console.WriteLine("Graph name: " + chart1.Series[graphNames[i]].Name);
                    currIndex = currIndex + graphStartIndexs[i];
                }
            }

            this.Refresh();
        }

        private void navigateToTableIndex(int index)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            if (dataGridView1.Rows[index].Visible)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LinkTab_Load(object sender, EventArgs e)
        {

        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            int index = FindClosestPointIndex(chart1.Series[0], this.mouseX);
            this.navigateToTableIndex(index);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorsShown = 0;

            object[] checkedItems = new object[checkedListBox1.CheckedItems.Count];
            checkedListBox1.CheckedItems.CopyTo(checkedItems, 0);

            int idx = checkedListBox1.SelectedIndex;
            foreach (object itemChecked in checkedItems)
            {
                string text = itemChecked.ToString();

                if (text == "All")
                {
                    this.errorsShown |= ~(uint)Packet.ErrorType.NO_ERROR;

                    checkedListBox1.SelectedIndexChanged -= checkedListBox1_SelectedIndexChanged;
                    checkedListBox1.ClearSelected();
                    checkedListBox1.SetSelected(checkedListBox1.Items.IndexOf(itemChecked), true);
                    checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
                }
                else if (text == "Parity")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_PARITY);
                else if (text == "EPPs and timeouts")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_TRUNCATED);
                else if (text == "Header CRC")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_HEADER_CRC);
                else if (text == "Body CRC")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_BODY_CRC);
                else if (text == "OutofSeq")
                {
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_OUT_OF_ORDER | Packet.ErrorType.ERROR_DUPLICATE);
                }
                else if (text == "Too Many Bytes")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_TOO_MANY_BYTES);
                else if (text == "Not Enough Bytes")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_NOT_ENOUGH_BYTES);
                else if (text == "Disconnect")
                    this.errorsShown |= (uint)(Packet.ErrorType.ERROR_DISCONNECT);
            }
   
            this.setTabs();
        }

        private void dataRateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(dataRateBtn.Checked)
            {
                graphType = "DataRate";
                this.setTabs();
            }
        }

        private void packetRateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(packetRateBtn.Checked)
            {
                graphType = "PacketRate";
                this.setTabs();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    
        private void errorsOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (errorsOnlyCheckBox.Checked)
            {
                onlyErrors = true;
                PostAdding();
            }
            else
            {
                onlyErrors = false;
                PostAdding();
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

