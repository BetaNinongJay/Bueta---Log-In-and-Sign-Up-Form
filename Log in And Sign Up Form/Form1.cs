using System.Windows.Forms;

namespace Log_in_And_Sign_Up_Form
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(55, 0, 0, 0); // Fully transparent pane P.S not totally transluscent
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            //For default account
            string defaultUserName = "admin";
            string defaultPassword = "admin123";

            if (username == defaultUserName || password == defaultPassword)
            {
                MessageBox.Show("Log In Successful");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpForm signUpForm = new signUpForm();
            signUpForm.ShowDialog();
        }
    }
}
