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
            if (string.IsNullOrEmpty(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please Enter an Employee ID.");
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please Enter a Password.");
            }
            else if (radioButtonAdmin.Checked == false && radioButtonCashier.Checked == false && radioButtonManager.Checked == false)
            {
                MessageBox.Show("Please Select Your Position.");
            }
            else
            {
                LoginService loginService = new LoginService();
                string result = loginService.LoginValidation(Convert.ToInt32(textBoxEmployeeId.Text), textBoxPassword.Text);
                if (result == null)
                {
                    MessageBox.Show("Invalid ID or password");
                }
                else
                {
                    
                    

                    if (radioButtonAdmin.Checked == true && result == radioButtonAdmin.Text)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard(this);
                        this.Hide();
                        adminDashboard.Show();
                        textBoxPassword.Text = String.Empty;
                        
                    }
                    else if (radioButtonCashier.Checked == true && result == radioButtonCashier.Text)
                    {
                        CashierDashboard cashierDashboard = new CashierDashboard();
                        textBoxPassword.Text = String.Empty;
                        this.Hide();
                        cashierDashboard.Show();
                    }
                    else if (radioButtonManager.Checked == true && result == radioButtonManager.Text)
                    {
                        ManagerDashboard managerDashboard = new ManagerDashboard();
                        this.Hide();
                        managerDashboard.Show();
                        textBoxPassword.Text = String.Empty;
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Position Combination");
                    }
                    
                }
            }
            

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
