using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class targeted_total_of_time_comp
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
            this.startButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.resetButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.startButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.resetButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.minusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.plusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.plusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.minusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.header = new ComboCounter.Classes.H2();
            this.guest1Header = new ComboCounter.Classes.H3();
            this.guest2Header = new ComboCounter.Classes.H3();
            this.timeSetPlayer2Header = new ComboCounter.Classes.H3();
            this.timeSetPlayer1Header = new ComboCounter.Classes.H3();
            this.currTimePlayer1Header = new ComboCounter.Classes.H3();
            this.curTimePlayer2Header = new ComboCounter.Classes.H3();
            this.forceAccruedPlayer1Header = new ComboCounter.Classes.H3();
            this.forceAccruedPlayer2Header = new ComboCounter.Classes.H3();
            this.setTimePlayer1 = new ComboCounter.Classes.BigInfo();
            this.currentTimePlayer1 = new ComboCounter.Classes.BigInfo();
            this.currTimePlayer2 = new ComboCounter.Classes.BigInfo();
            this.totalForcePlayer1 = new ComboCounter.Classes.BigInfo();
            this.totalForcePlayer2 = new ComboCounter.Classes.BigInfo();
            this.setTimePlayer2 = new ComboCounter.Classes.BigInfo();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1242, 236);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(13, 805);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // startButtonPlayer1
            // 
            this.startButtonPlayer1.AutoSize = true;
            this.startButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.startButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButtonPlayer1.Location = new System.Drawing.Point(57, 446);
            this.startButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer1.Name = "startButtonPlayer1";
            this.startButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer1.Size = new System.Drawing.Size(229, 75);
            this.startButtonPlayer1.TabIndex = 40;
            this.startButtonPlayer1.Text = "Start";
            this.startButtonPlayer1.UseVisualStyleBackColor = true;
            this.startButtonPlayer1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButtonPlayer1
            // 
            this.stopButtonPlayer1.AutoSize = true;
            this.stopButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.stopButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButtonPlayer1.Location = new System.Drawing.Point(57, 609);
            this.stopButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer1.Name = "stopButtonPlayer1";
            this.stopButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer1.Size = new System.Drawing.Size(229, 75);
            this.stopButtonPlayer1.TabIndex = 41;
            this.stopButtonPlayer1.Text = "Stop";
            this.stopButtonPlayer1.UseVisualStyleBackColor = true;
            this.stopButtonPlayer1.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButtonPlayer1
            // 
            this.resetButtonPlayer1.AutoSize = true;
            this.resetButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.resetButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButtonPlayer1.Location = new System.Drawing.Point(57, 764);
            this.resetButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer1.Name = "resetButtonPlayer1";
            this.resetButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer1.Size = new System.Drawing.Size(229, 75);
            this.resetButtonPlayer1.TabIndex = 42;
            this.resetButtonPlayer1.Text = "Reset";
            this.resetButtonPlayer1.UseVisualStyleBackColor = true;
            this.resetButtonPlayer1.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButtonPlayer2
            // 
            this.startButtonPlayer2.AutoSize = true;
            this.startButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.startButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButtonPlayer2.Location = new System.Drawing.Point(2240, 446);
            this.startButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer2.Name = "startButtonPlayer2";
            this.startButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer2.Size = new System.Drawing.Size(229, 75);
            this.startButtonPlayer2.TabIndex = 43;
            this.startButtonPlayer2.Text = "Start";
            this.startButtonPlayer2.UseVisualStyleBackColor = true;
            this.startButtonPlayer2.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // stopButtonPlayer2
            // 
            this.stopButtonPlayer2.AutoSize = true;
            this.stopButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.stopButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButtonPlayer2.Location = new System.Drawing.Point(2236, 609);
            this.stopButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer2.Name = "stopButtonPlayer2";
            this.stopButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer2.Size = new System.Drawing.Size(229, 75);
            this.stopButtonPlayer2.TabIndex = 44;
            this.stopButtonPlayer2.Text = "Stop";
            this.stopButtonPlayer2.UseVisualStyleBackColor = true;
            this.stopButtonPlayer2.Click += new System.EventHandler(this.stopButton1_Click);
            // 
            // resetButtonPlayer2
            // 
            this.resetButtonPlayer2.AutoSize = true;
            this.resetButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.resetButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButtonPlayer2.Location = new System.Drawing.Point(2236, 773);
            this.resetButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer2.Name = "resetButtonPlayer2";
            this.resetButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer2.Size = new System.Drawing.Size(229, 75);
            this.resetButtonPlayer2.TabIndex = 45;
            this.resetButtonPlayer2.Text = "Reset";
            this.resetButtonPlayer2.UseVisualStyleBackColor = true;
            this.resetButtonPlayer2.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // minusIconPlayer1
            // 
            this.minusIconPlayer1.AutoSize = true;
            this.minusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer1.ForeColor = System.Drawing.Color.SteelBlue;
            this.minusIconPlayer1.Location = new System.Drawing.Point(371, 446);
            this.minusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer1.Name = "minusIconPlayer1";
            this.minusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer1.Size = new System.Drawing.Size(92, 75);
            this.minusIconPlayer1.TabIndex = 47;
            this.minusIconPlayer1.Text = "-";
            this.minusIconPlayer1.UseVisualStyleBackColor = true;
            this.minusIconPlayer1.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIconPlayer1
            // 
            this.plusIconPlayer1.AutoSize = true;
            this.plusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer1.ForeColor = System.Drawing.Color.SteelBlue;
            this.plusIconPlayer1.Location = new System.Drawing.Point(1046, 456);
            this.plusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer1.Name = "plusIconPlayer1";
            this.plusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer1.Size = new System.Drawing.Size(67, 65);
            this.plusIconPlayer1.TabIndex = 48;
            this.plusIconPlayer1.Text = "+";
            this.plusIconPlayer1.UseVisualStyleBackColor = true;
            this.plusIconPlayer1.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // plusIconPlayer2
            // 
            this.plusIconPlayer2.AutoSize = true;
            this.plusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer2.ForeColor = System.Drawing.Color.SteelBlue;
            this.plusIconPlayer2.Location = new System.Drawing.Point(2065, 456);
            this.plusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer2.Name = "plusIconPlayer2";
            this.plusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer2.Size = new System.Drawing.Size(67, 65);
            this.plusIconPlayer2.TabIndex = 50;
            this.plusIconPlayer2.Text = "+";
            this.plusIconPlayer2.UseVisualStyleBackColor = true;
            this.plusIconPlayer2.Click += new System.EventHandler(this.plusIcon1_Click);
            // 
            // minusIconPlayer2
            // 
            this.minusIconPlayer2.AutoSize = true;
            this.minusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer2.ForeColor = System.Drawing.Color.SteelBlue;
            this.minusIconPlayer2.Location = new System.Drawing.Point(1432, 456);
            this.minusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer2.Name = "minusIconPlayer2";
            this.minusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer2.Size = new System.Drawing.Size(63, 75);
            this.minusIconPlayer2.TabIndex = 49;
            this.minusIconPlayer2.Text = "-";
            this.minusIconPlayer2.UseVisualStyleBackColor = true;
            this.minusIconPlayer2.Click += new System.EventHandler(this.minusIcon1_Click);
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.ForeColor = System.Drawing.Color.SteelBlue;
            this.header.Location = new System.Drawing.Point(244, 20);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(2024, 158);
            this.header.TabIndex = 57;
            this.header.Text = "Targeted Total of Time Competition";
            // 
            // guest1Header
            // 
            this.guest1Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guest1Header.AutoSize = true;
            this.guest1Header.ForeColor = System.Drawing.Color.Gray;
            this.guest1Header.Location = new System.Drawing.Point(644, 178);
            this.guest1Header.Name = "guest1Header";
            this.guest1Header.Size = new System.Drawing.Size(232, 81);
            this.guest1Header.TabIndex = 61;
            this.guest1Header.Text = "Guest 1";
            // 
            // guest2Header
            // 
            this.guest2Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guest2Header.AutoSize = true;
            this.guest2Header.ForeColor = System.Drawing.Color.Silver;
            this.guest2Header.Location = new System.Drawing.Point(1663, 201);
            this.guest2Header.Name = "guest2Header";
            this.guest2Header.Size = new System.Drawing.Size(240, 81);
            this.guest2Header.TabIndex = 72;
            this.guest2Header.Text = "Guest 2";
            // 
            // timeSetPlayer2Header
            // 
            this.timeSetPlayer2Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSetPlayer2Header.AutoSize = true;
            this.timeSetPlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetPlayer2Header.Location = new System.Drawing.Point(1573, 301);
            this.timeSetPlayer2Header.Name = "timeSetPlayer2Header";
            this.timeSetPlayer2Header.Size = new System.Drawing.Size(397, 81);
            this.timeSetPlayer2Header.TabIndex = 73;
            this.timeSetPlayer2Header.Text = "Time Setting";
            // 
            // timeSetPlayer1Header
            // 
            this.timeSetPlayer1Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSetPlayer1Header.AutoSize = true;
            this.timeSetPlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetPlayer1Header.Location = new System.Drawing.Point(558, 273);
            this.timeSetPlayer1Header.Name = "timeSetPlayer1Header";
            this.timeSetPlayer1Header.Size = new System.Drawing.Size(397, 81);
            this.timeSetPlayer1Header.TabIndex = 74;
            this.timeSetPlayer1Header.Text = "Time Setting";
            // 
            // currTimePlayer1Header
            // 
            this.currTimePlayer1Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currTimePlayer1Header.AutoSize = true;
            this.currTimePlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimePlayer1Header.Location = new System.Drawing.Point(558, 595);
            this.currTimePlayer1Header.Name = "currTimePlayer1Header";
            this.currTimePlayer1Header.Size = new System.Drawing.Size(410, 81);
            this.currTimePlayer1Header.TabIndex = 75;
            this.currTimePlayer1Header.Text = "Current Time";
            // 
            // curTimePlayer2Header
            // 
            this.curTimePlayer2Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curTimePlayer2Header.AutoSize = true;
            this.curTimePlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.curTimePlayer2Header.Location = new System.Drawing.Point(1582, 576);
            this.curTimePlayer2Header.Name = "curTimePlayer2Header";
            this.curTimePlayer2Header.Size = new System.Drawing.Size(410, 81);
            this.curTimePlayer2Header.TabIndex = 76;
            this.curTimePlayer2Header.Text = "Current Time";
            // 
            // forceAccruedPlayer1Header
            // 
            this.forceAccruedPlayer1Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceAccruedPlayer1Header.AutoSize = true;
            this.forceAccruedPlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedPlayer1Header.Location = new System.Drawing.Point(528, 902);
            this.forceAccruedPlayer1Header.Name = "forceAccruedPlayer1Header";
            this.forceAccruedPlayer1Header.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedPlayer1Header.TabIndex = 77;
            this.forceAccruedPlayer1Header.Text = "Force Accrued";
            // 
            // forceAccruedPlayer2Header
            // 
            this.forceAccruedPlayer2Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceAccruedPlayer2Header.AutoSize = true;
            this.forceAccruedPlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedPlayer2Header.Location = new System.Drawing.Point(1573, 863);
            this.forceAccruedPlayer2Header.Name = "forceAccruedPlayer2Header";
            this.forceAccruedPlayer2Header.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedPlayer2Header.TabIndex = 78;
            this.forceAccruedPlayer2Header.Text = "Force Accrued";
            // 
            // setTimePlayer1
            // 
            this.setTimePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimePlayer1.AutoSize = true;
            this.setTimePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.setTimePlayer1.Location = new System.Drawing.Point(470, 354);
            this.setTimePlayer1.Name = "setTimePlayer1";
            this.setTimePlayer1.Size = new System.Drawing.Size(596, 240);
            this.setTimePlayer1.TabIndex = 79;
            this.setTimePlayer1.Text = "00:30";

            // 
            // currentTimePlayer1
            // 
            this.currentTimePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimePlayer1.AutoSize = true;
            this.currentTimePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.currentTimePlayer1.Location = new System.Drawing.Point(382, 684);
            this.currentTimePlayer1.Name = "currentTimePlayer1";
            this.currentTimePlayer1.Size = new System.Drawing.Size(761, 240);
            this.currentTimePlayer1.TabIndex = 85;
            this.currentTimePlayer1.Text = "00:00.0";
            // 
            // currTimePlayer2
            // 
            this.currTimePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currTimePlayer2.AutoSize = true;
            this.currTimePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.currTimePlayer2.Location = new System.Drawing.Point(1392, 632);
            this.currTimePlayer2.Name = "currTimePlayer2";
            this.currTimePlayer2.Size = new System.Drawing.Size(761, 240);
            this.currTimePlayer2.TabIndex = 86;
            this.currTimePlayer2.Text = "00:00.0";
            // 
            // totalForcePlayer1
            // 
            this.totalForcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForcePlayer1.AutoSize = true;
            this.totalForcePlayer1.ForeColor = System.Drawing.Color.DarkRed;
            this.totalForcePlayer1.Location = new System.Drawing.Point(645, 947);
            this.totalForcePlayer1.Name = "totalForcePlayer1";
            this.totalForcePlayer1.Size = new System.Drawing.Size(212, 240);
            this.totalForcePlayer1.TabIndex = 87;
            this.totalForcePlayer1.Text = "0";
            // 
            // totalForcePlayer2
            // 
            this.totalForcePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForcePlayer2.AutoSize = true;
            this.totalForcePlayer2.ForeColor = System.Drawing.Color.DarkRed;
            this.totalForcePlayer2.Location = new System.Drawing.Point(1681, 925);
            this.totalForcePlayer2.Name = "totalForcePlayer2";
            this.totalForcePlayer2.Size = new System.Drawing.Size(212, 240);
            this.totalForcePlayer2.TabIndex = 88;
            this.totalForcePlayer2.Text = "0";
            // 
            // setTimePlayer2
            // 
            this.setTimePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimePlayer2.AutoSize = true;
            this.setTimePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.setTimePlayer2.Location = new System.Drawing.Point(1478, 373);
            this.setTimePlayer2.Name = "setTimePlayer2";
            this.setTimePlayer2.Size = new System.Drawing.Size(596, 240);
            this.setTimePlayer2.TabIndex = 89;
            this.setTimePlayer2.Text = "00:30";
            // 
            // targeted_total_of_time_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.forceAccruedPlayer1Header);
            this.Controls.Add(this.curTimePlayer2Header);
            this.Controls.Add(this.totalForcePlayer2);
            this.Controls.Add(this.totalForcePlayer1);
            this.Controls.Add(this.currTimePlayer2);
            this.Controls.Add(this.forceAccruedPlayer2Header);
            this.Controls.Add(this.currTimePlayer1Header);
            this.Controls.Add(this.timeSetPlayer1Header);
            this.Controls.Add(this.timeSetPlayer2Header);
            this.Controls.Add(this.guest2Header);
            this.Controls.Add(this.guest1Header);
            this.Controls.Add(this.header);
            this.Controls.Add(this.plusIconPlayer2);
            this.Controls.Add(this.minusIconPlayer2);
            this.Controls.Add(this.plusIconPlayer1);
            this.Controls.Add(this.minusIconPlayer1);
            this.Controls.Add(this.resetButtonPlayer2);
            this.Controls.Add(this.stopButtonPlayer2);
            this.Controls.Add(this.startButtonPlayer2);
            this.Controls.Add(this.resetButtonPlayer1);
            this.Controls.Add(this.stopButtonPlayer1);
            this.Controls.Add(this.startButtonPlayer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.setTimePlayer2);
            this.Controls.Add(this.setTimePlayer1);
            this.Controls.Add(this.currentTimePlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "targeted_total_of_time_comp";
            this.Size = new System.Drawing.Size(2469, 1165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private OutlineButton startButtonPlayer1;
        private OutlineButton stopButtonPlayer1;
        private OutlineButton resetButtonPlayer1;
        private OutlineButton startButtonPlayer2;
        private OutlineButton stopButtonPlayer2;
        private OutlineButton resetButtonPlayer2;
        private TextButton minusIconPlayer1;
        private TextButton plusIconPlayer1;
        private TextButton plusIconPlayer2;
        private TextButton minusIconPlayer2;
        private H2 header;
        private H3 guest1Header;
        private H3 guest2Header;
        private H3 timeSetPlayer2Header;
        private H3 timeSetPlayer1Header;
        private H3 currTimePlayer1Header;
        private H3 curTimePlayer2Header;
        private H3 forceAccruedPlayer1Header;
        private H3 forceAccruedPlayer2Header;
        private BigInfo setTimePlayer1;
        private BigInfo currentTimePlayer1;
        private BigInfo currTimePlayer2;
        private BigInfo totalForcePlayer1;
        private BigInfo totalForcePlayer2;
        private BigInfo setTimePlayer2;
    }
}
