using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class Targeted_total_of_force_comp
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.header = new ComboCounter.Classes.H2();
            this.player1Header = new ComboCounter.Classes.H3();
            this.label2 = new ComboCounter.Classes.H3();
            this.forceGoalPlayer1Header = new ComboCounter.Classes.H3();
            this.currTimeHeaderPlayer1 = new ComboCounter.Classes.H3();
            this.forceAccruedPlayer1Header = new ComboCounter.Classes.H3();
            this.currTimePlayer1 = new ComboCounter.Classes.MediumInfo();
            this.totalForcePlayer1 = new ComboCounter.Classes.MediumInfo();
            this.forceGoalHeaderPlayer2 = new ComboCounter.Classes.H3();
            this.currTimeHeaderPlayer2 = new ComboCounter.Classes.H3();
            this.forceAccruedHeaderPlayer2 = new ComboCounter.Classes.H3();
            this.forceGoalPlayer2 = new ComboCounter.Classes.MediumInfo();
            this.currTimePlayer2 = new ComboCounter.Classes.MediumInfo();
            this.totalForcePlayer2 = new ComboCounter.Classes.MediumInfo();
            this.startButton1 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButton1 = new ComboCounter.CustomControls.OutlineButton();
            this.resetButton1 = new ComboCounter.CustomControls.OutlineButton();
            this.resetButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.startButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.plusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.minusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.plusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.minusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.forceGoalPlayer1 = new ComboCounter.Classes.MediumInfo();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1080, 174);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(13, 821);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.Location = new System.Drawing.Point(0, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(2261, 158);
            this.header.TabIndex = 56;
            this.header.Text = "Total Force Competition";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Header
            // 
            this.player1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1Header.AutoSize = true;
            this.player1Header.Location = new System.Drawing.Point(279, 0);
            this.player1Header.Name = "player1Header";
            this.player1Header.Size = new System.Drawing.Size(232, 81);
            this.player1Header.TabIndex = 57;
            this.player1Header.Text = "Guest 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 81);
            this.label2.TabIndex = 58;
            this.label2.Text = "Guest 2";
            // 
            // forceGoalPlayer1Header
            // 
            this.forceGoalPlayer1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceGoalPlayer1Header.AutoSize = true;
            this.forceGoalPlayer1Header.Location = new System.Drawing.Point(230, 81);
            this.forceGoalPlayer1Header.Name = "forceGoalPlayer1Header";
            this.forceGoalPlayer1Header.Size = new System.Drawing.Size(330, 81);
            this.forceGoalPlayer1Header.TabIndex = 59;
            this.forceGoalPlayer1Header.Text = "Force Goal";
            // 
            // currTimeHeaderPlayer1
            // 
            this.currTimeHeaderPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimeHeaderPlayer1.AutoSize = true;
            this.currTimeHeaderPlayer1.Location = new System.Drawing.Point(190, 288);
            this.currTimeHeaderPlayer1.Name = "currTimeHeaderPlayer1";
            this.currTimeHeaderPlayer1.Size = new System.Drawing.Size(410, 81);
            this.currTimeHeaderPlayer1.TabIndex = 60;
            this.currTimeHeaderPlayer1.Text = "Current Time";
            // 
            // forceAccruedPlayer1Header
            // 
            this.forceAccruedPlayer1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedPlayer1Header.AutoSize = true;
            this.forceAccruedPlayer1Header.Location = new System.Drawing.Point(175, 489);
            this.forceAccruedPlayer1Header.Name = "forceAccruedPlayer1Header";
            this.forceAccruedPlayer1Header.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedPlayer1Header.TabIndex = 61;
            this.forceAccruedPlayer1Header.Text = "Force Accrued";
            // 
            // currTimePlayer1
            // 
            this.currTimePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimePlayer1.AutoSize = true;
            this.currTimePlayer1.Location = new System.Drawing.Point(205, 369);
            this.currTimePlayer1.Name = "currTimePlayer1";
            this.currTimePlayer1.Size = new System.Drawing.Size(380, 120);
            this.currTimePlayer1.TabIndex = 63;
            this.currTimePlayer1.Text = "00:00.0";
            // 
            // totalForcePlayer1
            // 
            this.totalForcePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer1.AutoSize = true;
            this.totalForcePlayer1.Location = new System.Drawing.Point(281, 635);
            this.totalForcePlayer1.Name = "totalForcePlayer1";
            this.totalForcePlayer1.Size = new System.Drawing.Size(227, 120);
            this.totalForcePlayer1.TabIndex = 64;
            this.totalForcePlayer1.Text = "N/A";
            // 
            // forceGoalHeaderPlayer2
            // 
            this.forceGoalHeaderPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceGoalHeaderPlayer2.AutoSize = true;
            this.forceGoalHeaderPlayer2.Location = new System.Drawing.Point(263, 81);
            this.forceGoalHeaderPlayer2.Name = "forceGoalHeaderPlayer2";
            this.forceGoalHeaderPlayer2.Size = new System.Drawing.Size(330, 81);
            this.forceGoalHeaderPlayer2.TabIndex = 65;
            this.forceGoalHeaderPlayer2.Text = "Force Goal";
            // 
            // currTimeHeaderPlayer2
            // 
            this.currTimeHeaderPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimeHeaderPlayer2.AutoSize = true;
            this.currTimeHeaderPlayer2.Location = new System.Drawing.Point(223, 288);
            this.currTimeHeaderPlayer2.Name = "currTimeHeaderPlayer2";
            this.currTimeHeaderPlayer2.Size = new System.Drawing.Size(410, 81);
            this.currTimeHeaderPlayer2.TabIndex = 66;
            this.currTimeHeaderPlayer2.Text = "Current Time";
            // 
            // forceAccruedHeaderPlayer2
            // 
            this.forceAccruedHeaderPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedHeaderPlayer2.AutoSize = true;
            this.forceAccruedHeaderPlayer2.Location = new System.Drawing.Point(208, 489);
            this.forceAccruedHeaderPlayer2.Name = "forceAccruedHeaderPlayer2";
            this.forceAccruedHeaderPlayer2.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedHeaderPlayer2.TabIndex = 67;
            this.forceAccruedHeaderPlayer2.Text = "Force Accrued";
            // 
            // forceGoalPlayer2
            // 
            this.forceGoalPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceGoalPlayer2.AutoSize = true;
            this.forceGoalPlayer2.Location = new System.Drawing.Point(78, 0);
            this.forceGoalPlayer2.Name = "forceGoalPlayer2";
            this.forceGoalPlayer2.Size = new System.Drawing.Size(350, 120);
            this.forceGoalPlayer2.TabIndex = 68;
            this.forceGoalPlayer2.Text = "15,000";
            // 
            // currTimePlayer2
            // 
            this.currTimePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimePlayer2.AutoSize = true;
            this.currTimePlayer2.Location = new System.Drawing.Point(238, 369);
            this.currTimePlayer2.Name = "currTimePlayer2";
            this.currTimePlayer2.Size = new System.Drawing.Size(380, 120);
            this.currTimePlayer2.TabIndex = 69;
            this.currTimePlayer2.Text = "00:00.0";
            // 
            // totalForcePlayer2
            // 
            this.totalForcePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer2.AutoSize = true;
            this.totalForcePlayer2.Location = new System.Drawing.Point(314, 635);
            this.totalForcePlayer2.Name = "totalForcePlayer2";
            this.totalForcePlayer2.Size = new System.Drawing.Size(227, 120);
            this.totalForcePlayer2.TabIndex = 70;
            this.totalForcePlayer2.Text = "N/A";
            // 
            // startButton1
            // 
            this.startButton1.AutoSize = true;
            this.startButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.startButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton1.Location = new System.Drawing.Point(1963, 396);
            this.startButton1.Margin = new System.Windows.Forms.Padding(4);
            this.startButton1.Name = "startButton1";
            this.startButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButton1.Size = new System.Drawing.Size(216, 75);
            this.startButton1.TabIndex = 71;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click_1);
            // 
            // stopButton1
            // 
            this.stopButton1.AutoSize = true;
            this.stopButton1.BackColor = System.Drawing.Color.Transparent;
            this.stopButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton1.Location = new System.Drawing.Point(1963, 556);
            this.stopButton1.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton1.Name = "stopButton1";
            this.stopButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButton1.Size = new System.Drawing.Size(216, 75);
            this.stopButton1.TabIndex = 72;
            this.stopButton1.Text = "Stop";
            this.stopButton1.UseVisualStyleBackColor = true;
            this.stopButton1.Click += new System.EventHandler(this.stopButton1_Click_1);
            // 
            // resetButton1
            // 
            this.resetButton1.AutoSize = true;
            this.resetButton1.BackColor = System.Drawing.Color.Transparent;
            this.resetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton1.Location = new System.Drawing.Point(1963, 726);
            this.resetButton1.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetButton1.Size = new System.Drawing.Size(216, 75);
            this.resetButton1.TabIndex = 73;
            this.resetButton1.Text = "Reset";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click_1);
            // 
            // resetButtonPlayer1
            // 
            this.resetButtonPlayer1.AutoSize = true;
            this.resetButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.resetButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButtonPlayer1.Location = new System.Drawing.Point(53, 726);
            this.resetButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer1.Name = "resetButtonPlayer1";
            this.resetButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetButtonPlayer1.Size = new System.Drawing.Size(223, 75);
            this.resetButtonPlayer1.TabIndex = 74;
            this.resetButtonPlayer1.Text = "Reset";
            this.resetButtonPlayer1.UseVisualStyleBackColor = true;
            this.resetButtonPlayer1.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // stopButtonPlayer1
            // 
            this.stopButtonPlayer1.AutoSize = true;
            this.stopButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.stopButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButtonPlayer1.Location = new System.Drawing.Point(53, 556);
            this.stopButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer1.Name = "stopButtonPlayer1";
            this.stopButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer1.Size = new System.Drawing.Size(223, 75);
            this.stopButtonPlayer1.TabIndex = 75;
            this.stopButtonPlayer1.Text = "Stop";
            this.stopButtonPlayer1.UseVisualStyleBackColor = true;
            this.stopButtonPlayer1.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // startButtonPlayer1
            // 
            this.startButtonPlayer1.AutoSize = true;
            this.startButtonPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.startButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButtonPlayer1.Location = new System.Drawing.Point(53, 396);
            this.startButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer1.Name = "startButtonPlayer1";
            this.startButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer1.Size = new System.Drawing.Size(223, 75);
            this.startButtonPlayer1.TabIndex = 76;
            this.startButtonPlayer1.Text = "Start";
            this.startButtonPlayer1.UseVisualStyleBackColor = false;
            this.startButtonPlayer1.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // plusIconPlayer2
            // 
            this.plusIconPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIconPlayer2.AutoSize = true;
            this.plusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer2.Location = new System.Drawing.Point(435, 29);
            this.plusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer2.Name = "plusIconPlayer2";
            this.plusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer2.Size = new System.Drawing.Size(68, 61);
            this.plusIconPlayer2.TabIndex = 77;
            this.plusIconPlayer2.Text = "+";
            this.plusIconPlayer2.UseVisualStyleBackColor = true;
            this.plusIconPlayer2.Click += new System.EventHandler(this.plus_icon_player_2_click);
            // 
            // minusIconPlayer2
            // 
            this.minusIconPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIconPlayer2.AutoSize = true;
            this.minusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer2.Location = new System.Drawing.Point(4, 23);
            this.minusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer2.Name = "minusIconPlayer2";
            this.minusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer2.Size = new System.Drawing.Size(67, 73);
            this.minusIconPlayer2.TabIndex = 78;
            this.minusIconPlayer2.Text = "-";
            this.minusIconPlayer2.UseVisualStyleBackColor = true;
            this.minusIconPlayer2.Click += new System.EventHandler(this.minusIcon_Player2_Click);
            // 
            // plusIconPlayer1
            // 
            this.plusIconPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIconPlayer1.AutoSize = true;
            this.plusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer1.Location = new System.Drawing.Point(435, 29);
            this.plusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer1.Name = "plusIconPlayer1";
            this.plusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer1.Size = new System.Drawing.Size(67, 61);
            this.plusIconPlayer1.TabIndex = 79;
            this.plusIconPlayer1.Text = "+";
            this.plusIconPlayer1.UseVisualStyleBackColor = true;
            this.plusIconPlayer1.Click += new System.EventHandler(this.plus_icon_player_1_click);
            // 
            // minusIconPlayer1
            // 
            this.minusIconPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIconPlayer1.AutoSize = true;
            this.minusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer1.Location = new System.Drawing.Point(4, 23);
            this.minusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer1.Name = "minusIconPlayer1";
            this.minusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer1.Size = new System.Drawing.Size(67, 73);
            this.minusIconPlayer1.TabIndex = 80;
            this.minusIconPlayer1.Text = "-";
            this.minusIconPlayer1.UseVisualStyleBackColor = true;
            this.minusIconPlayer1.Click += new System.EventHandler(this.minusIcon_Player1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.player1Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.forceGoalPlayer1Header, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.currTimeHeaderPlayer1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.currTimePlayer1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.forceAccruedPlayer1Header, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalForcePlayer1, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(283, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 821);
            this.tableLayoutPanel1.TabIndex = 81;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.minusIconPlayer1);
            this.flowLayoutPanel1.Controls.Add(this.forceGoalPlayer1);
            this.flowLayoutPanel1.Controls.Add(this.plusIconPlayer1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 120);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // forceGoalPlayer1
            // 
            this.forceGoalPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGoalPlayer1.AutoSize = true;
            this.forceGoalPlayer1.Location = new System.Drawing.Point(78, 0);
            this.forceGoalPlayer1.Name = "forceGoalPlayer1";
            this.forceGoalPlayer1.Size = new System.Drawing.Size(350, 120);
            this.forceGoalPlayer1.TabIndex = 62;
            this.forceGoalPlayer1.Text = "15,000";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.forceGoalHeaderPlayer2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.currTimeHeaderPlayer2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.currTimePlayer2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.forceAccruedHeaderPlayer2, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.totalForcePlayer2, 0, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1100, 174);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(856, 821);
            this.tableLayoutPanel3.TabIndex = 82;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.minusIconPlayer2);
            this.flowLayoutPanel2.Controls.Add(this.forceGoalPlayer2);
            this.flowLayoutPanel2.Controls.Add(this.plusIconPlayer2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 165);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(507, 120);
            this.flowLayoutPanel2.TabIndex = 66;
            // 
            // targeted_total_of_force_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.startButtonPlayer1);
            this.Controls.Add(this.stopButtonPlayer1);
            this.Controls.Add(this.resetButtonPlayer1);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.stopButton1);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "targeted_total_of_force_comp";
            this.Size = new System.Drawing.Size(2261, 1051);
            this.Load += new System.EventHandler(this.targeted_total_of_force_comp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private H3 player1Header;
        private H3 forceGoalPlayer1Header;
        private H3 currTimeHeaderPlayer1;
        private H3 forceAccruedPlayer1Header;
        private H3 forceGoalHeaderPlayer2;
        private H3 currTimeHeaderPlayer2;
        private H3 forceAccruedHeaderPlayer2;
        private OutlineButton startButton1;
        private OutlineButton stopButton1;
        private OutlineButton resetButton1;
        private OutlineButton resetButtonPlayer1;
        private OutlineButton stopButtonPlayer1;
        private OutlineButton startButtonPlayer1;
        private TextButton plusIconPlayer2;
        private TextButton minusIconPlayer2;
        private TextButton plusIconPlayer1;
        private TextButton minusIconPlayer1;
        private H3 label2;
        private MediumInfo currTimePlayer1;
        private MediumInfo totalForcePlayer1;
        private MediumInfo forceGoalPlayer2;
        private MediumInfo currTimePlayer2;
        private MediumInfo totalForcePlayer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MediumInfo forceGoalPlayer1;
        private H2 header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
