using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class targeted_total_of_force
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plusIcon = new ComboCounter.CustomControls.TextButton();
            this.minusIcon = new ComboCounter.CustomControls.TextButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.forceGoalHeader = new ComboCounter.Classes.H2();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.forceGoalLabel = new ComboCounter.Classes.BigInfo();
            this.totalForce = new ComboCounter.Classes.BigInfo();
            this.forceAccruedHeader = new ComboCounter.Classes.H2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currTimeHeader = new ComboCounter.Classes.H2();
            this.txtResult = new ComboCounter.Classes.BigInfo();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new ComboCounter.CustomControls.OutlineButton();
            this.stopButton = new ComboCounter.CustomControls.OutlineButton();
            this.resetButton = new ComboCounter.CustomControls.OutlineButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.header = new ComboCounter.Classes.Header1();
            this.visualFeedbackControl1 = new ComboCounter.CustomControls.VisualFeedbackControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // plusIcon
            // 
            this.plusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIcon.AutoSize = true;
            this.plusIcon.BackColor = System.Drawing.Color.Transparent;
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(784, 89);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIcon.Size = new System.Drawing.Size(68, 61);
            this.plusIcon.TabIndex = 78;
            this.plusIcon.Text = "+";
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIcon.AutoSize = true;
            this.minusIcon.BackColor = System.Drawing.Color.Transparent;
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(4, 83);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIcon.Size = new System.Drawing.Size(67, 73);
            this.minusIcon.TabIndex = 79;
            this.minusIcon.Text = "-";
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.forceGoalHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalForce, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.forceAccruedHeader, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 845);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // forceGoalHeader
            // 
            this.forceGoalHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceGoalHeader.AutoSize = true;
            this.forceGoalHeader.Location = new System.Drawing.Point(295, 0);
            this.forceGoalHeader.Name = "forceGoalHeader";
            this.forceGoalHeader.Size = new System.Drawing.Size(644, 158);
            this.forceGoalHeader.TabIndex = 66;
            this.forceGoalHeader.Text = "Force Goal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.minusIcon);
            this.flowLayoutPanel1.Controls.Add(this.forceGoalLabel);
            this.flowLayoutPanel1.Controls.Add(this.plusIcon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 161);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 240);
            this.flowLayoutPanel1.TabIndex = 67;
            // 
            // forceGoalLabel
            // 
            this.forceGoalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGoalLabel.AutoSize = true;
            this.forceGoalLabel.Location = new System.Drawing.Point(78, 0);
            this.forceGoalLabel.Name = "forceGoalLabel";
            this.forceGoalLabel.Size = new System.Drawing.Size(699, 240);
            this.forceGoalLabel.TabIndex = 75;
            this.forceGoalLabel.Text = "15,000";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForce.AutoSize = true;
            this.totalForce.Location = new System.Drawing.Point(511, 583);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(212, 240);
            this.totalForce.TabIndex = 76;
            this.totalForce.Text = "0";
            // 
            // forceAccruedHeader
            // 
            this.forceAccruedHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedHeader.AutoSize = true;
            this.forceAccruedHeader.Location = new System.Drawing.Point(186, 404);
            this.forceAccruedHeader.Name = "forceAccruedHeader";
            this.forceAccruedHeader.Size = new System.Drawing.Size(861, 158);
            this.forceAccruedHeader.TabIndex = 68;
            this.forceAccruedHeader.Text = "Force Accrued";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.currTimeHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtResult, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.visualFeedbackControl1, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1233, 845);
            this.tableLayoutPanel2.TabIndex = 81;
            // 
            // currTimeHeader
            // 
            this.currTimeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.Location = new System.Drawing.Point(216, 0);
            this.currTimeHeader.Name = "currTimeHeader";
            this.currTimeHeader.Size = new System.Drawing.Size(801, 158);
            this.currTimeHeader.TabIndex = 67;
            this.currTimeHeader.Text = "Current Time";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(236, 158);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(761, 240);
            this.txtResult.TabIndex = 77;
            this.txtResult.Text = "00:00.0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.startButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.stopButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.resetButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 401);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1227, 100);
            this.tableLayoutPanel3.TabIndex = 78;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(70, 4);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.startButton.Size = new System.Drawing.Size(268, 92);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(479, 4);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.stopButton.Size = new System.Drawing.Size(268, 92);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(888, 4);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.resetButton.Size = new System.Drawing.Size(268, 92);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(17, 212);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(2471, 845);
            this.splitContainer1.SplitterDistance = 1234;
            this.splitContainer1.TabIndex = 82;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(478, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(778, 180);
            this.header.TabIndex = 57;
            this.header.Text = "Total Force";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visualFeedbackControl1
            // 
            this.visualFeedbackControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visualFeedbackControl1.Location = new System.Drawing.Point(88, 567);
            this.visualFeedbackControl1.MaxForce = 300F;
            this.visualFeedbackControl1.Name = "visualFeedbackControl1";
            this.visualFeedbackControl1.Size = new System.Drawing.Size(1056, 214);
            this.visualFeedbackControl1.TabIndex = 79;
            // 
            // targeted_total_of_force
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.header);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "targeted_total_of_force";
            this.Size = new System.Drawing.Size(2488, 1097);
            this.Load += new System.EventHandler(this.targeted_total_of_force_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Header1 header;
        private H2 forceGoalHeader;
        private H2 currTimeHeader;
        private H2 forceAccruedHeader;
        private BigInfo forceGoalLabel;
        private BigInfo totalForce;
        private BigInfo txtResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OutlineButton startButton;
        private OutlineButton stopButton;
        private OutlineButton resetButton;
        private TextButton plusIcon;
        private TextButton minusIcon;
        private VisualFeedbackControl visualFeedbackControl1;
    }
}
