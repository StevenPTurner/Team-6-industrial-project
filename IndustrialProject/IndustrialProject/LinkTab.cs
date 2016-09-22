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
        File file;
        TabPage tab;

        double[] xAxisPlot;
        double[] yAxisPlot;
        List<string> errorsSelected = new List<string>();
        
        //Perhaps put this in file?
        List<Tuple<int, Packet.ErrorType>> errorGraphIndexs = new List<Tuple<int, Packet.ErrorType>>();

        string graphType;

        CalloutAnnotation series0_annotation = new CalloutAnnotation();

        public LinkTab(TabPage tab, string filename)
        {
            InitializeComponent();
            graphType = "DataRate";
            this.tab = tab;
            errorsSelected.Add("All");
            chart1.Series[1].Color = Color.FromArgb(127, 255, 0, 0);
            //chart1.Series[0].Points.DataBindY(yAxisPlot);
            //chart1.Series[1].Points.DataBindY();
            // errorHighlight();
            chart1.Series[2].Enabled = false;

            series0_annotation.AllowMoving = true;
            series0_annotation.Visible = true;
            series0_annotation.Text = "helloworld";
            //series0_annotation.AnchorDataPoint = chart1.Series[0].Points[0];
            chart1.Annotations.Add(series0_annotation);

            var seriesPoints = this.chart1.Series[2];
            seriesPoints.XValueMember = "X";
            seriesPoints.YValueMembers = "Y";

            this.file = FileManager.loadAndParseFile(filename);
        }

        private void setVals()
        {
            GraphCalculations gc = new GraphCalculations();
            DateTime date1;
            DateTime date2;
            double timeDifference;
            double plotPoint = 0;

            xAxisPlot = new double[this.file.packets.Count - 1];
            yAxisPlot = new double[this.file.packets.Count - 1];

            chart1.Series.Clear();
            Series series = new Series();

            for (int i = 0; i < this.file.packets.Count - 1; i++)
            {
                date1 = this.file.packets[i].timestamp;
                date2 = this.file.packets[i + 1].timestamp;

                timeDifference = gc.calcPacketTimeDif(date1, date2);
                if (timeDifference == 0)
                    continue;
                plotPoint = plotPoint + timeDifference;

                //dates[i] = date1; //This may change
                //Console.WriteLine("Error here is: " + this.file.packets[i].error);

                //Perhaps refactor into another class (File?)
                if(!this.file.packets[i + 1].error.Equals(Packet.ErrorType.NO_ERROR))
                {
                    //Tuple<int, Packet.ErrorType> errorTuple = new Tuple<int, Packet.ErrorType>(i, this.file.packets[i].error);

                    Tuple<int, Packet.ErrorType> errorTuple = null;
                    
                    // What it may look like...
                    if(errorsSelected.Contains("All"))
                    {
                        errorTuple = new Tuple<int, Packet.ErrorType>(i, this.file.packets[i + 1].error);
                    }
                    else
                    {
                        if(errorsSelected.Contains("Parity"))
                        {
                            ////
                            if(this.file.packets[i + 1].error.Equals(Packet.ErrorType.ERROR_PARITY))
                            {
                                errorTuple = new Tuple<int, Packet.ErrorType>(i, this.file.packets[i + 1].error);
                            }
                        }

                     
                        //if.... for rest of error types
                        ///////////////////////////
                    }
                    
                    errorGraphIndexs.Add(errorTuple);
                }

                xAxisPlot[i] = plotPoint;

                //if(blabla)
                //Load data rate line. If blabla load packet rate line
                if(graphType.Equals("DataRate"))
                {
                    yAxisPlot[i] = (this.file.packets[i].data.Length) / timeDifference; //Data rate
                }
                else
                {
                    yAxisPlot[i] = 1 / timeDifference; //Packet rate
                }

            }

            series.Points.DataBindXY(xAxisPlot, yAxisPlot);
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Cross;

            /*for(int i = 0; i < errorGraphIndexs.Count; i++)
            {
                series.Points[errorGraphIndexs[i].Item1].MarkerColor = Color.Red;
            }*/
     
            chart1.Series.Add(series);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void errorHighlight(int errors)
        {

            //errorsArray = new int[]
            //{
            //    errors
           // };

           // chart1.Series[2].Points.DataBindY(errorsArray);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            DataPoint point = FindClosestPoint(chart1.Series[0], e.X);

            series0_annotation.AnchorDataPoint = point;
            series0_annotation.Text = "[Series 0]: " + point.YValues[0].ToString();
        }

        private DataPoint FindClosestPoint(Series series, int pixelX)
        {
            var xAxis = chart1.ChartAreas[0].AxisX;
            int xRight = (int)xAxis.ValueToPixelPosition(xAxis.Maximum) - 1;
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

            int left = 0;
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

            return points[middle];
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


            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.DataBoundItem != null && ((Packet)row.DataBoundItem).error != Packet.ErrorType.NO_ERROR)
                    row.DefaultCellStyle.BackColor = Color.Red;

            this.setVals();
            packetCountA.Text = this.file.stats.noOfPackets.ToString();
            charCountA.Text = this.file.stats.noOfDataChars.ToString();
            dataRate.Text = this.file.stats.avgDataRate.ToString();
            packetRate.Text = this.file.stats.avgPacketRate.ToString();
            errorCountA.Text = this.file.stats.totalNoOfErrors.ToString();
            errorRate.Text = this.file.stats.avgErrorRate.ToString();
            //errorHighlight(this.file.stats.totalNoOfErrors);
            this.tab.Text = "Link " + this.file.port.ToString();
            this.Refresh();
        }

        private void navigateToTableIndex(int index)
        {
             dataGridView1.ClearSelection();
             dataGridView1.Rows[index].Selected = true;
             dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }
}
}
