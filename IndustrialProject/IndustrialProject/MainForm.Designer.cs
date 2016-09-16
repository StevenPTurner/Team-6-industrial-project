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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDevice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDevice3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDevice4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartDropdown = new System.Windows.Forms.ComboBox();
            this.linkblbl = new System.Windows.Forms.Label();
            this.linkalbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.packetCountA = new System.Windows.Forms.Label();
            this.charCountA = new System.Windows.Forms.Label();
            this.errorCountA = new System.Windows.Forms.Label();
            this.packetCountB = new System.Windows.Forms.Label();
            this.charCountB = new System.Windows.Forms.Label();
            this.errorCountB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.loadDevice2ToolStripMenuItem,
            this.loadDevice3ToolStripMenuItem,
            this.loadDevice4ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadToolStripMenuItem.Text = "Load Device 1";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadDevice2ToolStripMenuItem
            // 
            this.loadDevice2ToolStripMenuItem.Name = "loadDevice2ToolStripMenuItem";
            this.loadDevice2ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadDevice2ToolStripMenuItem.Text = "Load Device 2";
            // 
            // loadDevice3ToolStripMenuItem
            // 
            this.loadDevice3ToolStripMenuItem.Name = "loadDevice3ToolStripMenuItem";
            this.loadDevice3ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadDevice3ToolStripMenuItem.Text = "Load Device 3";
            // 
            // loadDevice4ToolStripMenuItem
            // 
            this.loadDevice4ToolStripMenuItem.Name = "loadDevice4ToolStripMenuItem";
            this.loadDevice4ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadDevice4ToolStripMenuItem.Text = "Load Device 4";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // useManualToolStripMenuItem
            // 
            this.useManualToolStripMenuItem.Name = "useManualToolStripMenuItem";
            this.useManualToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.useManualToolStripMenuItem.Text = "User Manual";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(83, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 510);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorCountB);
            this.tabPage1.Controls.Add(this.charCountB);
            this.tabPage1.Controls.Add(this.packetCountB);
            this.tabPage1.Controls.Add(this.errorCountA);
            this.tabPage1.Controls.Add(this.charCountA);
            this.tabPage1.Controls.Add(this.packetCountA);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chartDropdown);
            this.tabPage1.Controls.Add(this.linkblbl);
            this.tabPage1.Controls.Add(this.linkalbl);
            this.tabPage1.Controls.Add(this.dataGridView2);
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
            this.tabPage1.Size = new System.Drawing.Size(971, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Device 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartDropdown
            // 
            this.chartDropdown.FormattingEnabled = true;
            this.chartDropdown.Items.AddRange(new object[] {
            "Line",
            "Bar",
            "Area"});
            this.chartDropdown.Location = new System.Drawing.Point(757, 20);
            this.chartDropdown.Name = "chartDropdown";
            this.chartDropdown.Size = new System.Drawing.Size(121, 21);
            this.chartDropdown.TabIndex = 12;
            this.chartDropdown.Text = "Chart mode";
            this.chartDropdown.SelectedIndexChanged += new System.EventHandler(this.chartDropdown_SelectedIndexChanged);
            // 
            // linkblbl
            // 
            this.linkblbl.AutoSize = true;
            this.linkblbl.Location = new System.Drawing.Point(690, 171);
            this.linkblbl.Name = "linkblbl";
            this.linkblbl.Size = new System.Drawing.Size(13, 13);
            this.linkblbl.TabIndex = 11;
            this.linkblbl.Text = "B";
            // 
            // linkalbl
            // 
            this.linkalbl.AutoSize = true;
            this.linkalbl.Location = new System.Drawing.Point(238, 171);
            this.linkalbl.Name = "linkalbl";
            this.linkalbl.Size = new System.Drawing.Size(14, 13);
            this.linkalbl.TabIndex = 10;
            this.linkalbl.Text = "A";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(501, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(446, 156);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // errorRate
            // 
            this.errorRate.AutoSize = true;
            this.errorRate.Location = new System.Drawing.Point(690, 392);
            this.errorRate.Name = "errorRate";
            this.errorRate.Size = new System.Drawing.Size(30, 13);
            this.errorRate.TabIndex = 8;
            this.errorRate.Text = "err/s";
            // 
            // ErrorRatelbl
            // 
            this.ErrorRatelbl.AutoSize = true;
            this.ErrorRatelbl.Location = new System.Drawing.Point(631, 392);
            this.ErrorRatelbl.Name = "ErrorRatelbl";
            this.ErrorRatelbl.Size = new System.Drawing.Size(58, 13);
            this.ErrorRatelbl.TabIndex = 7;
            this.ErrorRatelbl.Text = "Error rate:";
            // 
            // packetRate
            // 
            this.packetRate.AutoSize = true;
            this.packetRate.Location = new System.Drawing.Point(491, 392);
            this.packetRate.Name = "packetRate";
            this.packetRate.Size = new System.Drawing.Size(48, 13);
            this.packetRate.TabIndex = 6;
            this.packetRate.Text = "packet/s";
            // 
            // PacketRatelbl
            // 
            this.PacketRatelbl.AutoSize = true;
            this.PacketRatelbl.Location = new System.Drawing.Point(420, 392);
            this.PacketRatelbl.Name = "PacketRatelbl";
            this.PacketRatelbl.Size = new System.Drawing.Size(66, 13);
            this.PacketRatelbl.TabIndex = 5;
            this.PacketRatelbl.Text = "Packet rate:";
            // 
            // dataRate
            // 
            this.dataRate.AutoSize = true;
            this.dataRate.Location = new System.Drawing.Point(311, 392);
            this.dataRate.Name = "dataRate";
            this.dataRate.Size = new System.Drawing.Size(30, 13);
            this.dataRate.TabIndex = 4;
            this.dataRate.Text = "mb/s";
            // 
            // DataRatelbl
            // 
            this.DataRatelbl.AutoSize = true;
            this.DataRatelbl.Location = new System.Drawing.Point(251, 392);
            this.DataRatelbl.Name = "DataRatelbl";
            this.DataRatelbl.Size = new System.Drawing.Size(57, 13);
            this.DataRatelbl.TabIndex = 3;
            this.DataRatelbl.Text = "Data rate:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "CRCs",
            "Out of seq",
            "Data errors",
            "Disconnect",
            "EPPs and timeout"});
            this.checkedListBox1.Location = new System.Drawing.Point(757, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 84);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeCol,
            this.dataCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(49, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time";
            this.timeCol.Name = "timeCol";
            this.timeCol.Width = 115;
            // 
            // dataCol
            // 
            this.dataCol.HeaderText = "Data";
            this.dataCol.Name = "dataCol";
            this.dataCol.Width = 150;
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 20);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "A";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "B";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "error";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(705, 130);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(971, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Device 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(971, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Device 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "No. Packets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "No. Chars: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "No. Errors: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "No. Errors: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "No. Chars: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. Packets:";
            // 
            // packetCountA
            // 
            this.packetCountA.AutoSize = true;
            this.packetCountA.Location = new System.Drawing.Point(120, 346);
            this.packetCountA.Name = "packetCountA";
            this.packetCountA.Size = new System.Drawing.Size(35, 13);
            this.packetCountA.TabIndex = 19;
            this.packetCountA.Text = "label7";
            // 
            // charCountA
            // 
            this.charCountA.AutoSize = true;
            this.charCountA.Location = new System.Drawing.Point(268, 346);
            this.charCountA.Name = "charCountA";
            this.charCountA.Size = new System.Drawing.Size(35, 13);
            this.charCountA.TabIndex = 20;
            this.charCountA.Text = "label8";
            // 
            // errorCountA
            // 
            this.errorCountA.AutoSize = true;
            this.errorCountA.Location = new System.Drawing.Point(432, 346);
            this.errorCountA.Name = "errorCountA";
            this.errorCountA.Size = new System.Drawing.Size(35, 13);
            this.errorCountA.TabIndex = 21;
            this.errorCountA.Text = "label9";
            // 
            // packetCountB
            // 
            this.packetCountB.AutoSize = true;
            this.packetCountB.Location = new System.Drawing.Point(578, 346);
            this.packetCountB.Name = "packetCountB";
            this.packetCountB.Size = new System.Drawing.Size(41, 13);
            this.packetCountB.TabIndex = 22;
            this.packetCountB.Text = "label10";
            // 
            // charCountB
            // 
            this.charCountB.AutoSize = true;
            this.charCountB.Location = new System.Drawing.Point(726, 346);
            this.charCountB.Name = "charCountB";
            this.charCountB.Size = new System.Drawing.Size(41, 13);
            this.charCountB.TabIndex = 23;
            this.charCountB.Text = "label11";
            // 
            // errorCountB
            // 
            this.errorCountB.AutoSize = true;
            this.errorCountB.Location = new System.Drawing.Point(878, 346);
            this.errorCountB.Name = "errorCountB";
            this.errorCountB.Size = new System.Drawing.Size(41, 13);
            this.errorCountB.TabIndex = 24;
            this.errorCountB.Text = "label12";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1062, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label ErrorRatelbl;
        private System.Windows.Forms.Label PacketRatelbl;
        private System.Windows.Forms.Label DataRatelbl;
        private System.Windows.Forms.Label dataRate;
        private System.Windows.Forms.Label packetRate;
        private System.Windows.Forms.Label errorRate;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDevice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDevice3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDevice4ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label linkblbl;
        private System.Windows.Forms.Label linkalbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox chartDropdown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCol;
        private System.Windows.Forms.Label errorCountB;
        private System.Windows.Forms.Label charCountB;
        private System.Windows.Forms.Label packetCountB;
        private System.Windows.Forms.Label errorCountA;
        private System.Windows.Forms.Label charCountA;
        private System.Windows.Forms.Label packetCountA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

