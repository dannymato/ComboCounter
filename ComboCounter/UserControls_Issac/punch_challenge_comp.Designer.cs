using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class punch_challenge_comp
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.player1TotalPunchHead = new ComboCounter.Classes.H3();
            this.totalForcePlayer2 = new ComboCounter.Classes.BigInfo();
            this.totalForcePlayer1 = new ComboCounter.Classes.BigInfo();
            this.totalPunchPlay2 = new ComboCounter.Classes.BigInfo();
            this.punchNumPlay1 = new ComboCounter.Classes.BigInfo();
            this.totalForcePlay2Head = new ComboCounter.Classes.H3();
            this.totalForcePlay1Head = new ComboCounter.Classes.H3();
            this.totalPunchPlayer2Header = new ComboCounter.Classes.H3();
            this.player2Header = new ComboCounter.Classes.H3();
            this.player1Header = new ComboCounter.Classes.H3();
            this.header = new ComboCounter.Classes.Header1();
            this.resetButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.resetButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.stopButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.startButtonPlayer2 = new ComboCounter.CustomControls.OutlineButton();
            this.minusIcon = new ComboCounter.CustomControls.TextButton();
            this.startButtonPlayer1 = new ComboCounter.CustomControls.OutlineButton();
            this.plusIcon = new ComboCounter.CustomControls.TextButton();
            this.limit = new ComboCounter.Classes.BigInfo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GoalPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GoalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1248, 421);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(15, 688);
            this.tableLayoutPanel2.TabIndex = 73;
            // 
            // player1TotalPunchHead
            // 
            this.player1TotalPunchHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1TotalPunchHead.AutoSize = true;
            this.player1TotalPunchHead.Location = new System.Drawing.Point(259, 81);
            this.player1TotalPunchHead.Name = "player1TotalPunchHead";
            this.player1TotalPunchHead.Size = new System.Drawing.Size(438, 81);
            this.player1TotalPunchHead.TabIndex = 83;
            this.player1TotalPunchHead.Text = "Total Punches";
            // 
            // totalForcePlayer2
            // 
            this.totalForcePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer2.AutoSize = true;
            this.totalForcePlayer2.Location = new System.Drawing.Point(325, 518);
            this.totalForcePlayer2.Name = "totalForcePlayer2";
            this.totalForcePlayer2.Size = new System.Drawing.Size(212, 240);
            this.totalForcePlayer2.TabIndex = 82;
            this.totalForcePlayer2.Text = "0";
            // 
            // totalForcePlayer1
            // 
            this.totalForcePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlayer1.AutoSize = true;
            this.totalForcePlayer1.Location = new System.Drawing.Point(372, 517);
            this.totalForcePlayer1.Name = "totalForcePlayer1";
            this.totalForcePlayer1.Size = new System.Drawing.Size(212, 240);
            this.totalForcePlayer1.TabIndex = 81;
            this.totalForcePlayer1.Text = "0";
            // 
            // totalPunchPlay2
            // 
            this.totalPunchPlay2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPunchPlay2.AutoSize = true;
            this.totalPunchPlay2.Location = new System.Drawing.Point(325, 162);
            this.totalPunchPlay2.Name = "totalPunchPlay2";
            this.totalPunchPlay2.Size = new System.Drawing.Size(212, 240);
            this.totalPunchPlay2.TabIndex = 80;
            this.totalPunchPlay2.Text = "0";
            // 
            // punchNumPlay1
            // 
            this.punchNumPlay1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.punchNumPlay1.AutoSize = true;
            this.punchNumPlay1.BackColor = System.Drawing.Color.Transparent;
            this.punchNumPlay1.Location = new System.Drawing.Point(372, 162);
            this.punchNumPlay1.Name = "punchNumPlay1";
            this.punchNumPlay1.Size = new System.Drawing.Size(212, 240);
            this.punchNumPlay1.TabIndex = 79;
            this.punchNumPlay1.Text = "0";
            // 
            // totalForcePlay2Head
            // 
            this.totalForcePlay2Head.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlay2Head.AutoSize = true;
            this.totalForcePlay2Head.Location = new System.Drawing.Point(257, 402);
            this.totalForcePlay2Head.Name = "totalForcePlay2Head";
            this.totalForcePlay2Head.Size = new System.Drawing.Size(348, 81);
            this.totalForcePlay2Head.TabIndex = 78;
            this.totalForcePlay2Head.Text = "Total Force";
            // 
            // totalForcePlay1Head
            // 
            this.totalForcePlay1Head.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalForcePlay1Head.AutoSize = true;
            this.totalForcePlay1Head.Location = new System.Drawing.Point(304, 402);
            this.totalForcePlay1Head.Name = "totalForcePlay1Head";
            this.totalForcePlay1Head.Size = new System.Drawing.Size(348, 81);
            this.totalForcePlay1Head.TabIndex = 77;
            this.totalForcePlay1Head.Text = "Total Force";
            // 
            // totalPunchPlayer2Header
            // 
            this.totalPunchPlayer2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPunchPlayer2Header.AutoSize = true;
            this.totalPunchPlayer2Header.Location = new System.Drawing.Point(212, 81);
            this.totalPunchPlayer2Header.Name = "totalPunchPlayer2Header";
            this.totalPunchPlayer2Header.Size = new System.Drawing.Size(438, 81);
            this.totalPunchPlayer2Header.TabIndex = 76;
            this.totalPunchPlayer2Header.Text = "Total Punches";
            // 
            // player2Header
            // 
            this.player2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2Header.AutoSize = true;
            this.player2Header.Location = new System.Drawing.Point(311, 0);
            this.player2Header.Name = "player2Header";
            this.player2Header.Size = new System.Drawing.Size(240, 81);
            this.player2Header.TabIndex = 72;
            this.player2Header.Text = "Guest 2";
            // 
            // player1Header
            // 
            this.player1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1Header.AutoSize = true;
            this.player1Header.Location = new System.Drawing.Point(362, 0);
            this.player1Header.Name = "player1Header";
            this.player1Header.Size = new System.Drawing.Size(232, 81);
            this.player1Header.TabIndex = 71;
            this.player1Header.Text = "Guest 1";
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(217, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1961, 180);
            this.header.TabIndex = 57;
            this.header.Text = "Punch Challenge Competition";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButtonPlayer2
            // 
            this.resetButtonPlayer2.AutoSize = true;
            this.resetButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.resetButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButtonPlayer2.Location = new System.Drawing.Point(2140, 905);
            this.resetButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer2.Name = "resetButtonPlayer2";
            this.resetButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer2.Size = new System.Drawing.Size(217, 75);
            this.resetButtonPlayer2.TabIndex = 56;
            this.resetButtonPlayer2.Text = "Reset";
            this.resetButtonPlayer2.UseVisualStyleBackColor = true;
            this.resetButtonPlayer2.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // stopButtonPlayer2
            // 
            this.stopButtonPlayer2.AutoSize = true;
            this.stopButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.stopButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButtonPlayer2.Location = new System.Drawing.Point(2140, 727);
            this.stopButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer2.Name = "stopButtonPlayer2";
            this.stopButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer2.Size = new System.Drawing.Size(217, 75);
            this.stopButtonPlayer2.TabIndex = 55;
            this.stopButtonPlayer2.Text = "Stop";
            this.stopButtonPlayer2.UseVisualStyleBackColor = true;
            this.stopButtonPlayer2.Click += new System.EventHandler(this.stopButton1_Click);
            // 
            // resetButtonPlayer1
            // 
            this.resetButtonPlayer1.AutoSize = true;
            this.resetButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.resetButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButtonPlayer1.Location = new System.Drawing.Point(69, 905);
            this.resetButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.resetButtonPlayer1.Name = "resetButtonPlayer1";
            this.resetButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButtonPlayer1.Size = new System.Drawing.Size(208, 75);
            this.resetButtonPlayer1.TabIndex = 54;
            this.resetButtonPlayer1.Text = "Reset";
            this.resetButtonPlayer1.UseVisualStyleBackColor = true;
            this.resetButtonPlayer1.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButtonPlayer1
            // 
            this.stopButtonPlayer1.AutoSize = true;
            this.stopButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.stopButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButtonPlayer1.Location = new System.Drawing.Point(69, 727);
            this.stopButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.stopButtonPlayer1.Name = "stopButtonPlayer1";
            this.stopButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButtonPlayer1.Size = new System.Drawing.Size(208, 75);
            this.stopButtonPlayer1.TabIndex = 53;
            this.stopButtonPlayer1.Text = "Stop";
            this.stopButtonPlayer1.UseVisualStyleBackColor = true;
            this.stopButtonPlayer1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // startButtonPlayer2
            // 
            this.startButtonPlayer2.AutoSize = true;
            this.startButtonPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.startButtonPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButtonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtonPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButtonPlayer2.Location = new System.Drawing.Point(2140, 548);
            this.startButtonPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer2.Name = "startButtonPlayer2";
            this.startButtonPlayer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer2.Size = new System.Drawing.Size(217, 75);
            this.startButtonPlayer2.TabIndex = 52;
            this.startButtonPlayer2.Text = "Start";
            this.startButtonPlayer2.UseVisualStyleBackColor = true;
            this.startButtonPlayer2.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIcon.AutoSize = true;
            this.minusIcon.BackColor = System.Drawing.Color.Transparent;
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(4, 82);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIcon.Size = new System.Drawing.Size(96, 75);
            this.minusIcon.TabIndex = 50;
            this.minusIcon.Text = "-";
            this.minusIcon.UseVisualStyleBackColor = false;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // startButtonPlayer1
            // 
            this.startButtonPlayer1.AutoSize = true;
            this.startButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.startButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtonPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButtonPlayer1.Location = new System.Drawing.Point(69, 548);
            this.startButtonPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.startButtonPlayer1.Name = "startButtonPlayer1";
            this.startButtonPlayer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButtonPlayer1.Size = new System.Drawing.Size(208, 75);
            this.startButtonPlayer1.TabIndex = 51;
            this.startButtonPlayer1.Text = "Start";
            this.startButtonPlayer1.UseVisualStyleBackColor = false;
            this.startButtonPlayer1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIcon.AutoSize = true;
            this.plusIcon.BackColor = System.Drawing.Color.Transparent;
            this.plusIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(438, 87);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIcon.Size = new System.Drawing.Size(67, 66);
            this.plusIcon.TabIndex = 44;
            this.plusIcon.Text = "+";
            this.plusIcon.UseVisualStyleBackColor = false;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // limit
            // 
            this.limit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limit.AutoSize = true;
            this.limit.ForeColor = System.Drawing.Color.DarkRed;
            this.limit.Location = new System.Drawing.Point(107, 0);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(324, 240);
            this.limit.TabIndex = 74;
            this.limit.Text = "20";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.player1TotalPunchHead, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalForcePlayer1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.player1Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.punchNumPlay1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.totalForcePlay1Head, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(284, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 792);
            this.tableLayoutPanel1.TabIndex = 84;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.totalForcePlayer2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.player2Header, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.totalForcePlay2Head, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.totalPunchPlay2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.totalPunchPlayer2Header, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1270, 317);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(863, 793);
            this.tableLayoutPanel3.TabIndex = 85;
            // 
            // GoalPanel
            // 
            this.GoalPanel.AutoSize = true;
            this.GoalPanel.Controls.Add(this.minusIcon);
            this.GoalPanel.Controls.Add(this.limit);
            this.GoalPanel.Controls.Add(this.plusIcon);
            this.GoalPanel.Location = new System.Drawing.Point(999, 183);
            this.GoalPanel.Name = "GoalPanel";
            this.GoalPanel.Size = new System.Drawing.Size(509, 240);
            this.GoalPanel.TabIndex = 86;
            // 
            // punch_challenge_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.resetButtonPlayer2);
            this.Controls.Add(this.stopButtonPlayer2);
            this.Controls.Add(this.resetButtonPlayer1);
            this.Controls.Add(this.stopButtonPlayer1);
            this.Controls.Add(this.startButtonPlayer2);
            this.Controls.Add(this.startButtonPlayer1);
            this.Controls.Add(this.GoalPanel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "punch_challenge_comp";
            this.Size = new System.Drawing.Size(2475, 1113);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.GoalPanel.ResumeLayout(false);
            this.GoalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TextButton plusIcon;
        private OutlineButton startButtonPlayer1;
        private TextButton minusIcon;
        private OutlineButton startButtonPlayer2;
        private OutlineButton stopButtonPlayer1;
        private OutlineButton resetButtonPlayer1;
        private OutlineButton stopButtonPlayer2;
        private OutlineButton resetButtonPlayer2;
        private Header1 header;
        private H3 player1Header;
        private H3 player2Header;
        private BigInfo limit;
        private H3 totalPunchPlayer2Header;
        private H3 totalForcePlay1Head;
        private H3 totalForcePlay2Head;
        private BigInfo punchNumPlay1;
        private BigInfo totalPunchPlay2;
        private BigInfo totalForcePlayer1;
        private BigInfo totalForcePlayer2;
        private H3 player1TotalPunchHead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel GoalPanel;
    }
}
