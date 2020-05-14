using System;
using System.Windows.Forms;

namespace ComboCounter
{
    public partial class Register : Form
    {
        private User currUser;

        public Register()
        {
            InitializeComponent();
            User.InitializeDB();
        }

        private void submit_b_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(id_tb.Text);
                String u = username_tb.Text;
                String p = password_tb.Text;
                String fn = fname_tb.Text;
                String ln = lname_tb.Text;
                String sex = sex_tb.Text;
                String c = class_tb.Text;
                String height = heigth_tb.Text;
                String weight = weight_tb.Text;
                int age = Convert.ToInt32(age_tb.Text);


                if (String.IsNullOrEmpty(u) || String.IsNullOrEmpty(p) || i.Equals(null))
                {
                    MessageBox.Show("It's empty");
                    return;
                }

                currUser = User.Insert(i, u, p, fn, ln, sex, c, height, weight, age);

                DialogResult dr = MessageBox.Show("Sign Up Successfull!");
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Some Fields left blank or Id Taken!");
            }

        }
    }
}
