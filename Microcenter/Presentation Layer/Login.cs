using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microcenter.Business_Logic_Layer;

namespace Microcenter.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        ~Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(Convert.ToInt32(textBoxEmployeeId.Text), textBoxPassword.Text);
            if (result == -1)
            {
                MessageBox.Show("Invalid ID or password");
            }
            else
            {
                AdminDashboard adminDashboard = new AdminDashboard(this);


                textBoxPassword.Text = String.Empty;
                this.Hide();
                adminDashboard.Show();
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
