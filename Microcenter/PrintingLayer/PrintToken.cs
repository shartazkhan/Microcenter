using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcenter.PrintingLayer
{
    public partial class PrintToken : Form
    {
        private int tempInv;
        public PrintToken(int pt)
        {
            InitializeComponent();
            this.tempInv = pt;
            labelInvoiceId.Text = tempInv.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewerInvoice reportViewer = new reportViewerInvoice(tempInv);
            reportViewer.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void PrintToken_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
