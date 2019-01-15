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
    public partial class MainForm : Form
    {
        public MainForm(String userName)
        {
            InitializeComponent();
            loginUsername.Text = userName;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.Show();
        }

        private void exitForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
