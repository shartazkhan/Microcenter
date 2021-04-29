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
    public partial class ManagerDashboard : Form
    {
        private Login login;
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_FormClosing(object sender, FormClosingEventArgs e)
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
                this.BackColor = Color.Azure;

            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
