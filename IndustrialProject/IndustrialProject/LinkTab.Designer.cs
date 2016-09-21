﻿namespace IndustrialProject
{
    partial class LinkTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorCountA = new System.Windows.Forms.Label();
            this.charCountA = new System.Windows.Forms.Label();
            this.packetCountA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDropdown = new System.Windows.Forms.ComboBox();
            this.errorRate = new System.Windows.Forms.Label();
            this.ErrorRatelbl = new System.Windows.Forms.Label();
            this.packetRate = new System.Windows.Forms.Label();
            this.PacketRatelbl = new System.Windows.Forms.Label();
            this.dataRate = new System.Windows.Forms.Label();
            this.DataRatelbl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorCountA
            // 
            this.errorCountA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCountA.AutoSize = true;
            this.errorCountA.Location = new System.Drawing.Point(397, 321);
            this.errorCountA.Name = "errorCountA";
            this.errorCountA.Size = new System.Drawing.Size(35, 13);
            this.errorCountA.TabIndex = 37;
            this.errorCountA.Text = "label9";
            // 
            // charCountA
            // 
            this.charCountA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charCountA.AutoSize = true;
            this.charCountA.Location = new System.Drawing.Point(233, 321);
            this.charCountA.Name = "charCountA";
            this.charCountA.Size = new System.Drawing.Size(35, 13);
            this.charCountA.TabIndex = 36;
            this.charCountA.Text = "label8";
            // 
            // packetCountA
            // 
            this.packetCountA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetCountA.AutoSize = true;
            this.packetCountA.Location = new System.Drawing.Point(85, 321);
            this.packetCountA.Name = "packetCountA";
            this.packetCountA.Size = new System.Drawing.Size(35, 13);
            this.packetCountA.TabIndex = 35;
            this.packetCountA.Text = "label7";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "No. Errors: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "No. Chars: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "No. Packets:";
            // 
            // chartDropdown
            // 
            this.chartDropdown.FormattingEnabled = true;
            this.chartDropdown.Items.AddRange(new object[] {
            "Line",
            "Bar",
            "Area"});
            this.chartDropdown.Location = new System.Drawing.Point(828, 9);
            this.chartDropdown.Name = "chartDropdown";
            this.chartDropdown.Size = new System.Drawing.Size(121, 21);
            this.chartDropdown.TabIndex = 31;
            this.chartDropdown.Text = "Chart mode";
            this.chartDropdown.SelectedIndexChanged += new System.EventHandler(this.chartDropdown_SelectedIndexChanged);
            // 
            // errorRate
            // 
            this.errorRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorRate.AutoSize = true;
            this.errorRate.Location = new System.Drawing.Point(926, 321);
            this.errorRate.Name = "errorRate";
            this.errorRate.Size = new System.Drawing.Size(29, 13);
            this.errorRate.TabIndex = 30;
            this.errorRate.Text = "err/s";
            // 
            // ErrorRatelbl
            // 
            this.ErrorRatelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorRatelbl.AutoSize = true;
            this.ErrorRatelbl.Location = new System.Drawing.Point(867, 321);
            this.ErrorRatelbl.Name = "ErrorRatelbl";
            this.ErrorRatelbl.Size = new System.Drawing.Size(53, 13);
            this.ErrorRatelbl.TabIndex = 29;
            this.ErrorRatelbl.Text = "Error rate:";
            // 
            // packetRate
            // 
            this.packetRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetRate.AutoSize = true;
            this.packetRate.Location = new System.Drawing.Point(727, 321);
            this.packetRate.Name = "packetRate";
            this.packetRate.Size = new System.Drawing.Size(50, 13);
            this.packetRate.TabIndex = 28;
            this.packetRate.Text = "packet/s";
            // 
            // PacketRatelbl
            // 
            this.PacketRatelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PacketRatelbl.AutoSize = true;
            this.PacketRatelbl.Location = new System.Drawing.Point(656, 321);
            this.PacketRatelbl.Name = "PacketRatelbl";
            this.PacketRatelbl.Size = new System.Drawing.Size(65, 13);
            this.PacketRatelbl.TabIndex = 27;
            this.PacketRatelbl.Text = "Packet rate:";
            // 
            // dataRate
            // 
            this.dataRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRate.AutoSize = true;
            this.dataRate.Location = new System.Drawing.Point(547, 321);
            this.dataRate.Name = "dataRate";
            this.dataRate.Size = new System.Drawing.Size(31, 13);
            this.dataRate.TabIndex = 26;
            this.dataRate.Text = "mb/s";
            // 
            // DataRatelbl
            // 
            this.DataRatelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataRatelbl.AutoSize = true;
            this.DataRatelbl.Location = new System.Drawing.Point(487, 321);
            this.DataRatelbl.Name = "DataRatelbl";
            this.DataRatelbl.Size = new System.Drawing.Size(54, 13);
            this.DataRatelbl.TabIndex = 25;
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
            this.checkedListBox1.Location = new System.Drawing.Point(838, 36);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 64);
            this.checkedListBox1.TabIndex = 24;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 156);
            this.dataGridView1.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
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
            this.chart1.Size = new System.Drawing.Size(819, 150);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // LinkTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorCountA);
            this.Controls.Add(this.charCountA);
            this.Controls.Add(this.packetCountA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDropdown);
            this.Controls.Add(this.errorRate);
            this.Controls.Add(this.ErrorRatelbl);
            this.Controls.Add(this.packetRate);
            this.Controls.Add(this.PacketRatelbl);
            this.Controls.Add(this.dataRate);
            this.Controls.Add(this.DataRatelbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "LinkTab";
            this.Size = new System.Drawing.Size(958, 345);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorCountA;
        private System.Windows.Forms.Label charCountA;
        private System.Windows.Forms.Label packetCountA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chartDropdown;
        private System.Windows.Forms.Label errorRate;
        private System.Windows.Forms.Label ErrorRatelbl;
        private System.Windows.Forms.Label packetRate;
        private System.Windows.Forms.Label PacketRatelbl;
        private System.Windows.Forms.Label dataRate;
        private System.Windows.Forms.Label DataRatelbl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}