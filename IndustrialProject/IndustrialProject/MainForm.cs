using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IndustrialProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                // feed into data table presumably 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
