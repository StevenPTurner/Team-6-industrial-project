﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace IndustrialProject
{
    public partial class MainForm : Form
    {
        bool allFilesLoadWait;
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
            this.overViewTab.PostAdding();
        }

        private void LoadTab(string filename)
        {
            //loadingLabel.Show();


            if (overViewTab == null)
            {
                TabPage page1 = new TabPage("Loading Link...");
                overViewTab = new LinkTab(page1, null, "Overview");
                page1.Controls.Add(overViewTab);
                tabControl1.TabPages.Add(page1);
                this.Invalidate(true);
                overViewTab.Dock = DockStyle.Fill;
                
            }

            // create a tab for it
            TabPage page = new TabPage("Loading Link...");
            LinkTab tab = new LinkTab(page, filename, "Link");
            page.Controls.Add(tab);
            tabControl1.TabPages.Add(page);
            this.Invalidate(true);
            tab.Dock = DockStyle.Fill;

            Dictionary<string, File> file = new Dictionary<string, File>();
            file.Add(filename, tab.file);
            allFiles.Add(file);
            overViewTab.allFiles = this.allFiles;

            tab.PostAdding();


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
            string path = Environment.CurrentDirectory;
            System.Diagnostics.Process.Start("file://" + path + "\\Manual.pdf");
        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() != DialogResult.OK)
                return;

            foreach (string filename in Directory.GetFiles(fbd.SelectedPath))
            {
                this.LoadTab(filename);
            }

            overViewTab.PostAdding();

            loadingLabel.Hide();
        }

        private void startTab_Click(object sender, EventArgs e)
        {

        }

        //Closes all opened tabs
        private void closeAllTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int tabSize = tabControl1.TabPages.Count;

            for(int i = 1; i < tabSize; i++)
             {
                tabControl1.TabPages.RemoveAt(1);
             }

            overViewTab = null;
            allFiles.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void instrLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
