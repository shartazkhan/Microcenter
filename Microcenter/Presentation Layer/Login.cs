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
        public string pos;
        public Login()
        {
            InitializeComponent();
        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }

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
                    
                    

                    if ("Admin" == result)
                    {
                        this.pos = result;
                        AdminDashboard adminDashboard = new AdminDashboard(this);
                        this.Hide();
                        adminDashboard.Show();
                        textBoxPassword.Text = String.Empty;
                        
                    }
                    else if ("Cashier" == result)
                    {
                        this.pos = result;
                        CashierDashboard cashierDashboard = new CashierDashboard(this);
                        textBoxPassword.Text = String.Empty;
                        this.Hide();
                        cashierDashboard.Show();
                    }
                    else if ("Manager" == result)
                    {
                        this.pos = result;
                        ManagerDashboard managerDashboard = new ManagerDashboard(this);
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
