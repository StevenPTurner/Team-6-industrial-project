namespace IndustrialProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorRate = new System.Windows.Forms.Label();
            this.ErrorRatelbl = new System.Windows.Forms.Label();
            this.packetRate = new System.Windows.Forms.Label();
            this.PacketRatelbl = new System.Windows.Forms.Label();
            this.dataRate = new System.Windows.Forms.Label();
            this.DataRatelbl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(83, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorRate);
            this.tabPage1.Controls.Add(this.ErrorRatelbl);
            this.tabPage1.Controls.Add(this.packetRate);
            this.tabPage1.Controls.Add(this.PacketRatelbl);
            this.tabPage1.Controls.Add(this.dataRate);
            this.tabPage1.Controls.Add(this.DataRatelbl);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Device 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorRate
            // 
            this.errorRate.AutoSize = true;
            this.errorRate.Location = new System.Drawing.Point(690, 392);
            this.errorRate.Name = "errorRate";
            this.errorRate.Size = new System.Drawing.Size(29, 13);
            this.errorRate.TabIndex = 8;
            this.errorRate.Text = "err/s";
            // 
            // ErrorRatelbl
            // 
            this.ErrorRatelbl.AutoSize = true;
            this.ErrorRatelbl.Location = new System.Drawing.Point(631, 392);
            this.ErrorRatelbl.Name = "ErrorRatelbl";
            this.ErrorRatelbl.Size = new System.Drawing.Size(53, 13);
            this.ErrorRatelbl.TabIndex = 7;
            this.ErrorRatelbl.Text = "Error rate:";
            // 
            // packetRate
            // 
            this.packetRate.AutoSize = true;
            this.packetRate.Location = new System.Drawing.Point(491, 392);
            this.packetRate.Name = "packetRate";
            this.packetRate.Size = new System.Drawing.Size(50, 13);
            this.packetRate.TabIndex = 6;
            this.packetRate.Text = "packet/s";
            // 
            // PacketRatelbl
            // 
            this.PacketRatelbl.AutoSize = true;
            this.PacketRatelbl.Location = new System.Drawing.Point(420, 392);
            this.PacketRatelbl.Name = "PacketRatelbl";
            this.PacketRatelbl.Size = new System.Drawing.Size(65, 13);
            this.PacketRatelbl.TabIndex = 5;
            this.PacketRatelbl.Text = "Packet rate:";
            // 
            // dataRate
            // 
            this.dataRate.AutoSize = true;
            this.dataRate.Location = new System.Drawing.Point(311, 392);
            this.dataRate.Name = "dataRate";
            this.dataRate.Size = new System.Drawing.Size(31, 13);
            this.dataRate.TabIndex = 4;
            this.dataRate.Text = "mb/s";
            // 
            // DataRatelbl
            // 
            this.DataRatelbl.AutoSize = true;
            this.DataRatelbl.Location = new System.Drawing.Point(251, 392);
            this.DataRatelbl.Name = "DataRatelbl";
            this.DataRatelbl.Size = new System.Drawing.Size(54, 13);
            this.DataRatelbl.TabIndex = 3;
            this.DataRatelbl.Text = "Data rate:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "CRCs",
            "Out of seq",
            "Data errors",
            "Disconnect",
            "EPPs and timeout"});
            this.checkedListBox1.Location = new System.Drawing.Point(757, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 79);
            this.checkedListBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeCol,
            this.dataCol,
            this.errorsCol,
            this.charCol,
            this.packetCol});
            this.dataGridView1.Location = new System.Drawing.Point(49, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time";
            this.timeCol.Name = "timeCol";
            // 
            // dataCol
            // 
            this.dataCol.HeaderText = "Data";
            this.dataCol.Name = "dataCol";
            // 
            // errorsCol
            // 
            this.errorsCol.HeaderText = "No. errors";
            this.errorsCol.Name = "errorsCol";
            // 
            // charCol
            // 
            this.charCol.HeaderText = "No. chars";
            this.charCol.Name = "charCol";
            // 
            // packetCol
            // 
            this.packetCol.HeaderText = "No. packets";
            this.packetCol.Name = "packetCol";
            // 
            // chart1
            // 
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(49, 20);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "Data";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(705, 130);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1026, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn charCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn packetCol;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label ErrorRatelbl;
        private System.Windows.Forms.Label PacketRatelbl;
        private System.Windows.Forms.Label DataRatelbl;
        private System.Windows.Forms.Label dataRate;
        private System.Windows.Forms.Label packetRate;
        private System.Windows.Forms.Label errorRate;
    }
}

