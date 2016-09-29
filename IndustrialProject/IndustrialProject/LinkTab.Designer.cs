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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorCountA = new System.Windows.Forms.Label();
            this.charCountA = new System.Windows.Forms.Label();
            this.packetCountA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorRate = new System.Windows.Forms.Label();
            this.ErrorRatelbl = new System.Windows.Forms.Label();
            this.packetRate = new System.Windows.Forms.Label();
            this.PacketRatelbl = new System.Windows.Forms.Label();
            this.dataRate = new System.Windows.Forms.Label();
            this.DataRatelbl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataRateBtn = new System.Windows.Forms.RadioButton();
            this.packetRateBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalErrorLabel = new System.Windows.Forms.Label();
            this.errorsOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorCountA
            // 
            this.errorCountA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCountA.AutoSize = true;
            this.errorCountA.Location = new System.Drawing.Point(396, 494);
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
            this.charCountA.Location = new System.Drawing.Point(263, 494);
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
            this.packetCountA.Location = new System.Drawing.Point(78, 494);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(331, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "No. Errors: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(168, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "No. Data chars: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "No. Packets:";
            // 
            // errorRate
            // 
            this.errorRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorRate.AutoSize = true;
            this.errorRate.Location = new System.Drawing.Point(931, 494);
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
            this.ErrorRatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorRatelbl.Location = new System.Drawing.Point(870, 494);
            this.ErrorRatelbl.Name = "ErrorRatelbl";
            this.ErrorRatelbl.Size = new System.Drawing.Size(64, 13);
            this.ErrorRatelbl.TabIndex = 29;
            this.ErrorRatelbl.Text = "Error rate:";
            // 
            // packetRate
            // 
            this.packetRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetRate.AutoSize = true;
            this.packetRate.Location = new System.Drawing.Point(733, 494);
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
            this.PacketRatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PacketRatelbl.Location = new System.Drawing.Point(659, 494);
            this.PacketRatelbl.Name = "PacketRatelbl";
            this.PacketRatelbl.Size = new System.Drawing.Size(77, 13);
            this.PacketRatelbl.TabIndex = 27;
            this.PacketRatelbl.Text = "Packet rate:";
            // 
            // dataRate
            // 
            this.dataRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRate.AutoSize = true;
            this.dataRate.Location = new System.Drawing.Point(551, 494);
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
            this.DataRatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataRatelbl.Location = new System.Drawing.Point(490, 494);
            this.DataRatelbl.Name = "DataRatelbl";
            this.DataRatelbl.Size = new System.Drawing.Size(64, 13);
            this.DataRatelbl.TabIndex = 25;
            this.DataRatelbl.Text = "Data rate:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "All",
            "Parity",
            "OutofSeq",
            "Header CRC",
            "Body CRC",
            "Too Many Bytes",
            "Not Enough Bytes",
            "EPPs and timeouts",
            "Disconnect"});
            this.checkedListBox1.Location = new System.Drawing.Point(916, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 139);
            this.checkedListBox1.TabIndex = 24;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 263);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 2;
            series4.Name = "A";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "B";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "error";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(909, 223);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataRateBtn
            // 
            this.dataRateBtn.AutoSize = true;
            this.dataRateBtn.Checked = true;
            this.dataRateBtn.Location = new System.Drawing.Point(4, 11);
            this.dataRateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRateBtn.Name = "dataRateBtn";
            this.dataRateBtn.Size = new System.Drawing.Size(74, 17);
            this.dataRateBtn.TabIndex = 40;
            this.dataRateBtn.TabStop = true;
            this.dataRateBtn.Text = "Data Rate";
            this.dataRateBtn.UseVisualStyleBackColor = true;
            this.dataRateBtn.CheckedChanged += new System.EventHandler(this.dataRateBtn_CheckedChanged);
            // 
            // packetRateBtn
            // 
            this.packetRateBtn.AutoSize = true;
            this.packetRateBtn.Location = new System.Drawing.Point(4, 33);
            this.packetRateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.packetRateBtn.Name = "packetRateBtn";
            this.packetRateBtn.Size = new System.Drawing.Size(85, 17);
            this.packetRateBtn.TabIndex = 41;
            this.packetRateBtn.Text = "Packet Rate";
            this.packetRateBtn.UseVisualStyleBackColor = true;
            this.packetRateBtn.CheckedChanged += new System.EventHandler(this.packetRateBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataRateBtn);
            this.groupBox1.Controls.Add(this.packetRateBtn);
            this.groupBox1.Location = new System.Drawing.Point(915, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 81);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // totalErrorLabel
            // 
            this.totalErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalErrorLabel.AutoSize = true;
            this.totalErrorLabel.Location = new System.Drawing.Point(916, 310);
            this.totalErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalErrorLabel.Name = "totalErrorLabel";
            this.totalErrorLabel.Size = new System.Drawing.Size(100, 78);
            this.totalErrorLabel.TabIndex = 44;
            this.totalErrorLabel.Text = "Error Types\r\nSeq\r\nCRCs\r\nData\r\nParity\r\nEEPs and Timeouts";
            this.totalErrorLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // errorsOnlyCheckBox
            // 
            this.errorsOnlyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsOnlyCheckBox.AutoSize = true;
            this.errorsOnlyCheckBox.Location = new System.Drawing.Point(834, 207);
            this.errorsOnlyCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorsOnlyCheckBox.Name = "errorsOnlyCheckBox";
            this.errorsOnlyCheckBox.Size = new System.Drawing.Size(77, 17);
            this.errorsOnlyCheckBox.TabIndex = 47;
            this.errorsOnlyCheckBox.Text = "Errors Only";
            this.errorsOnlyCheckBox.UseVisualStyleBackColor = true;
            this.errorsOnlyCheckBox.CheckedChanged += new System.EventHandler(this.errorsOnlyCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(919, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Totals";
            // 
            // LinkTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorsOnlyCheckBox);
            this.Controls.Add(this.totalErrorLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorCountA);
            this.Controls.Add(this.charCountA);
            this.Controls.Add(this.packetCountA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorRate);
            this.Controls.Add(this.ErrorRatelbl);
            this.Controls.Add(this.packetRate);
            this.Controls.Add(this.PacketRatelbl);
            this.Controls.Add(this.dataRate);
            this.Controls.Add(this.DataRatelbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LinkTab";
            this.Size = new System.Drawing.Size(1054, 512);
            this.Load += new System.EventHandler(this.LinkTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).EndInit();
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
        private System.Windows.Forms.Label errorRate;
        private System.Windows.Forms.Label ErrorRatelbl;
        private System.Windows.Forms.Label packetRate;
        private System.Windows.Forms.Label PacketRatelbl;
        private System.Windows.Forms.Label dataRate;
        private System.Windows.Forms.Label DataRatelbl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource packetBindingSource;
        private System.Windows.Forms.RadioButton dataRateBtn;
        private System.Windows.Forms.RadioButton packetRateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalErrorLabel;
        private System.Windows.Forms.CheckBox errorsOnlyCheckBox;
        private System.Windows.Forms.Label label5;
    }
}
