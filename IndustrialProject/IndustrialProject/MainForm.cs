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

        public MainForm()
        {
            InitializeComponent();
            chart1.Series[1].Color = Color.FromArgb(127, 255, 0, 0);
            chart1.Series[0].Points.DataBindY(test);
            chart1.Series[1].Points.DataBindY(test1);
            errorHighlight();
            chart1.Series[2].Enabled = false;

            FileManager fm = new FileManager();
            fm.loadFile();

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
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked && !chartDropdown.SelectedItem.Equals("Bar"))
            {
                chart1.Series[2].Enabled = true;
            }
            else
            {
                chart1.Series[2].Enabled = false;
            }
        }
 
    }
}
