using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcenter.Presentation_Layer
{
    public partial class AdminDashboard : Form
    {
        private Login login;
        public AdminDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
            toggleSwitch1.Checked = false;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
            }
            else
            {
                this.BackColor = Color.White;

            }
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            SalesHistory salesHistory = new SalesHistory();
            this.Hide();
            salesHistory.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(this);
            this.Hide();
            inventory.Show();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagement employeeManagement = new EmployeeManagement(this);
            employeeManagement.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
