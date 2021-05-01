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
        public SalesHistory()
        {
            InitializeComponent();

            SaleService salesService = new SaleService();
            dataGridViewSales.DataSource = salesService.GetAllSales();
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
    }
}
