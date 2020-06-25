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
            this.HardestHitInfo = new ComboCounter.Classes.SmallInfo();
            this.h42 = new ComboCounter.Classes.H4();
            this.h43 = new ComboCounter.Classes.H4();
            this.AvgForceInfo = new ComboCounter.Classes.SmallInfo();
            this.TotForceInfo = new ComboCounter.Classes.SmallInfo();
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
            this.chart1.Location = new System.Drawing.Point(207, 273);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1365, 558);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.h41, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardestHitInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.h42, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.h43, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AvgForceInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotForceInfo, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(370, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 145);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // h41
            // 
            this.h41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h41.AutoSize = true;
            this.h41.ForeColor = System.Drawing.Color.SteelBlue;
            this.h41.Location = new System.Drawing.Point(36, 9);
            this.h41.Name = "h41";
            this.h41.Size = new System.Drawing.Size(240, 54);
            this.h41.TabIndex = 0;
            this.h41.Text = "Hardest Hit";
            // 
            // HardestHitInfo
            // 
            this.HardestHitInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardestHitInfo.AutoSize = true;
            this.HardestHitInfo.ForeColor = System.Drawing.Color.LightBlue;
            this.HardestHitInfo.Location = new System.Drawing.Point(156, 78);
            this.HardestHitInfo.Name = "HardestHitInfo";
            this.HardestHitInfo.Size = new System.Drawing.Size(0, 61);
            this.HardestHitInfo.TabIndex = 1;
            // 
            // h42
            // 
            this.h42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h42.AutoSize = true;
            this.h42.ForeColor = System.Drawing.Color.SteelBlue;
            this.h42.Location = new System.Drawing.Point(323, 9);
            this.h42.Name = "h42";
            this.h42.Size = new System.Drawing.Size(292, 54);
            this.h42.TabIndex = 2;
            this.h42.Text = "Average Force";
            // 
            // h43
            // 
            this.h43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.h43.AutoSize = true;
            this.h43.ForeColor = System.Drawing.Color.SteelBlue;
            this.h43.Location = new System.Drawing.Point(667, 9);
            this.h43.Name = "h43";
            this.h43.Size = new System.Drawing.Size(233, 54);
            this.h43.TabIndex = 3;
            this.h43.Text = "Total Force";
            // 
            // AvgForceInfo
            // 
            this.AvgForceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgForceInfo.AutoSize = true;
            this.AvgForceInfo.ForeColor = System.Drawing.Color.LightBlue;
            this.AvgForceInfo.Location = new System.Drawing.Point(469, 78);
            this.AvgForceInfo.Name = "AvgForceInfo";
            this.AvgForceInfo.Size = new System.Drawing.Size(0, 61);
            this.AvgForceInfo.TabIndex = 4;
            // 
            // TotForceInfo
            // 
            this.TotForceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotForceInfo.AutoSize = true;
            this.TotForceInfo.ForeColor = System.Drawing.Color.LightBlue;
            this.TotForceInfo.Location = new System.Drawing.Point(783, 78);
            this.TotForceInfo.Name = "TotForceInfo";
            this.TotForceInfo.Size = new System.Drawing.Size(0, 61);
            this.TotForceInfo.TabIndex = 5;
            // 
            // histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "histogram";
            this.Size = new System.Drawing.Size(1730, 831);
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
    }
}
