namespace ComboCounter
{
    partial class ComboCounterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.counterDisplay = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hardestPunch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalForce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetForceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(934, 106);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(83, 44);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(357, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(454, 42);
            this.resultBox.TabIndex = 3;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // counterDisplay
            // 
            this.counterDisplay.Location = new System.Drawing.Point(179, 12);
            this.counterDisplay.Name = "counterDisplay";
            this.counterDisplay.ReadOnly = true;
            this.counterDisplay.Size = new System.Drawing.Size(100, 26);
            this.counterDisplay.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(934, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 44);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Punch Counter:";
            // 
            // hardestPunch
            // 
            this.hardestPunch.Location = new System.Drawing.Point(179, 79);
            this.hardestPunch.Name = "hardestPunch";
            this.hardestPunch.ReadOnly = true;
            this.hardestPunch.Size = new System.Drawing.Size(100, 26);
            this.hardestPunch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hardest Hit:";
            // 
            // totalForce
            // 
            this.totalForce.Location = new System.Drawing.Point(179, 138);
            this.totalForce.Name = "totalForce";
            this.totalForce.ReadOnly = true;
            this.totalForce.Size = new System.Drawing.Size(100, 26);
            this.totalForce.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Force";
            // 
            // targetForceBox
            // 
            this.targetForceBox.Location = new System.Drawing.Point(179, 191);
            this.targetForceBox.Name = "targetForceBox";
            this.targetForceBox.Size = new System.Drawing.Size(100, 26);
            this.targetForceBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Target Force";
            // 
            // ComboCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 558);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetForceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardestPunch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.counterDisplay);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComboCounterForm";
            this.Text = "ComboCounterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox counterDisplay;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hardestPunch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetForceBox;
        private System.Windows.Forms.Label label4;
    }
}