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
       
        LinkTab overViewTab;
        List<Dictionary<string, File>> allFiles = new List<Dictionary<string, File>>();

        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
            {
                //UpdateUI(1);
            }

            if (e.KeyCode == Keys.D2 && e.Modifiers == Keys.Control)
            {
                //UpdateUI(2);
            }

            if (e.KeyCode == Keys.D3 && e.Modifiers == Keys.Control)
            {
                //UpdateUI(3);
            }

            if (e.KeyCode == Keys.D4 && e.Modifiers == Keys.Control)
            {
                //UpdateUI(4);
            }

            /*if (e.KeyCode == Keys.H && e.Modifiers == Keys.Control)
            {
                MessageBox.Show("User manual opened");
            }*/
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the filename
            OpenFileDialog ofd = new OpenFileDialog();

            //ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|rec files (*.rec)|*.rec|all files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            this.LoadTab(ofd.FileName);
        }

        private void LoadTab(string filename)
        {


            if (overViewTab == null)
            {
                TabPage page1 = new TabPage("Loading Link...");
                overViewTab = new LinkTab(page1, filename, "Overview");
                page1.Controls.Add(overViewTab);
                tabControl1.TabPages.Add(page1);
                this.Invalidate(true);
                
            }

            // create a tab for it
            TabPage page = new TabPage("Loading Link...");
            LinkTab tab = new LinkTab(page, filename, "Link");
            page.Controls.Add(tab);
            tabControl1.TabPages.Add(page);
            this.Invalidate(true);
            tab.Dock = DockStyle.Fill;

            tab.PostAdding();
            

            Dictionary<string, File> file = new Dictionary<string, File>();
            file.Add(filename, tab.file);
            allFiles.Add(file);
            overViewTab.allFiles = this.allFiles;
            overViewTab.PostAdding();
            overViewTab.allFiles =  allFiles;

            //Console.WriteLine("File: " + file.ElementAt(0).Key + "fadsf " + file.ElementAt(0).Value.packets[0].timestamp);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keyBoardShortcutsMenuItem_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("The following shortcuts can be used. \n"
                            + "CTRL & 1 to Load Device 1.\n"
                            + "CTRL & 2 to Load Device 2.\n"
                            + "CTRL & 3 to Load Device 3.\n"
                            + "CTRL & 4 to Load Device 4.\n");*/
        }

        private void loadHelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("blahblahblah");
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() != DialogResult.OK)
                return;

            foreach(string filename in Directory.GetFiles(fbd.SelectedPath))
            {
                this.LoadTab(filename);
            }
        }

        private void startTab_Click(object sender, EventArgs e)
        {

        }
    }
}
