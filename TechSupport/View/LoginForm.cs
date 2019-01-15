using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // error message is removed if user edits the password field
        private void password_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // checks the user name password combination
        // routes to main form if correct
        //otherwise displays error message
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Jane" && password.Text =="test1234")
            {
                this.Hide();
                MainForm newMainForm = new MainForm("Welcome " + userName.Text);
                newMainForm.Show();
                
            }
            else
            {
                messageLabel.Text = "invalid username/password";
            }
           
        }

        // resets error message if user changes input field
        private void userName_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        // gracefully exits the application on clicking cancel button at top
        private void exitForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitPassword(object sender, EventArgs e)
        {
            
        }
    }
}
