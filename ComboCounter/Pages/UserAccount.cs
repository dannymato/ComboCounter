using System;
using System.Drawing;
using System.Windows.Forms;
using ComboCounter.Classes;
using MySql.Data.MySqlClient;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class UserAccount : BaseFormControl
    {
        public bool firstNameBool = false;
        public bool lastNameBool = false;
        public bool sexBool = false;
        public bool weightBool = false;
        public bool heightBool = false;



        public UserAccount()
        {
            InitializeComponent();
        }

        private string username;
        private string password;
        private string fname;
        private string lname;

        public void getInfo()
        {
                username = UserManager.GetUsername();
                password = UserManager.GetPassword();
                fname = UserManager.GetFname();
                lname = UserManager.GetLname();
                P1User.Text = username;
                textBox18.Text = password;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            username_tb.Visible = true;
            textBox2.Visible = true;
            p2Fn.Visible = true;
            p2Ln.Visible = true;
          //  textBox4.Visible = true;
            p2Sex.Visible = true;
            p2Height.Visible = true;
            p2Weight.Visible = true;
           // textBox7.Visible = true;
            submit_b.Visible = true;
            panel1.Visible = false;
            panel2.Location = new Point((Width / 2) - (panel3.Width / 2) + 200, (Height / 2) - (panel3.Height / 2) + 150);
            // panel2.Location = panel1.Location;
            // panel1.SendToBack();
            // panel2.BringToFront();
            panel2.Show();

        }

        private void submit_b_Click(object sender, EventArgs e)
        {
            username_tb.Visible = false;
            textBox2.Visible = false;
            p2Fn.Visible = false;
            p2Ln.Visible = false;
          //  textBox4.Visible = false;
            p2Sex.Visible = false;
            p2Height.Visible = false;
            p2Weight.Visible = false;
          //  textBox7.Visible = false;
            submit_b.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        


            if(firstNameBool == true)
            { UserManager.ChangeFirstName(p2Fn.Text); }

            if(lastNameBool == true)
            { UserManager.ChangeLastName(p2Ln.Text); }
            
            if(sexBool == true)
            { UserManager.ChangeSex(p2Sex.Text); }

            if(weightBool == true)
            { UserManager.ChangeWeight(Int32.Parse(p2Weight.Text)); }

            if(heightBool == true)
            { UserManager.ChangeHeight(Int32.Parse(p2Height.Text)); }
            

        }

        private void UserAccount_Load(object sender, EventArgs e)
        {


            FontManager fm = FontManager.getInstance();

            header11.Font = fm.getHeader2Font();
            header11.ForeColor = ThemeConstants.HeaderTextColor1;
            UsernameAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            PasswordAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            NameAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            EmailAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            SexAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            ClassAccount.ForeColor = ThemeConstants.HeaderTextColor1;


            panel3.Location = new Point((Width / 2) - (panel3.Width / 2), (Height / 2) - (panel3.Height / 2));
            panel1.Location = new Point((panel3.Width / 2) - (panel1.Width / 2), (panel1.Height / 2) - (panel1.Height / 2) + 110);
            header11.Location = new Point((panel3.Width / 2) - (header11.Width / 2), 0);
           
            P1User.Text = UserManager.GetUsername();
            P1Name.Text = UserManager.GetFname() + " " + UserManager.GetLname();
            P1Class.Text = ClassDefiner.WeightDivision();

            username_tb.Text = UserManager.GetUsername();

        }

        private void panel1_Enter(object sender, EventArgs e)
        {

            //groupBox1.Visibility = System.Visibility.Hidden;

        }

        private void header11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void smallInfo1_Click(object sender, EventArgs e)
        {

        }

        private void smallInfo1_Click_1(object sender, EventArgs e)
        {

        }

        public override void OnPageAttached()
        {
            
        }

        public override void OnPageRemoved()
        {
            
        }

        public override void OnExit()
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p2Weight_TextChanged(object sender, EventArgs e)
        {
            weightBool = true;
        }

        private void p2Height_TextChanged(object sender, EventArgs e)
        {
            heightBool = true;
        }

        private void p2Fn_TextChanged(object sender, EventArgs e)
        {
            firstNameBool = true;
        }

        private void p2Ln_TextChanged(object sender, EventArgs e)
        {
            lastNameBool = true;
        }

        private void p2Sex_TextChanged(object sender, EventArgs e)
        {
            sexBool = true;
        }
    }
}
