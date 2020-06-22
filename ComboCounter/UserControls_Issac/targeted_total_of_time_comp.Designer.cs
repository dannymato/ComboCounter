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
            this.plusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.minusIconPlayer2 = new ComboCounter.CustomControls.TextButton();
            this.header = new ComboCounter.Classes.H2();
            this.guest2Header = new ComboCounter.Classes.H3();
            this.timeSetPlayer2Header = new ComboCounter.Classes.H3();
            this.curTimePlayer2Header = new ComboCounter.Classes.H3();
            this.forceAccruedPlayer2Header = new ComboCounter.Classes.H3();
            this.currTimePlayer2 = new ComboCounter.Classes.BigInfo();
            this.totalForcePlayer2 = new ComboCounter.Classes.BigInfo();
            this.setTimePlayer2 = new ComboCounter.Classes.MediumInfo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.forceAccruedPlayer1Header = new ComboCounter.Classes.H3();
            this.guest1Header = new ComboCounter.Classes.H3();
            this.totalForcePlayer1 = new ComboCounter.Classes.BigInfo();
            this.timeSetPlayer1Header = new ComboCounter.Classes.H3();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.minusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.setTimePlayer1 = new ComboCounter.Classes.MediumInfo();
            this.plusIconPlayer1 = new ComboCounter.CustomControls.TextButton();
            this.currTimePlayer1Header = new ComboCounter.Classes.H3();
            this.currentTimePlayer1 = new ComboCounter.Classes.BigInfo();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.startButtonPlayer1.Location = new System.Drawing.Point(4, 4);
            this.startButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer1.Name = "startButtonPlayer1";
            this.startButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer1.Size = new System.Drawing.Size(229, 74);
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
            this.stopButtonPlayer1.Location = new System.Drawing.Point(4, 168);
            this.stopButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer1.Name = "stopButtonPlayer1";
            this.stopButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer1.Size = new System.Drawing.Size(229, 74);
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
            this.resetButtonPlayer1.Location = new System.Drawing.Point(4, 332);
            this.resetButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer1.Name = "resetButtonPlayer1";
            this.resetButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer1.Size = new System.Drawing.Size(229, 74);
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
            this.startButtonPlayer2.Location = new System.Drawing.Point(4, 4);
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
            this.stopButtonPlayer2.Location = new System.Drawing.Point(4, 170);
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
            this.resetButtonPlayer2.Location = new System.Drawing.Point(4, 336);
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
            // plusIconPlayer2
            // 
            this.plusIconPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIconPlayer2.AutoSize = true;
            this.plusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer2.ForeColor = System.Drawing.Color.SteelBlue;
            this.plusIconPlayer2.Location = new System.Drawing.Point(391, 22);
            this.plusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer2.Name = "plusIconPlayer2";
            this.plusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer2.Size = new System.Drawing.Size(75, 75);
            this.plusIconPlayer2.TabIndex = 50;
            this.plusIconPlayer2.Text = "+";
            this.plusIconPlayer2.UseVisualStyleBackColor = true;
            this.plusIconPlayer2.Click += new System.EventHandler(this.plusIcon1_Click);
            // 
            // minusIconPlayer2
            // 
            this.minusIconPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIconPlayer2.AutoSize = true;
            this.minusIconPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer2.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer2.ForeColor = System.Drawing.Color.SteelBlue;
            this.minusIconPlayer2.Location = new System.Drawing.Point(4, 22);
            this.minusIconPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer2.Name = "minusIconPlayer2";
            this.minusIconPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer2.Size = new System.Drawing.Size(75, 75);
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
            this.header.Location = new System.Drawing.Point(244, 11);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(2024, 158);
            this.header.TabIndex = 57;
            this.header.Text = "Targeted Total of Time Competition";
            // 
            // guest2Header
            // 
            this.guest2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guest2Header.AutoSize = true;
            this.guest2Header.ForeColor = System.Drawing.Color.Silver;
            this.guest2Header.Location = new System.Drawing.Point(358, 0);
            this.guest2Header.Name = "guest2Header";
            this.guest2Header.Size = new System.Drawing.Size(240, 81);
            this.guest2Header.TabIndex = 72;
            this.guest2Header.Text = "Guest 2";
            // 
            // timeSetPlayer2Header
            // 
            this.timeSetPlayer2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSetPlayer2Header.AutoSize = true;
            this.timeSetPlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetPlayer2Header.Location = new System.Drawing.Point(279, 81);
            this.timeSetPlayer2Header.Name = "timeSetPlayer2Header";
            this.timeSetPlayer2Header.Size = new System.Drawing.Size(397, 81);
            this.timeSetPlayer2Header.TabIndex = 73;
            this.timeSetPlayer2Header.Text = "Time Setting";
            // 
            // curTimePlayer2Header
            // 
            this.curTimePlayer2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.curTimePlayer2Header.AutoSize = true;
            this.curTimePlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.curTimePlayer2Header.Location = new System.Drawing.Point(273, 288);
            this.curTimePlayer2Header.Name = "curTimePlayer2Header";
            this.curTimePlayer2Header.Size = new System.Drawing.Size(410, 81);
            this.curTimePlayer2Header.TabIndex = 76;
            this.curTimePlayer2Header.Text = "Current Time";
            // 
            // forceAccruedPlayer2Header
            // 
            this.forceAccruedPlayer2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedPlayer2Header.AutoSize = true;
            this.forceAccruedPlayer2Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedPlayer2Header.Location = new System.Drawing.Point(258, 609);
            this.forceAccruedPlayer2Header.Name = "forceAccruedPlayer2Header";
            this.forceAccruedPlayer2Header.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedPlayer2Header.TabIndex = 78;
            this.forceAccruedPlayer2Header.Text = "Force Accrued";
            // 
            // currTimePlayer2
            // 
            this.currTimePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimePlayer2.AutoSize = true;
            this.currTimePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.currTimePlayer2.Location = new System.Drawing.Point(97, 369);
            this.currTimePlayer2.Name = "currTimePlayer2";
            this.currTimePlayer2.Size = new System.Drawing.Size(761, 240);
            this.currTimePlayer2.TabIndex = 86;
            this.currTimePlayer2.Text = "00:00.0";
            // 
            // totalForcePlayer2
            // 
            this.totalForcePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer2.AutoSize = true;
            this.totalForcePlayer2.ForeColor = System.Drawing.Color.DarkRed;
            this.totalForcePlayer2.Location = new System.Drawing.Point(372, 702);
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
            this.setTimePlayer2.Location = new System.Drawing.Point(86, 0);
            this.setTimePlayer2.Name = "setTimePlayer2";
            this.setTimePlayer2.Size = new System.Drawing.Size(298, 120);
            this.setTimePlayer2.TabIndex = 89;
            this.setTimePlayer2.Text = "00:30";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.forceAccruedPlayer1Header, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.guest1Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalForcePlayer1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.timeSetPlayer1Header, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.currTimePlayer1Header, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.currentTimePlayer1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(243, 169);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 954);
            this.tableLayoutPanel1.TabIndex = 90;
            // 
            // forceAccruedPlayer1Header
            // 
            this.forceAccruedPlayer1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forceAccruedPlayer1Header.AutoSize = true;
            this.forceAccruedPlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedPlayer1Header.Location = new System.Drawing.Point(276, 609);
            this.forceAccruedPlayer1Header.Name = "forceAccruedPlayer1Header";
            this.forceAccruedPlayer1Header.Size = new System.Drawing.Size(440, 81);
            this.forceAccruedPlayer1Header.TabIndex = 77;
            this.forceAccruedPlayer1Header.Text = "Force Accrued";
            // 
            // guest1Header
            // 
            this.guest1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guest1Header.AutoSize = true;
            this.guest1Header.ForeColor = System.Drawing.Color.Gray;
            this.guest1Header.Location = new System.Drawing.Point(380, 0);
            this.guest1Header.Name = "guest1Header";
            this.guest1Header.Size = new System.Drawing.Size(232, 81);
            this.guest1Header.TabIndex = 61;
            this.guest1Header.Text = "Guest 1";
            // 
            // totalForcePlayer1
            // 
            this.totalForcePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer1.AutoSize = true;
            this.totalForcePlayer1.ForeColor = System.Drawing.Color.DarkRed;
            this.totalForcePlayer1.Location = new System.Drawing.Point(390, 702);
            this.totalForcePlayer1.Name = "totalForcePlayer1";
            this.totalForcePlayer1.Size = new System.Drawing.Size(212, 240);
            this.totalForcePlayer1.TabIndex = 87;
            this.totalForcePlayer1.Text = "0";
            // 
            // timeSetPlayer1Header
            // 
            this.timeSetPlayer1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSetPlayer1Header.AutoSize = true;
            this.timeSetPlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetPlayer1Header.Location = new System.Drawing.Point(297, 81);
            this.timeSetPlayer1Header.Name = "timeSetPlayer1Header";
            this.timeSetPlayer1Header.Size = new System.Drawing.Size(397, 81);
            this.timeSetPlayer1Header.TabIndex = 74;
            this.timeSetPlayer1Header.Text = "Time Setting";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.minusIconPlayer1);
            this.flowLayoutPanel1.Controls.Add(this.setTimePlayer1);
            this.flowLayoutPanel1.Controls.Add(this.plusIconPlayer1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 120);
            this.flowLayoutPanel1.TabIndex = 75;
            // 
            // minusIconPlayer1
            // 
            this.minusIconPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIconPlayer1.AutoSize = true;
            this.minusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.minusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.minusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusIconPlayer1.ForeColor = System.Drawing.Color.SteelBlue;
            this.minusIconPlayer1.Location = new System.Drawing.Point(4, 22);
            this.minusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.minusIconPlayer1.Name = "minusIconPlayer1";
            this.minusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIconPlayer1.Size = new System.Drawing.Size(75, 75);
            this.minusIconPlayer1.TabIndex = 47;
            this.minusIconPlayer1.Text = "-";
            this.minusIconPlayer1.UseVisualStyleBackColor = true;
            this.minusIconPlayer1.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // setTimePlayer1
            // 
            this.setTimePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setTimePlayer1.AutoSize = true;
            this.setTimePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.setTimePlayer1.Location = new System.Drawing.Point(86, 0);
            this.setTimePlayer1.Name = "setTimePlayer1";
            this.setTimePlayer1.Size = new System.Drawing.Size(298, 120);
            this.setTimePlayer1.TabIndex = 79;
            this.setTimePlayer1.Text = "00:30";
            // 
            // plusIconPlayer1
            // 
            this.plusIconPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIconPlayer1.AutoSize = true;
            this.plusIconPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.plusIconPlayer1.FlatAppearance.BorderSize = 0;
            this.plusIconPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIconPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusIconPlayer1.ForeColor = System.Drawing.Color.SteelBlue;
            this.plusIconPlayer1.Location = new System.Drawing.Point(391, 22);
            this.plusIconPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.plusIconPlayer1.Name = "plusIconPlayer1";
            this.plusIconPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIconPlayer1.Size = new System.Drawing.Size(75, 75);
            this.plusIconPlayer1.TabIndex = 48;
            this.plusIconPlayer1.Text = "+";
            this.plusIconPlayer1.UseVisualStyleBackColor = true;
            this.plusIconPlayer1.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // currTimePlayer1Header
            // 
            this.currTimePlayer1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimePlayer1Header.AutoSize = true;
            this.currTimePlayer1Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimePlayer1Header.Location = new System.Drawing.Point(291, 288);
            this.currTimePlayer1Header.Name = "currTimePlayer1Header";
            this.currTimePlayer1Header.Size = new System.Drawing.Size(410, 81);
            this.currTimePlayer1Header.TabIndex = 75;
            this.currTimePlayer1Header.Text = "Current Time";
            // 
            // currentTimePlayer1
            // 
            this.currentTimePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTimePlayer1.AutoSize = true;
            this.currentTimePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.currentTimePlayer1.Location = new System.Drawing.Point(115, 369);
            this.currentTimePlayer1.Name = "currentTimePlayer1";
            this.currentTimePlayer1.Size = new System.Drawing.Size(761, 240);
            this.currentTimePlayer1.TabIndex = 85;
            this.currentTimePlayer1.Text = "00:00.0";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-19, -19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 91;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.startButtonPlayer1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.stopButtonPlayer1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.resetButtonPlayer1, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 457);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(237, 410);
            this.tableLayoutPanel3.TabIndex = 92;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.guest2Header, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.timeSetPlayer2Header, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.totalForcePlayer2, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.curTimePlayer2Header, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.forceAccruedPlayer2Header, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.currTimePlayer2, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1262, 169);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(956, 954);
            this.tableLayoutPanel4.TabIndex = 93;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.minusIconPlayer2);
            this.flowLayoutPanel3.Controls.Add(this.setTimePlayer2);
            this.flowLayoutPanel3.Controls.Add(this.plusIconPlayer2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(243, 165);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(470, 120);
            this.flowLayoutPanel3.TabIndex = 74;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.stopButtonPlayer2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.resetButtonPlayer2, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.startButtonPlayer2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2232, 462);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(237, 415);
            this.tableLayoutPanel5.TabIndex = 94;
            // 
            // targeted_total_of_time_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "targeted_total_of_time_comp";
            this.Size = new System.Drawing.Size(2469, 1165);
            this.Load += new System.EventHandler(this.targeted_total_of_time_comp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private TextButton plusIconPlayer2;
        private TextButton minusIconPlayer2;
        private H2 header;
        private H3 guest2Header;
        private H3 timeSetPlayer2Header;
        private H3 curTimePlayer2Header;
        private H3 forceAccruedPlayer2Header;
        private BigInfo currTimePlayer2;
        private BigInfo totalForcePlayer2;
        private MediumInfo setTimePlayer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private H3 forceAccruedPlayer1Header;
        private H3 guest1Header;
        private BigInfo totalForcePlayer1;
        private H3 timeSetPlayer1Header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TextButton minusIconPlayer1;
        private MediumInfo setTimePlayer1;
        private TextButton plusIconPlayer1;
        private H3 currTimePlayer1Header;
        private BigInfo currentTimePlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
