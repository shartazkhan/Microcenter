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
using Microcenter.Data_Access_Layer;

namespace Microcenter.Presentation_Layer
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            circlePictureBox.Image = Image.FromFile(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\Avatar.png");

            guna2DataGridView1.DataSource =;
        }
    }
}
