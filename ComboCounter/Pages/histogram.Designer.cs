namespace ComboCounter.UserControls
{
    partial class histogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.h41 = new ComboCounter.Classes.H4();
            this.TotForceInfo = new ComboCounter.Classes.SmallInfo();
            this.HardestHitInfo = new ComboCounter.Classes.SmallInfo();
            this.h42 = new ComboCounter.Classes.H4();
            this.AvgForceInfo = new ComboCounter.Classes.SmallInfo();
            this.h43 = new ComboCounter.Classes.H4();
            this.h44 = new ComboCounter.Classes.H4();
            this.h45 = new ComboCounter.Classes.H4();
            this.shortestTimeLabel = new ComboCounter.Classes.SmallInfo();
            this.averageTimeLabel = new ComboCounter.Classes.SmallInfo();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(679, 165);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1051, 618);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(618, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 37);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.h41, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotForceInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.HardestHitInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.h42, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AvgForceInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.h43, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.h44, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.h45, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.shortestTimeLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.averageTimeLabel, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 618);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // h41
            // 
            this.h41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h41.AutoSize = true;
            this.h41.Location = new System.Drawing.Point(107, 34);
            this.h41.Name = "h41";
            this.h41.Size = new System.Drawing.Size(240, 54);
            this.h41.TabIndex = 0;
            this.h41.Text = "Hardest Hit";
            // 
            // TotForceInfo
            // 
            this.TotForceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotForceInfo.AutoSize = true;
            this.TotForceInfo.Location = new System.Drawing.Point(472, 277);
            this.TotForceInfo.Name = "TotForceInfo";
            this.TotForceInfo.Size = new System.Drawing.Size(133, 61);
            this.TotForceInfo.TabIndex = 5;
            this.TotForceInfo.Text = "0 lbs";
            // 
            // HardestHitInfo
            // 
            this.HardestHitInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardestHitInfo.AutoSize = true;
            this.HardestHitInfo.Location = new System.Drawing.Point(472, 31);
            this.HardestHitInfo.Name = "HardestHitInfo";
            this.HardestHitInfo.Size = new System.Drawing.Size(133, 61);
            this.HardestHitInfo.TabIndex = 1;
            this.HardestHitInfo.Text = "0 lbs";
            // 
            // h42
            // 
            this.h42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h42.AutoSize = true;
            this.h42.Location = new System.Drawing.Point(81, 157);
            this.h42.Name = "h42";
            this.h42.Size = new System.Drawing.Size(292, 54);
            this.h42.TabIndex = 2;
            this.h42.Text = "Average Force";
            // 
            // AvgForceInfo
            // 
            this.AvgForceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgForceInfo.AutoSize = true;
            this.AvgForceInfo.Location = new System.Drawing.Point(472, 154);
            this.AvgForceInfo.Name = "AvgForceInfo";
            this.AvgForceInfo.Size = new System.Drawing.Size(133, 61);
            this.AvgForceInfo.TabIndex = 4;
            this.AvgForceInfo.Text = "0 lbs";
            // 
            // h43
            // 
            this.h43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h43.AutoSize = true;
            this.h43.Location = new System.Drawing.Point(111, 280);
            this.h43.Name = "h43";
            this.h43.Size = new System.Drawing.Size(233, 54);
            this.h43.TabIndex = 3;
            this.h43.Text = "Total Force";
            // 
            // h44
            // 
            this.h44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h44.AutoSize = true;
            this.h44.Location = new System.Drawing.Point(3, 403);
            this.h44.Name = "h44";
            this.h44.Size = new System.Drawing.Size(449, 54);
            this.h44.TabIndex = 6;
            this.h44.Text = "Shortest Time Interval";
            // 
            // h45
            // 
            this.h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h45.AutoSize = true;
            this.h45.Location = new System.Drawing.Point(5, 528);
            this.h45.Name = "h45";
            this.h45.Size = new System.Drawing.Size(445, 54);
            this.h45.TabIndex = 7;
            this.h45.Text = "Average Time Interval";
            // 
            // shortestTimeLabel
            // 
            this.shortestTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortestTimeLabel.AutoSize = true;
            this.shortestTimeLabel.Location = new System.Drawing.Point(478, 400);
            this.shortestTimeLabel.Name = "shortestTimeLabel";
            this.shortestTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shortestTimeLabel.Size = new System.Drawing.Size(122, 61);
            this.shortestTimeLabel.TabIndex = 8;
            this.shortestTimeLabel.Text = "0.0s";
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageTimeLabel.AutoSize = true;
            this.averageTimeLabel.Location = new System.Drawing.Point(478, 524);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(122, 61);
            this.averageTimeLabel.TabIndex = 9;
            this.averageTimeLabel.Text = "0.0s";
            // 
            // histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "histogram";
            this.Size = new System.Drawing.Size(1730, 846);
            this.Load += new System.EventHandler(this.histogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Classes.H4 h41;
        private Classes.SmallInfo HardestHitInfo;
        private Classes.H4 h42;
        private Classes.H4 h43;
        private Classes.SmallInfo AvgForceInfo;
        private Classes.SmallInfo TotForceInfo;
        private Classes.H4 h44;
        private Classes.H4 h45;
        private Classes.SmallInfo shortestTimeLabel;
        private Classes.SmallInfo averageTimeLabel;
    }
}
