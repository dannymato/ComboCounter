using ComboCounter.Classes;
using ComboCounter.CustomControls;
using System.Windows.Forms;

namespace ComboCounter.UserControls
{
    partial class punch_count_comp
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
            this.p1ValidPunch = new ComboCounter.Classes.MediumInfo();
            this.p1CurrTime = new ComboCounter.Classes.MediumInfo();
            this.p1LastHit = new ComboCounter.Classes.MediumInfo();
            this.p1Threshold = new ComboCounter.Classes.MediumInfo();
            this.setTimeP1 = new ComboCounter.Classes.MediumInfo();
            this.p2ValidPunch = new ComboCounter.Classes.MediumInfo();
            this.p2LastHit = new ComboCounter.Classes.MediumInfo();
            this.p2Threshold = new ComboCounter.Classes.MediumInfo();
            this.p2CurrTime = new ComboCounter.Classes.MediumInfo();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.p1StartButton = new ComboCounter.CustomControls.OutlineButton();
            this.p1StopButton = new ComboCounter.CustomControls.OutlineButton();
            this.p1ResetButton = new ComboCounter.CustomControls.OutlineButton();
            this.p2StartButton = new ComboCounter.CustomControls.OutlineButton();
            this.p2StopButton = new ComboCounter.CustomControls.OutlineButton();
            this.p2ResetButton = new ComboCounter.CustomControls.OutlineButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.p1PlusIcon = new ComboCounter.CustomControls.TextButton();
            this.p1MinusIcon = new ComboCounter.CustomControls.TextButton();
            this.p2MinusIcon = new ComboCounter.CustomControls.TextButton();
            this.p2PlusIcon = new ComboCounter.CustomControls.TextButton();
            this.p2SetTime = new ComboCounter.Classes.MediumInfo();
            this.header = new ComboCounter.Classes.H2();
            this.player1Header = new ComboCounter.Classes.H3();
            this.p1ValidPunchesHeader = new ComboCounter.Classes.H4();
            this.p1InvalidPunchHeader = new ComboCounter.Classes.H4();
            this.p1TimeSetHeader = new ComboCounter.Classes.H3();
            this.p1InvalidPunch = new ComboCounter.Classes.MediumInfo();
            this.p1ThresholdHeader = new ComboCounter.Classes.H3();
            this.p1LastHitHeader = new ComboCounter.Classes.H3();
            this.p1CurrTimeHeader = new ComboCounter.Classes.H3();
            this.p2CurrTimeHeader = new ComboCounter.Classes.H3();
            this.label9 = new System.Windows.Forms.Label();
            this.p1CenterHeader = new ComboCounter.Classes.H3();
            this.p2CenterHeader = new ComboCounter.Classes.H3();
            this.p2Header = new ComboCounter.Classes.H3();
            this.p2ValidPunchHeader = new ComboCounter.Classes.H4();
            this.p2InvalidPunchHeader = new ComboCounter.Classes.H4();
            this.p2TimeSetHeader = new ComboCounter.Classes.H3();
            this.p2ThresholdHeader = new ComboCounter.Classes.H3();
            this.p2LastHitHeader = new ComboCounter.Classes.H3();
            this.p2InvalidPunch = new ComboCounter.Classes.MediumInfo();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1ValidPunch
            // 
            this.p1ValidPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1ValidPunch.AutoSize = true;
            this.p1ValidPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p1ValidPunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p1ValidPunch.Location = new System.Drawing.Point(520, 56);
            this.p1ValidPunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1ValidPunch.Name = "p1ValidPunch";
            this.p1ValidPunch.Size = new System.Drawing.Size(106, 120);
            this.p1ValidPunch.TabIndex = 24;
            this.p1ValidPunch.Text = "0";
            this.p1ValidPunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1CurrTime
            // 
            this.p1CurrTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1CurrTime.AutoSize = true;
            this.p1CurrTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p1CurrTime.ForeColor = System.Drawing.Color.DimGray;
            this.p1CurrTime.Location = new System.Drawing.Point(113, 270);
            this.p1CurrTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1CurrTime.Name = "p1CurrTime";
            this.p1CurrTime.Size = new System.Drawing.Size(436, 120);
            this.p1CurrTime.TabIndex = 23;
            this.p1CurrTime.Text = "00:00.00";
            this.p1CurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1CurrTime.TextChanged += new System.EventHandler(this.currentTime_TextChanged);
            // 
            // p1LastHit
            // 
            this.p1LastHit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1LastHit.AutoSize = true;
            this.p1LastHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p1LastHit.ForeColor = System.Drawing.Color.DimGray;
            this.p1LastHit.Location = new System.Drawing.Point(332, 789);
            this.p1LastHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1LastHit.Name = "p1LastHit";
            this.p1LastHit.Size = new System.Drawing.Size(106, 120);
            this.p1LastHit.TabIndex = 21;
            this.p1LastHit.Text = "0";
            this.p1LastHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1LastHit.TextChanged += new System.EventHandler(this.lastHit_TextChanged_1);
            // 
            // p1Threshold
            // 
            this.p1Threshold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1Threshold.AutoSize = true;
            this.p1Threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p1Threshold.ForeColor = System.Drawing.Color.DimGray;
            this.p1Threshold.Location = new System.Drawing.Point(276, 559);
            this.p1Threshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1Threshold.Name = "p1Threshold";
            this.p1Threshold.Size = new System.Drawing.Size(218, 120);
            this.p1Threshold.TabIndex = 19;
            this.p1Threshold.Text = "200";
            this.p1Threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setTimeP1
            // 
            this.setTimeP1.AutoSize = true;
            this.setTimeP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.setTimeP1.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeP1.Location = new System.Drawing.Point(88, 2);
            this.setTimeP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setTimeP1.Name = "setTimeP1";
            this.setTimeP1.Size = new System.Drawing.Size(298, 120);
            this.setTimeP1.TabIndex = 16;
            this.setTimeP1.Text = "00:30";
            this.setTimeP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2ValidPunch
            // 
            this.p2ValidPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2ValidPunch.AutoSize = true;
            this.p2ValidPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2ValidPunch.ForeColor = System.Drawing.Color.Green;
            this.p2ValidPunch.Location = new System.Drawing.Point(517, 56);
            this.p2ValidPunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2ValidPunch.Name = "p2ValidPunch";
            this.p2ValidPunch.Size = new System.Drawing.Size(106, 120);
            this.p2ValidPunch.TabIndex = 32;
            this.p2ValidPunch.Text = "0";
            this.p2ValidPunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2ValidPunch.TextChanged += new System.EventHandler(this.punchCounter1_TextChanged);
            // 
            // p2LastHit
            // 
            this.p2LastHit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2LastHit.AutoSize = true;
            this.p2LastHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2LastHit.ForeColor = System.Drawing.Color.DimGray;
            this.p2LastHit.Location = new System.Drawing.Point(330, 795);
            this.p2LastHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2LastHit.Name = "p2LastHit";
            this.p2LastHit.Size = new System.Drawing.Size(106, 120);
            this.p2LastHit.TabIndex = 31;
            this.p2LastHit.Text = "0";
            this.p2LastHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2LastHit.TextChanged += new System.EventHandler(this.p2LastHit_TextChanged);
            // 
            // p2Threshold
            // 
            this.p2Threshold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2Threshold.AutoSize = true;
            this.p2Threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2Threshold.ForeColor = System.Drawing.Color.DimGray;
            this.p2Threshold.Location = new System.Drawing.Point(274, 559);
            this.p2Threshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2Threshold.Name = "p2Threshold";
            this.p2Threshold.Size = new System.Drawing.Size(218, 120);
            this.p2Threshold.TabIndex = 29;
            this.p2Threshold.Text = "200";
            this.p2Threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2Threshold.TextChanged += new System.EventHandler(this.threshold1_TextChanged);
            // 
            // p2CurrTime
            // 
            this.p2CurrTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2CurrTime.AutoSize = true;
            this.p2CurrTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2CurrTime.ForeColor = System.Drawing.Color.DimGray;
            this.p2CurrTime.Location = new System.Drawing.Point(113, 703);
            this.p2CurrTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2CurrTime.Name = "p2CurrTime";
            this.p2CurrTime.Size = new System.Drawing.Size(436, 120);
            this.p2CurrTime.TabIndex = 41;
            this.p2CurrTime.Text = "00:00.00";
            this.p2CurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2CurrTime.TextChanged += new System.EventHandler(this.currentTime1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(780, 206);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(13, 948);
            this.tableLayoutPanel2.TabIndex = 42;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1481, 206);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(13, 956);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // p1StartButton
            // 
            this.p1StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1StartButton.AutoSize = true;
            this.p1StartButton.BackColor = System.Drawing.Color.Transparent;
            this.p1StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1StartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.p1StartButton.Location = new System.Drawing.Point(28, 17);
            this.p1StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.p1StartButton.Name = "p1StartButton";
            this.p1StartButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p1StartButton.Size = new System.Drawing.Size(161, 66);
            this.p1StartButton.TabIndex = 44;
            this.p1StartButton.Text = "Start";
            this.p1StartButton.UseVisualStyleBackColor = true;
            this.p1StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // p1StopButton
            // 
            this.p1StopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1StopButton.AutoSize = true;
            this.p1StopButton.BackColor = System.Drawing.Color.Transparent;
            this.p1StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1StopButton.ForeColor = System.Drawing.Color.Red;
            this.p1StopButton.Location = new System.Drawing.Point(246, 17);
            this.p1StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.p1StopButton.Name = "p1StopButton";
            this.p1StopButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p1StopButton.Size = new System.Drawing.Size(161, 66);
            this.p1StopButton.TabIndex = 45;
            this.p1StopButton.Text = "Stop";
            this.p1StopButton.UseVisualStyleBackColor = true;
            this.p1StopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // p1ResetButton
            // 
            this.p1ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1ResetButton.AutoSize = true;
            this.p1ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.p1ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p1ResetButton.Location = new System.Drawing.Point(466, 17);
            this.p1ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.p1ResetButton.Name = "p1ResetButton";
            this.p1ResetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p1ResetButton.Size = new System.Drawing.Size(161, 66);
            this.p1ResetButton.TabIndex = 46;
            this.p1ResetButton.Text = "Reset";
            this.p1ResetButton.UseVisualStyleBackColor = true;
            this.p1ResetButton.Click += new System.EventHandler(this.p1ResetButton_Click);
            // 
            // p2StartButton
            // 
            this.p2StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2StartButton.AutoSize = true;
            this.p2StartButton.BackColor = System.Drawing.Color.Transparent;
            this.p2StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2StartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.p2StartButton.Location = new System.Drawing.Point(28, 17);
            this.p2StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.p2StartButton.Name = "p2StartButton";
            this.p2StartButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p2StartButton.Size = new System.Drawing.Size(161, 66);
            this.p2StartButton.TabIndex = 47;
            this.p2StartButton.Text = "Start";
            this.p2StartButton.UseVisualStyleBackColor = true;
            this.p2StartButton.Click += new System.EventHandler(this.p2StartButton1_Click);
            // 
            // p2StopButton
            // 
            this.p2StopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2StopButton.AutoSize = true;
            this.p2StopButton.BackColor = System.Drawing.Color.Transparent;
            this.p2StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2StopButton.ForeColor = System.Drawing.Color.Red;
            this.p2StopButton.Location = new System.Drawing.Point(246, 17);
            this.p2StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.p2StopButton.Name = "p2StopButton";
            this.p2StopButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p2StopButton.Size = new System.Drawing.Size(161, 66);
            this.p2StopButton.TabIndex = 48;
            this.p2StopButton.Text = "Stop";
            this.p2StopButton.UseVisualStyleBackColor = true;
            this.p2StopButton.Click += new System.EventHandler(this.stopButton1_Click_1);
            // 
            // p2ResetButton
            // 
            this.p2ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2ResetButton.AutoSize = true;
            this.p2ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.p2ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p2ResetButton.Location = new System.Drawing.Point(466, 17);
            this.p2ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.p2ResetButton.Name = "p2ResetButton";
            this.p2ResetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p2ResetButton.Size = new System.Drawing.Size(161, 66);
            this.p2ResetButton.TabIndex = 49;
            this.p2ResetButton.Text = "Reset";
            this.p2ResetButton.UseVisualStyleBackColor = true;
            this.p2ResetButton.Click += new System.EventHandler(this.p2ResetButton1_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // p1PlusIcon
            // 
            this.p1PlusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1PlusIcon.AutoSize = true;
            this.p1PlusIcon.BackColor = System.Drawing.Color.Transparent;
            this.p1PlusIcon.FlatAppearance.BorderSize = 0;
            this.p1PlusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1PlusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.p1PlusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1PlusIcon.Location = new System.Drawing.Point(393, 24);
            this.p1PlusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.p1PlusIcon.Name = "p1PlusIcon";
            this.p1PlusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p1PlusIcon.Size = new System.Drawing.Size(75, 75);
            this.p1PlusIcon.TabIndex = 52;
            this.p1PlusIcon.Text = "+";
            this.p1PlusIcon.UseVisualStyleBackColor = true;
            this.p1PlusIcon.Click += new System.EventHandler(this.p1PlusIcon_Click);
            // 
            // p1MinusIcon
            // 
            this.p1MinusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1MinusIcon.AutoSize = true;
            this.p1MinusIcon.BackColor = System.Drawing.Color.Transparent;
            this.p1MinusIcon.FlatAppearance.BorderSize = 0;
            this.p1MinusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1MinusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.p1MinusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1MinusIcon.Location = new System.Drawing.Point(4, 28);
            this.p1MinusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.p1MinusIcon.Name = "p1MinusIcon";
            this.p1MinusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p1MinusIcon.Size = new System.Drawing.Size(77, 68);
            this.p1MinusIcon.TabIndex = 53;
            this.p1MinusIcon.Text = " -";
            this.p1MinusIcon.UseVisualStyleBackColor = true;
            this.p1MinusIcon.Click += new System.EventHandler(this.p1MinusIcon_Click);
            // 
            // p2MinusIcon
            // 
            this.p2MinusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2MinusIcon.AutoSize = true;
            this.p2MinusIcon.BackColor = System.Drawing.Color.Transparent;
            this.p2MinusIcon.FlatAppearance.BorderSize = 0;
            this.p2MinusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2MinusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.p2MinusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2MinusIcon.Location = new System.Drawing.Point(4, 24);
            this.p2MinusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.p2MinusIcon.Name = "p2MinusIcon";
            this.p2MinusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p2MinusIcon.Size = new System.Drawing.Size(75, 75);
            this.p2MinusIcon.TabIndex = 58;
            this.p2MinusIcon.Text = " -";
            this.p2MinusIcon.UseVisualStyleBackColor = true;
            this.p2MinusIcon.Click += new System.EventHandler(this.minusIcon1_Click);
            // 
            // p2PlusIcon
            // 
            this.p2PlusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2PlusIcon.AutoSize = true;
            this.p2PlusIcon.BackColor = System.Drawing.Color.Transparent;
            this.p2PlusIcon.FlatAppearance.BorderSize = 0;
            this.p2PlusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2PlusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.p2PlusIcon.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2PlusIcon.Location = new System.Drawing.Point(391, 24);
            this.p2PlusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.p2PlusIcon.Name = "p2PlusIcon";
            this.p2PlusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.p2PlusIcon.Size = new System.Drawing.Size(75, 75);
            this.p2PlusIcon.TabIndex = 57;
            this.p2PlusIcon.Text = "+";
            this.p2PlusIcon.UseVisualStyleBackColor = true;
            this.p2PlusIcon.Click += new System.EventHandler(this.p2PlusIcon1_Click);
            // 
            // p2SetTime
            // 
            this.p2SetTime.AutoSize = true;
            this.p2SetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2SetTime.ForeColor = System.Drawing.Color.DimGray;
            this.p2SetTime.Location = new System.Drawing.Point(86, 2);
            this.p2SetTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2SetTime.Name = "p2SetTime";
            this.p2SetTime.Size = new System.Drawing.Size(298, 120);
            this.p2SetTime.TabIndex = 54;
            this.p2SetTime.Text = "00:30";
            this.p2SetTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.ForeColor = System.Drawing.Color.SteelBlue;
            this.header.Location = new System.Drawing.Point(384, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1489, 158);
            this.header.TabIndex = 59;
            this.header.Text = "Punch Count Competition";
            // 
            // player1Header
            // 
            this.player1Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1Header.AutoSize = true;
            this.player1Header.ForeColor = System.Drawing.Color.Gray;
            this.player1Header.Location = new System.Drawing.Point(269, 0);
            this.player1Header.Name = "player1Header";
            this.player1Header.Size = new System.Drawing.Size(232, 81);
            this.player1Header.TabIndex = 60;
            this.player1Header.Text = "Guest 1";
            // 
            // p1ValidPunchesHeader
            // 
            this.p1ValidPunchesHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1ValidPunchesHeader.AutoSize = true;
            this.p1ValidPunchesHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1ValidPunchesHeader.Location = new System.Drawing.Point(425, 0);
            this.p1ValidPunchesHeader.Name = "p1ValidPunchesHeader";
            this.p1ValidPunchesHeader.Size = new System.Drawing.Size(296, 54);
            this.p1ValidPunchesHeader.TabIndex = 61;
            this.p1ValidPunchesHeader.Text = "Valid Punches";
            this.p1ValidPunchesHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // p1InvalidPunchHeader
            // 
            this.p1InvalidPunchHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1InvalidPunchHeader.AutoSize = true;
            this.p1InvalidPunchHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1InvalidPunchHeader.Location = new System.Drawing.Point(26, 0);
            this.p1InvalidPunchHeader.Name = "p1InvalidPunchHeader";
            this.p1InvalidPunchHeader.Size = new System.Drawing.Size(329, 54);
            this.p1InvalidPunchHeader.TabIndex = 62;
            this.p1InvalidPunchHeader.Text = "Invalid Punches";
            // 
            // p1TimeSetHeader
            // 
            this.p1TimeSetHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1TimeSetHeader.AutoSize = true;
            this.p1TimeSetHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1TimeSetHeader.Location = new System.Drawing.Point(186, 265);
            this.p1TimeSetHeader.Name = "p1TimeSetHeader";
            this.p1TimeSetHeader.Size = new System.Drawing.Size(397, 81);
            this.p1TimeSetHeader.TabIndex = 63;
            this.p1TimeSetHeader.Text = "Time Setting";
            // 
            // p1InvalidPunch
            // 
            this.p1InvalidPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1InvalidPunch.AutoSize = true;
            this.p1InvalidPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p1InvalidPunch.ForeColor = System.Drawing.Color.Green;
            this.p1InvalidPunch.Location = new System.Drawing.Point(138, 56);
            this.p1InvalidPunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1InvalidPunch.Name = "p1InvalidPunch";
            this.p1InvalidPunch.Size = new System.Drawing.Size(106, 120);
            this.p1InvalidPunch.TabIndex = 64;
            this.p1InvalidPunch.Text = "0";
            this.p1InvalidPunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1ThresholdHeader
            // 
            this.p1ThresholdHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1ThresholdHeader.AutoSize = true;
            this.p1ThresholdHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1ThresholdHeader.Location = new System.Drawing.Point(137, 476);
            this.p1ThresholdHeader.Name = "p1ThresholdHeader";
            this.p1ThresholdHeader.Size = new System.Drawing.Size(495, 81);
            this.p1ThresholdHeader.TabIndex = 65;
            this.p1ThresholdHeader.Text = "Threshold Force";
            // 
            // p1LastHitHeader
            // 
            this.p1LastHitHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1LastHitHeader.AutoSize = true;
            this.p1LastHitHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1LastHitHeader.Location = new System.Drawing.Point(257, 681);
            this.p1LastHitHeader.Name = "p1LastHitHeader";
            this.p1LastHitHeader.Size = new System.Drawing.Size(256, 81);
            this.p1LastHitHeader.TabIndex = 66;
            this.p1LastHitHeader.Text = "Last Hit";
            // 
            // p1CurrTimeHeader
            // 
            this.p1CurrTimeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1CurrTimeHeader.AutoSize = true;
            this.p1CurrTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p1CurrTimeHeader.Location = new System.Drawing.Point(126, 187);
            this.p1CurrTimeHeader.Name = "p1CurrTimeHeader";
            this.p1CurrTimeHeader.Size = new System.Drawing.Size(410, 81);
            this.p1CurrTimeHeader.TabIndex = 67;
            this.p1CurrTimeHeader.Text = "Current Time";
            // 
            // p2CurrTimeHeader
            // 
            this.p2CurrTimeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2CurrTimeHeader.AutoSize = true;
            this.p2CurrTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2CurrTimeHeader.Location = new System.Drawing.Point(126, 618);
            this.p2CurrTimeHeader.Name = "p2CurrTimeHeader";
            this.p2CurrTimeHeader.Size = new System.Drawing.Size(410, 81);
            this.p2CurrTimeHeader.TabIndex = 68;
            this.p2CurrTimeHeader.Text = "Current Time";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(196, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 39);
            this.label9.TabIndex = 69;
            this.label9.Text = "-----------------------";
            // 
            // p1CenterHeader
            // 
            this.p1CenterHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1CenterHeader.AutoSize = true;
            this.p1CenterHeader.ForeColor = System.Drawing.Color.Gray;
            this.p1CenterHeader.Location = new System.Drawing.Point(3, 0);
            this.p1CenterHeader.Name = "p1CenterHeader";
            this.p1CenterHeader.Size = new System.Drawing.Size(657, 81);
            this.p1CenterHeader.TabIndex = 70;
            this.p1CenterHeader.Text = "Guest 1";
            // 
            // p2CenterHeader
            // 
            this.p2CenterHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.p2CenterHeader.AutoSize = true;
            this.p2CenterHeader.ForeColor = System.Drawing.Color.Silver;
            this.p2CenterHeader.Location = new System.Drawing.Point(420, 431);
            this.p2CenterHeader.Name = "p2CenterHeader";
            this.p2CenterHeader.Size = new System.Drawing.Size(240, 81);
            this.p2CenterHeader.TabIndex = 71;
            this.p2CenterHeader.Text = "Guest 2";
            // 
            // p2Header
            // 
            this.p2Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2Header.AutoSize = true;
            this.p2Header.ForeColor = System.Drawing.Color.Silver;
            this.p2Header.Location = new System.Drawing.Point(263, 0);
            this.p2Header.Name = "p2Header";
            this.p2Header.Size = new System.Drawing.Size(240, 81);
            this.p2Header.TabIndex = 72;
            this.p2Header.Text = "Guest 2";
            // 
            // p2ValidPunchHeader
            // 
            this.p2ValidPunchHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2ValidPunchHeader.AutoSize = true;
            this.p2ValidPunchHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2ValidPunchHeader.Location = new System.Drawing.Point(422, 0);
            this.p2ValidPunchHeader.Name = "p2ValidPunchHeader";
            this.p2ValidPunchHeader.Size = new System.Drawing.Size(296, 54);
            this.p2ValidPunchHeader.TabIndex = 73;
            this.p2ValidPunchHeader.Text = "Valid Punches";
            this.p2ValidPunchHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2InvalidPunchHeader
            // 
            this.p2InvalidPunchHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2InvalidPunchHeader.AutoSize = true;
            this.p2InvalidPunchHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2InvalidPunchHeader.Location = new System.Drawing.Point(25, 0);
            this.p2InvalidPunchHeader.Name = "p2InvalidPunchHeader";
            this.p2InvalidPunchHeader.Size = new System.Drawing.Size(329, 54);
            this.p2InvalidPunchHeader.TabIndex = 74;
            this.p2InvalidPunchHeader.Text = "Invalid Punches";
            // 
            // p2TimeSetHeader
            // 
            this.p2TimeSetHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2TimeSetHeader.AutoSize = true;
            this.p2TimeSetHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2TimeSetHeader.Location = new System.Drawing.Point(185, 265);
            this.p2TimeSetHeader.Name = "p2TimeSetHeader";
            this.p2TimeSetHeader.Size = new System.Drawing.Size(397, 81);
            this.p2TimeSetHeader.TabIndex = 75;
            this.p2TimeSetHeader.Text = "Time Setting";
            // 
            // p2ThresholdHeader
            // 
            this.p2ThresholdHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2ThresholdHeader.AutoSize = true;
            this.p2ThresholdHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2ThresholdHeader.Location = new System.Drawing.Point(136, 476);
            this.p2ThresholdHeader.Name = "p2ThresholdHeader";
            this.p2ThresholdHeader.Size = new System.Drawing.Size(495, 81);
            this.p2ThresholdHeader.TabIndex = 76;
            this.p2ThresholdHeader.Text = "Threshold Force";
            // 
            // p2LastHitHeader
            // 
            this.p2LastHitHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2LastHitHeader.AutoSize = true;
            this.p2LastHitHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2LastHitHeader.Location = new System.Drawing.Point(255, 681);
            this.p2LastHitHeader.Name = "p2LastHitHeader";
            this.p2LastHitHeader.Size = new System.Drawing.Size(256, 81);
            this.p2LastHitHeader.TabIndex = 77;
            this.p2LastHitHeader.Text = "Last Hit";
            // 
            // p2InvalidPunch
            // 
            this.p2InvalidPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2InvalidPunch.AutoSize = true;
            this.p2InvalidPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.p2InvalidPunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p2InvalidPunch.Location = new System.Drawing.Point(137, 56);
            this.p2InvalidPunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2InvalidPunch.Name = "p2InvalidPunch";
            this.p2InvalidPunch.Size = new System.Drawing.Size(106, 120);
            this.p2InvalidPunch.TabIndex = 78;
            this.p2InvalidPunch.Text = "0";
            this.p2InvalidPunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.player1Header, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.p1TimeSetHeader, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.p1ThresholdHeader, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.p1Threshold, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.p1LastHitHeader, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.p1LastHit, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 206);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 936);
            this.tableLayoutPanel3.TabIndex = 79;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.p1MinusIcon);
            this.flowLayoutPanel1.Controls.Add(this.setTimeP1);
            this.flowLayoutPanel1.Controls.Add(this.p1PlusIcon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 349);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 124);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.p1InvalidPunchHeader, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.p1ValidPunchesHeader, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.p1InvalidPunch, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.p1ValidPunch, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(764, 178);
            this.tableLayoutPanel4.TabIndex = 81;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.p2Header, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.p2LastHitHeader, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.p2TimeSetHeader, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.p2ThresholdHeader, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.p2Threshold, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.p2LastHit, 0, 7);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1501, 206);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(767, 948);
            this.tableLayoutPanel5.TabIndex = 80;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.p2InvalidPunchHeader, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.p2InvalidPunch, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.p2ValidPunchHeader, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.p2ValidPunch, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(761, 178);
            this.tableLayoutPanel6.TabIndex = 81;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.p2MinusIcon);
            this.flowLayoutPanel2.Controls.Add(this.p2SetTime);
            this.flowLayoutPanel2.Controls.Add(this.p2PlusIcon);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(148, 349);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(470, 124);
            this.flowLayoutPanel2.TabIndex = 82;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.p1CenterHeader, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.p1CurrTimeHeader, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.p2CurrTimeHeader, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.p2CenterHeader, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.p1CurrTime, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.p2CurrTime, 0, 8);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 6);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(811, 276);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 9;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(663, 828);
            this.tableLayoutPanel7.TabIndex = 81;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.p1StartButton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.p1StopButton, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.p1ResetButton, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(657, 100);
            this.tableLayoutPanel8.TabIndex = 71;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.p2StartButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.p2StopButton, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.p2ResetButton, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 515);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(657, 100);
            this.tableLayoutPanel9.TabIndex = 72;
            // 
            // punch_count_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.header);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "punch_count_comp";
            this.Size = new System.Drawing.Size(2287, 1164);
            this.Load += new System.EventHandler(this.punch_count_comp_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label9;
        private MediumInfo p1ValidPunch;
        private MediumInfo p1CurrTime;
        private MediumInfo p1LastHit;
        private MediumInfo p1Threshold;
        private MediumInfo setTimeP1;
        private MediumInfo p2ValidPunch;
        private MediumInfo p2Threshold;
        private MediumInfo p2CurrTime;
        private OutlineButton p1StartButton;
        private OutlineButton p1StopButton;
        private OutlineButton p1ResetButton;
        private OutlineButton p2StartButton;
        private OutlineButton p2StopButton;
        private OutlineButton p2ResetButton;
        private TextButton p1PlusIcon;
        private TextButton p1MinusIcon;
        private TextButton p2MinusIcon;
        private TextButton p2PlusIcon;
        private MediumInfo p2SetTime;
        private H2 header;
        private H3 player1Header;
        private H4 p1ValidPunchesHeader;
        private H4 p1InvalidPunchHeader;
        private H3 p1TimeSetHeader;
        private MediumInfo p1InvalidPunch;
        private H3 p1ThresholdHeader;
        private H3 p1LastHitHeader;
        private H3 p1CurrTimeHeader;
        private H3 p2CurrTimeHeader;
        private H3 p1CenterHeader;
        private H3 p2CenterHeader;
        private H3 p2Header;
        private H4 p2ValidPunchHeader;
        private H4 p2InvalidPunchHeader;
        private H3 p2TimeSetHeader;
        private H3 p2ThresholdHeader;
        private H3 p2LastHitHeader;
        private MediumInfo p2InvalidPunch;
        private MediumInfo p2LastHit;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
    }
}
