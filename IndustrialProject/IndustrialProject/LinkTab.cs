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

        int[] errorsArray;

        CalloutAnnotation series0_annotation = new CalloutAnnotation();

        public LinkTab(TabPage tab, string filename)
        {
            InitializeComponent();

            this.tab = tab;

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



            chartDropdown.SelectedIndex = 0;

            var seriesPoints = this.chart1.Series[2];
            seriesPoints.XValueMember = "X";
            seriesPoints.YValueMembers = "Y";



            this.file = FileManager.loadAndParseFile(filename);

            Console.WriteLine("[+] " + this.file.stats.noOfPackets + " [+]");
            //Console.WriteLine("File exists?: " + openFiles.Count);

            var bindingList = new BindingList<Packet>(this.file.packets);

            var source = new BindingSource(bindingList, null);

            //source.DataSource = GetData();
            dataGridView1.DataSource = source;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[2].Value != null)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            this.UpdateUI();
        }

        private void chartDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chartDropdown.SelectedItem.Equals("Bar"))
            {
                chart1.Series[2].Enabled = false;
                chart1.Series[0].ChartType = SeriesChartType.Bar;
                chart1.Series[1].ChartType = SeriesChartType.Bar;
            }
            if (chartDropdown.SelectedItem.Equals("Line"))
            {
                chart1.Series[0].ChartType = SeriesChartType.Spline;
                chart1.Series[1].ChartType = SeriesChartType.Spline;
            }
            if (chartDropdown.SelectedItem.Equals("Area"))
            {
                chart1.Series[0].ChartType = SeriesChartType.SplineArea;
                chart1.Series[1].ChartType = SeriesChartType.SplineArea;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chartDropdown != null)
            {
                if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked && !chartDropdown.SelectedItem.Equals("Bar"))
                {
                    chart1.Series[2].Enabled = true;
                }
                else
                {
                    chart1.Series[2].Enabled = false;
                }
            }
            else
            {
                return;
            }
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

                xAxisPlot[i] = plotPoint;

                //if(blabla)
                //Load data rate line. If blabla load packet rate line

                //yAxisPlot[i] = (openFiles[0].packets[i].data.Length)/timeDifference; //Data rate
                yAxisPlot[i] = 1 / timeDifference; //Packet rate

                // Console.WriteLine("Y is: " + yAxisPlot[i]);
            }

            series.Points.DataBindXY(xAxisPlot, yAxisPlot);
            series.ChartType = SeriesChartType.Line;

            chart1.Series.Add(series);
        }

        public void UpdateUI()
        {
            setVals();
            packetCountA.Text = this.file.stats.noOfPackets.ToString();
            charCountA.Text = this.file.stats.noOfDataChars.ToString();
            dataRate.Text = this.file.stats.avgDataRate.ToString();
            packetRate.Text = this.file.stats.avgPacketRate.ToString();
            errorCountA.Text = this.file.stats.totalNoOfErrors.ToString();
            //errorHighlight(this.file.stats.totalNoOfErrors);
            this.tab.Text = "Link " + this.file.port.ToString();
            this.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void errorHighlight(int errors)
        {
            errorsArray = new int[]
            {
                errors
            };

            chart1.Series[2].Points.DataBindY(errorsArray);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            // Call HitTest
            //HitTestResult result = chart1.HitTest(e.X, e.Y);


            //if (result.ChartElementType == ChartElementType.PlottingArea)
            //{
            var xAxis = chart1.ChartAreas[0].AxisX;
            int xRight = (int)xAxis.ValueToPixelPosition(xAxis.Maximum) - 1;
            int xLeft = (int)xAxis.ValueToPixelPosition(xAxis.Minimum);

            double chartX;

            if (e.X > xRight)
            {
                chartX = xAxis.Maximum;
            }
            else if (e.X < xLeft)
            {
                chartX = xAxis.Minimum;
            }
            else
            {
                chartX = xAxis.PixelPositionToValue(e.X);
            }

            // FIX: won't work if there are no points in chart

            if ((int)chartX == 0)
            {
                // first block
                //series0_annotation.AnchorDataPoint = chart1.Series[0].Points[0];
            }
            else if ((int)chartX >= chart1.Series[0].Points.Count)
            {
                // last block
                // series0_annotation.AnchorDataPoint = chart1.Series[0].Points[chart1.Series[0].Points.Count-1];
            }
            else
            {
                // middle blocks
                double frac = chartX - (int)chartX;
                frac = (frac >= 0.5 ? 1.0 : 0.0);

                int chartIdx = (int)((int)chartX + frac) - 1;
                if (chartIdx >= chart1.Series[0].Points.Count)
                    chartIdx = chart1.Series[0].Points.Count - 1;

                // series0_annotation.AnchorDataPoint = chart1.Series[0].Points[chartIdx];
                //series0_annotation.Text = "[Series 0]:" + chart1.Series[0].Points[chartIdx].YValues[0].ToString();
            }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            this.chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
        }
    }
}
