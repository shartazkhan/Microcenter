using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microcenter.Business_Logic_Layer;
using Microcenter.Data_Access_Layer.Entities;
using Microcenter.PrintingLayer;

namespace Microcenter.Presentation_Layer
{
    public partial class SalesHistory : Form
    {
        AdminDashboard adminDashboard;
        ManagerDashboard managerDashboard;
        private string _pos;
        public SalesHistory(AdminDashboard adminDashboard)
        {
            InitializeComponent();

            SaleService salesService = new SaleService();
            dataGridViewSales.DataSource = salesService.GetAllSales();

            this.adminDashboard = adminDashboard;
            _pos = adminDashboard.labelPosition.Text;
            if (adminDashboard.toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
                dataGridViewSales.BackgroundColor = Color.FromArgb(63, 63, 70);
            }
        }

        public SalesHistory(ManagerDashboard managerDashboard)
        {
            InitializeComponent();

            SaleService salesService = new SaleService();
            dataGridViewSales.DataSource = salesService.GetAllSales();

            this.managerDashboard = managerDashboard;
            _pos = managerDashboard.labelPosition.Text;
            if (managerDashboard.toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
                dataGridViewSales.BackgroundColor = Color.FromArgb(63, 63, 70);
            }
        }



        private void SalesHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           // reportViewerNUT reportViewer = new reportViewerNUT(Convert.ToInt32(textBoxID.Text));
            reportViewerSales reportViewerSales = new reportViewerSales();
            reportViewerSales.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_pos == "Admin")
            {
                adminDashboard.Show();
            }
            else if (_pos == "Manager")
            {
                managerDashboard.Show();
            }
        }
    }
}
