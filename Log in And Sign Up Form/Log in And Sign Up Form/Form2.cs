using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in_And_Sign_Up_Form
{
    public partial class signUpForm : Form
    {
        public signUpForm()
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
            string cpassword = textBoxCPass.Text;

            if (password != cpassword)
            {
                MessageBox.Show("Password do not match"); 
                textBoxPassword.Clear();
                textBoxCPass.Clear();
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cpassword))
            {
                MessageBox.Show("Please fill up all information");
            }
            else
            {
                MessageBox.Show("Sign Up Successful");
                Close();
            }
            

        }
    }
}
