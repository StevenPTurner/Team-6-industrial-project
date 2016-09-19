using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace IndustrialProject
{
    public partial class MainForm : Form
    {

        int[] test = new int[6] { 1, 3, 5, 2, 7, 9 };
        int[] test1 = new int[6] { 5, 3, 7, 8, 2, 0 };
        int[] errorTest = new int[2] { 1, 3 };

        List<IndustrialProject.File> openFiles = new List<IndustrialProject.File>();

        CalloutAnnotation series0_annotation = new CalloutAnnotation();

        public MainForm()
        {
            InitializeComponent();
            chart1.Series[1].Color = Color.FromArgb(127, 255, 0, 0);
            chart1.Series[0].Points.DataBindY(test);
            chart1.Series[1].Points.DataBindY(test1);
            errorHighlight();
            chart1.Series[2].Enabled = false;

            series0_annotation.AllowMoving = true;
            series0_annotation.Visible = true;
            series0_annotation.Text = "helloworld";
            series0_annotation.AnchorDataPoint = chart1.Series[0].Points[0];
            chart1.Annotations.Add(series0_annotation);

            this.dataGridView1.Rows.Add(DateTime.Now, "f0bff0a0fb0");
            this.dataGridView1.Rows.Add(DateTime.Now, "f1bbfif0fd0");
            this.dataGridView1.Rows.Add(DateTime.Now, "f0hb0x0x0x0");
            this.dataGridView1.Rows.Add(DateTime.Now, "0xfb0xbfb00");
            this.dataGridView2.Rows.Add(DateTime.Now, "asjhfgasfad");
            this.dataGridView2.Rows.Add(DateTime.Now, "asffasfasda");
            this.dataGridView2.Rows.Add(DateTime.Now, "f0bff0a0fb0");
            this.dataGridView2.Rows.Add(DateTime.Now, "f0bff0a0fb0");

            chartDropdown.SelectedIndex = 0;

            var seriesPoints = this.chart1.Series[2];
            seriesPoints.XValueMember = "X";
            seriesPoints.YValueMembers = "Y";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|rec files (*.rec)|*.rec|all files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                // parse, feed into datagrid n that
                FileManager fm = new FileManager();
                openFiles.Add(fm.loadAndParseFile(ofd.FileName));
                Console.WriteLine("[+] " + openFiles[0].stats.noOfPackets + " [+]");
                //Console.WriteLine("File exists?: " + openFiles.Count);

              //  for(int i = 0; i < openFiles.Count; i++)
              //  {
              //      for(int y = 0; y < openFiles[i].packets.Count; y++)
              //      {
                       // Console.WriteLine(openFiles[i].packets[y].data)
              //          for(int z = 0; z < openFiles[i].packets[y].data.Length; z++)
               //         {
               //             Console.Write(openFiles[i].packets[y].data[z]);
                //        }
                 //       Console.WriteLine(" ");
                //    }
               // }
                //Console.WriteLine(openFiles[0].filename);
            }

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chartDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (chartDropdown.SelectedItem.Equals("Bar"))
            {
                chart1.Series[2].Enabled = false;
                chart1.Series[0].ChartType = SeriesChartType.Bar;
                chart1.Series[1].ChartType = SeriesChartType.Bar;
            }
            if(chartDropdown.SelectedItem.Equals("Line"))
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

        public void errorHighlight()
        {
            chart1.Series[2].Points.DataBindY(errorTest);
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
                    series0_annotation.AnchorDataPoint = chart1.Series[0].Points[0];
                } else if((int)chartX >= chart1.Series[0].Points.Count)
                {
                    // last block
                    series0_annotation.AnchorDataPoint = chart1.Series[0].Points[chart1.Series[0].Points.Count-1];
                } else
                {
                    // middle blocks
                    double frac = chartX - (int)chartX;
                    frac = (frac >= 0.5 ? 1.0 : 0.0);

                    int chartIdx = (int)((int)chartX + frac) - 1;
                    if (chartIdx >= chart1.Series[0].Points.Count)
                        chartIdx = chart1.Series[0].Points.Count - 1;

                    series0_annotation.AnchorDataPoint = chart1.Series[0].Points[chartIdx];
                    series0_annotation.Text = "[Series 0]:" + chart1.Series[0].Points[chartIdx].YValues[0].ToString();
                } 
            //}
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
