using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class targeted_total_of_time
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
            this.button1 = new ComboCounter.CustomControls.OutlineButton();
            this.button2 = new ComboCounter.CustomControls.OutlineButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new ComboCounter.CustomControls.TextButton();
            this.plusIcon = new ComboCounter.CustomControls.TextButton();
            this.resetButton = new ComboCounter.CustomControls.OutlineButton();
            this.headerLabel = new ComboCounter.Classes.Header1();
            this.timeSetHeader = new ComboCounter.Classes.H2();
            this.currTimeHeader = new ComboCounter.Classes.H2();
            this.forceAccruedHeader = new ComboCounter.Classes.H2();
            this.currentTime = new ComboCounter.Classes.BigInfo();
            this.totalForce = new ComboCounter.Classes.BigInfo();
            this.setTime = new ComboCounter.Classes.BigInfo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(73, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Size = new System.Drawing.Size(264, 92);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(484, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.Size = new System.Drawing.Size(264, 92);
            this.button2.TabIndex = 10;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minusIcon
            // 
            this.minusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIcon.AutoSize = true;
            this.minusIcon.BackColor = System.Drawing.Color.Transparent;
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.minusIcon.Location = new System.Drawing.Point(4, 80);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIcon.Size = new System.Drawing.Size(100, 79);
            this.minusIcon.TabIndex = 13;
            this.minusIcon.Text = "-";
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIcon.AutoSize = true;
            this.plusIcon.BackColor = System.Drawing.Color.Transparent;
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.plusIcon.Location = new System.Drawing.Point(714, 87);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIcon.Size = new System.Drawing.Size(69, 65);
            this.plusIcon.TabIndex = 14;
            this.plusIcon.Text = "+";
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(895, 71);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButton.Size = new System.Drawing.Size(267, 92);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerLabel, 2);
            this.headerLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.headerLabel.Location = new System.Drawing.Point(861, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(759, 180);
            this.headerLabel.TabIndex = 56;
            this.headerLabel.Text = "Total Time";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeSetHeader
            // 
            this.timeSetHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSetHeader.AutoSize = true;
            this.timeSetHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetHeader.Location = new System.Drawing.Point(233, 285);
            this.timeSetHeader.Name = "timeSetHeader";
            this.timeSetHeader.Size = new System.Drawing.Size(774, 158);
            this.timeSetHeader.TabIndex = 57;
            this.timeSetHeader.Text = "Time Setting";
            // 
            // currTimeHeader
            // 
            this.currTimeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimeHeader.Location = new System.Drawing.Point(1460, 285);
            this.currTimeHeader.Name = "currTimeHeader";
            this.currTimeHeader.Size = new System.Drawing.Size(801, 158);
            this.currTimeHeader.TabIndex = 58;
            this.currTimeHeader.Text = "Current Time";
            // 
            // forceAccruedHeader
            // 
            this.forceAccruedHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedHeader.AutoSize = true;
            this.forceAccruedHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedHeader.Location = new System.Drawing.Point(189, 689);
            this.forceAccruedHeader.Name = "forceAccruedHeader";
            this.forceAccruedHeader.Size = new System.Drawing.Size(861, 158);
            this.forceAccruedHeader.TabIndex = 69;
            this.forceAccruedHeader.Text = "Force Accrued";
            // 
            // currentTime
            // 
            this.currentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTime.AutoSize = true;
            this.currentTime.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime.Location = new System.Drawing.Point(1480, 446);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(761, 240);
            this.currentTime.TabIndex = 78;
            this.currentTime.Text = "00:00.0";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForce.ForeColor = System.Drawing.Color.Maroon;
            this.totalForce.Location = new System.Drawing.Point(514, 847);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(212, 240);
            this.totalForce.TabIndex = 79;
            this.totalForce.Text = "0";
            // 
            // setTime
            // 
            this.setTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTime.AutoSize = true;
            this.setTime.ForeColor = System.Drawing.Color.DimGray;
            this.setTime.Location = new System.Drawing.Point(111, 0);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(596, 240);
            this.setTime.TabIndex = 80;
            this.setTime.Text = "00:30";
            this.setTime.Click += new System.EventHandler(this.setTimeSec_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.totalForce, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.currTimeHeader, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.timeSetHeader, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.forceAccruedHeader, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2481, 1087);
            this.tableLayoutPanel1.TabIndex = 83;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.minusIcon);
            this.flowLayoutPanel1.Controls.Add(this.setTime);
            this.flowLayoutPanel1.Controls.Add(this.plusIcon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(226, 446);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(787, 240);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.resetButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1243, 850);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1235, 234);
            this.tableLayoutPanel2.TabIndex = 80;
            // 
            // targeted_total_of_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "targeted_total_of_time";
            this.Size = new System.Drawing.Size(2481, 1087);
            this.Load += new System.EventHandler(this.home_user2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Timer timer1;
        private OutlineButton button1;
        private OutlineButton button2;
        private OutlineButton resetButton;
        private Header1 headerLabel;
        private H2 timeSetHeader;
        private H2 currTimeHeader;
        private H2 forceAccruedHeader;
        private BigInfo currentTime;
        private BigInfo totalForce;
        private BigInfo setTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TextButton minusIcon;
        private TextButton plusIcon;
    }
}
