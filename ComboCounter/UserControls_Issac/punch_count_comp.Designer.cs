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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(punch_count_comp));
            this.punchCounter = new System.Windows.Forms.TextBox();
            this.currentTime = new System.Windows.Forms.TextBox();
            this.lastHit = new System.Windows.Forms.TextBox();
            this.threshold = new System.Windows.Forms.TextBox();
            this.setTimeMins = new System.Windows.Forms.TextBox();
            this.punchCounter1 = new System.Windows.Forms.TextBox();
            this.lastHit1 = new System.Windows.Forms.TextBox();
            this.threshold1 = new System.Windows.Forms.TextBox();
            this.currentTime1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton1 = new System.Windows.Forms.Button();
            this.stopButton1 = new System.Windows.Forms.Button();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.setTimeSec = new System.Windows.Forms.TextBox();
            this.plusIcon = new System.Windows.Forms.Button();
            this.minusIcon = new System.Windows.Forms.Button();
            this.minusIcon1 = new System.Windows.Forms.Button();
            this.plusIcon1 = new System.Windows.Forms.Button();
            this.setTimeSec1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.setTimeMins1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // punchCounter
            // 
            this.punchCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.punchCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.punchCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.punchCounter.Location = new System.Drawing.Point(344, 343);
            this.punchCounter.Margin = new System.Windows.Forms.Padding(2);
            this.punchCounter.Name = "punchCounter";
            this.punchCounter.Size = new System.Drawing.Size(141, 85);
            this.punchCounter.TabIndex = 24;
            this.punchCounter.Text = "0";
            this.punchCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentTime
            // 
            this.currentTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.currentTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime.Location = new System.Drawing.Point(616, 443);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(382, 85);
            this.currentTime.TabIndex = 23;
            this.currentTime.Text = "00:00.00";
            this.currentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentTime.TextChanged += new System.EventHandler(this.currentTime_TextChanged);
            // 
            // lastHit
            // 
            this.lastHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.lastHit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastHit.ForeColor = System.Drawing.Color.DimGray;
            this.lastHit.Location = new System.Drawing.Point(153, 832);
            this.lastHit.Margin = new System.Windows.Forms.Padding(2);
            this.lastHit.Name = "lastHit";
            this.lastHit.Size = new System.Drawing.Size(224, 85);
            this.lastHit.TabIndex = 21;
            this.lastHit.Text = "0";
            this.lastHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastHit.TextChanged += new System.EventHandler(this.lastHit_TextChanged_1);
            // 
            // threshold
            // 
            this.threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.threshold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threshold.ForeColor = System.Drawing.Color.DimGray;
            this.threshold.Location = new System.Drawing.Point(30, 683);
            this.threshold.Margin = new System.Windows.Forms.Padding(2);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(464, 85);
            this.threshold.TabIndex = 19;
            this.threshold.Text = "200";
            this.threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setTimeMins
            // 
            this.setTimeMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.setTimeMins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTimeMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeMins.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeMins.Location = new System.Drawing.Point(162, 516);
            this.setTimeMins.Margin = new System.Windows.Forms.Padding(2);
            this.setTimeMins.Name = "setTimeMins";
            this.setTimeMins.Size = new System.Drawing.Size(87, 85);
            this.setTimeMins.TabIndex = 16;
            this.setTimeMins.Text = "00";
            this.setTimeMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // punchCounter1
            // 
            this.punchCounter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.punchCounter1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.punchCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchCounter1.ForeColor = System.Drawing.Color.Green;
            this.punchCounter1.Location = new System.Drawing.Point(1477, 343);
            this.punchCounter1.Margin = new System.Windows.Forms.Padding(2);
            this.punchCounter1.Name = "punchCounter1";
            this.punchCounter1.Size = new System.Drawing.Size(141, 85);
            this.punchCounter1.TabIndex = 32;
            this.punchCounter1.Text = "0";
            this.punchCounter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.punchCounter1.TextChanged += new System.EventHandler(this.punchCounter1_TextChanged);
            // 
            // lastHit1
            // 
            this.lastHit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.lastHit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastHit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastHit1.ForeColor = System.Drawing.Color.DimGray;
            this.lastHit1.Location = new System.Drawing.Point(1296, 830);
            this.lastHit1.Margin = new System.Windows.Forms.Padding(2);
            this.lastHit1.Name = "lastHit1";
            this.lastHit1.Size = new System.Drawing.Size(220, 85);
            this.lastHit1.TabIndex = 31;
            this.lastHit1.Text = "0";
            this.lastHit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastHit1.TextChanged += new System.EventHandler(this.lastHit_TextChanged);
            // 
            // threshold1
            // 
            this.threshold1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.threshold1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threshold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threshold1.ForeColor = System.Drawing.Color.DimGray;
            this.threshold1.Location = new System.Drawing.Point(1171, 683);
            this.threshold1.Margin = new System.Windows.Forms.Padding(2);
            this.threshold1.Name = "threshold1";
            this.threshold1.Size = new System.Drawing.Size(464, 85);
            this.threshold1.TabIndex = 29;
            this.threshold1.Text = "200";
            this.threshold1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threshold1.TextChanged += new System.EventHandler(this.threshold1_TextChanged);
            // 
            // currentTime1
            // 
            this.currentTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.currentTime1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime1.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime1.Location = new System.Drawing.Point(616, 832);
            this.currentTime1.Margin = new System.Windows.Forms.Padding(2);
            this.currentTime1.Name = "currentTime1";
            this.currentTime1.Size = new System.Drawing.Size(382, 85);
            this.currentTime1.TabIndex = 41;
            this.currentTime1.Text = "00:00.00";
            this.currentTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentTime1.TextChanged += new System.EventHandler(this.currentTime1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(545, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(10, 770);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1051, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(10, 777);
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
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.startButton.Location = new System.Drawing.Point(585, 283);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 54);
            this.startButton.TabIndex = 44;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(746, 283);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(121, 54);
            this.stopButton.TabIndex = 45;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(906, 283);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 54);
            this.resetButton.TabIndex = 46;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton1
            // 
            this.startButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton1.ForeColor = System.Drawing.Color.ForestGreen;
            this.startButton1.Location = new System.Drawing.Point(585, 683);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(121, 54);
            this.startButton1.TabIndex = 47;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // stopButton1
            // 
            this.stopButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton1.ForeColor = System.Drawing.Color.Red;
            this.stopButton1.Location = new System.Drawing.Point(746, 683);
            this.stopButton1.Name = "stopButton1";
            this.stopButton1.Size = new System.Drawing.Size(121, 54);
            this.stopButton1.TabIndex = 48;
            this.stopButton1.Text = "Stop";
            this.stopButton1.UseVisualStyleBackColor = true;
            this.stopButton1.Click += new System.EventHandler(this.stopButton1_Click_1);
            // 
            // resetButton1
            // 
            this.resetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton1.Location = new System.Drawing.Point(906, 683);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(121, 54);
            this.resetButton1.TabIndex = 49;
            this.resetButton1.Text = "Reset";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.DimGray;
            this.textBox12.Location = new System.Drawing.Point(248, 522);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(25, 67);
            this.textBox12.TabIndex = 50;
            this.textBox12.Text = ":";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setTimeSec
            // 
            this.setTimeSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.setTimeSec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeSec.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeSec.Location = new System.Drawing.Point(266, 516);
            this.setTimeSec.Margin = new System.Windows.Forms.Padding(2);
            this.setTimeSec.Name = "setTimeSec";
            this.setTimeSec.Size = new System.Drawing.Size(100, 85);
            this.setTimeSec.TabIndex = 51;
            this.setTimeSec.Text = "00";
            this.setTimeSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(357, 529);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(50, 45);
            this.plusIcon.TabIndex = 52;
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(99, 522);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(58, 55);
            this.minusIcon.TabIndex = 53;
            this.minusIcon.Text = " ";
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // minusIcon1
            // 
            this.minusIcon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon1.BackgroundImage")));
            this.minusIcon1.FlatAppearance.BorderSize = 0;
            this.minusIcon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon1.Location = new System.Drawing.Point(1230, 522);
            this.minusIcon1.Name = "minusIcon1";
            this.minusIcon1.Size = new System.Drawing.Size(58, 55);
            this.minusIcon1.TabIndex = 58;
            this.minusIcon1.Text = " ";
            this.minusIcon1.UseVisualStyleBackColor = true;
            this.minusIcon1.Click += new System.EventHandler(this.minusIcon1_Click);
            // 
            // plusIcon1
            // 
            this.plusIcon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon1.BackgroundImage")));
            this.plusIcon1.FlatAppearance.BorderSize = 0;
            this.plusIcon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon1.Location = new System.Drawing.Point(1523, 529);
            this.plusIcon1.Name = "plusIcon1";
            this.plusIcon1.Size = new System.Drawing.Size(50, 45);
            this.plusIcon1.TabIndex = 57;
            this.plusIcon1.UseVisualStyleBackColor = true;
            this.plusIcon1.Click += new System.EventHandler(this.plusIcon1_Click);
            // 
            // setTimeSec1
            // 
            this.setTimeSec1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.setTimeSec1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTimeSec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeSec1.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeSec1.Location = new System.Drawing.Point(1418, 507);
            this.setTimeSec1.Margin = new System.Windows.Forms.Padding(2);
            this.setTimeSec1.Name = "setTimeSec1";
            this.setTimeSec1.Size = new System.Drawing.Size(91, 85);
            this.setTimeSec1.TabIndex = 56;
            this.setTimeSec1.Text = "00";
            this.setTimeSec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DimGray;
            this.textBox3.Location = new System.Drawing.Point(1389, 516);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 67);
            this.textBox3.TabIndex = 55;
            this.textBox3.Text = ":";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setTimeMins1
            // 
            this.setTimeMins1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.setTimeMins1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTimeMins1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeMins1.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeMins1.Location = new System.Drawing.Point(1293, 507);
            this.setTimeMins1.Margin = new System.Windows.Forms.Padding(2);
            this.setTimeMins1.Name = "setTimeMins1";
            this.setTimeMins1.Size = new System.Drawing.Size(92, 85);
            this.setTimeMins1.TabIndex = 54;
            this.setTimeMins1.Text = "00";
            this.setTimeMins1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(288, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1052, 109);
            this.label7.TabIndex = 59;
            this.label7.Text = "Punch Count Competition";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.AutoSize = true;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Gray;
            this.textBox7.Location = new System.Drawing.Point(148, 169);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(229, 73);
            this.textBox7.TabIndex = 60;
            this.textBox7.Text = "Guest 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(300, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 42);
            this.label2.TabIndex = 61;
            this.label2.Text = "Valid Punches";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(2, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 62;
            this.label1.Text = "Invalid Punches";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(126, 441);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 55);
            this.label3.TabIndex = 63;
            this.label3.Text = "Time Setting";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(60, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 85);
            this.textBox1.TabIndex = 64;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(113, 612);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 55);
            this.label4.TabIndex = 65;
            this.label4.Text = "Threshold Force";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(174, 773);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 55);
            this.label5.TabIndex = 66;
            this.label5.Text = "Last Hit";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(623, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 73);
            this.label6.TabIndex = 67;
            this.label6.Text = "Current Time";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(623, 763);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 73);
            this.label8.TabIndex = 68;
            this.label8.Text = "Current Time";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(559, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(492, 73);
            this.label9.TabIndex = 69;
            this.label9.Text = "-----------------------";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(557, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 73);
            this.label10.TabIndex = 70;
            this.label10.Text = "Guest 1";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(818, 584);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 73);
            this.label11.TabIndex = 71;
            this.label11.Text = "Guest 2";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(1261, 169);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 73);
            this.label12.TabIndex = 72;
            this.label12.Text = "Guest 2";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(1445, 290);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 42);
            this.label13.TabIndex = 73;
            this.label13.Text = "Valid Punches";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(1128, 290);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 42);
            this.label14.TabIndex = 74;
            this.label14.Text = "Invalid Punches";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(1264, 441);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 55);
            this.label15.TabIndex = 75;
            this.label15.Text = "Time Setting";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(1239, 612);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(334, 55);
            this.label16.TabIndex = 76;
            this.label16.Text = "Threshold Force";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SteelBlue;
            this.label17.Location = new System.Drawing.Point(1321, 773);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 55);
            this.label17.TabIndex = 77;
            this.label17.Text = "Last Hit";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(1186, 343);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 85);
            this.textBox2.TabIndex = 78;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // punch_count_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusIcon1);
            this.Controls.Add(this.plusIcon1);
            this.Controls.Add(this.setTimeSec1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.setTimeMins1);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.setTimeSec);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.stopButton1);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.currentTime1);
            this.Controls.Add(this.punchCounter1);
            this.Controls.Add(this.lastHit1);
            this.Controls.Add(this.threshold1);
            this.Controls.Add(this.punchCounter);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.lastHit);
            this.Controls.Add(this.threshold);
            this.Controls.Add(this.setTimeMins);
            this.Name = "punch_count_comp";
            this.Size = new System.Drawing.Size(1715, 946);
            this.Load += new System.EventHandler(this.punch_count_comp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox punchCounter;
        private System.Windows.Forms.TextBox currentTime;
        private System.Windows.Forms.TextBox lastHit;
        private System.Windows.Forms.TextBox threshold;
        private System.Windows.Forms.TextBox setTimeMins;
        private System.Windows.Forms.TextBox punchCounter1;
        private System.Windows.Forms.TextBox lastHit1;
        private System.Windows.Forms.TextBox threshold1;
        private System.Windows.Forms.TextBox currentTime1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.Button stopButton1;
        private System.Windows.Forms.Button resetButton1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox setTimeSec;
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Button minusIcon1;
        private System.Windows.Forms.Button plusIcon1;
        private System.Windows.Forms.TextBox setTimeSec1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox setTimeMins1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox2;
    }
}
