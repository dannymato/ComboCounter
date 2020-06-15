using System.Windows.Forms;
using ComboCounter.Classes;

namespace ComboCounter.Forms
{
    class HomeScreen : UserControl
    {
        private Header1 header11;
        private CustomControls.OutlineButton outlineButton1;
        private TableLayoutPanel tableLayoutPanel1;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header11 = new ComboCounter.Classes.Header1();
            this.outlineButton1 = new ComboCounter.CustomControls.OutlineButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 532F));
            this.tableLayoutPanel1.Controls.Add(this.header11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outlineButton1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1565, 871);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // header11
            // 
            this.header11.AutoSize = true;
            this.header11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.header11.Location = new System.Drawing.Point(3, 0);
            this.header11.Name = "header11";
            this.header11.Size = new System.Drawing.Size(510, 124);
            this.header11.TabIndex = 0;
            this.header11.Text = "Combo Score";
            this.header11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outlineButton1
            // 
            this.outlineButton1.AutoSize = true;
            this.outlineButton1.BackColor = System.Drawing.Color.Transparent;
            this.outlineButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlineButton1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.outlineButton1.FlatAppearance.BorderSize = 2;
            this.outlineButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outlineButton1.ForeColor = System.Drawing.Color.White;
            this.outlineButton1.Location = new System.Drawing.Point(3, 127);
            this.outlineButton1.Name = "outlineButton1";
            this.outlineButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.outlineButton1.Size = new System.Drawing.Size(510, 118);
            this.outlineButton1.TabIndex = 1;
            this.outlineButton1.Text = "DEFAULT";
            this.outlineButton1.UseVisualStyleBackColor = false;
            // 
            // HomeScreen
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1565, 871);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
