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
    public partial class ManagerDashboard : Form
    {
        private Login login;
        public ManagerDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
            toggleSwitch1.Checked = false;
        }

        private void ManagerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            SalesmanService salesmanService = new SalesmanService();
            EmployeeService employeeService = new EmployeeService();
            ProductService productService = new ProductService();
            CategoryService categoryService = new CategoryService();

            labelMoney.Text = salesmanService.GetMaxMoney().ToString();
            labelUnit.Text = salesmanService.GetMaxUnit().ToString();

            decimal maxM = salesmanService.GetMaxMoney();
            int maxU = salesmanService.GetMaxUnit();

            int bestEmp1 = salesmanService.GetBestSalesmanCat1(maxM);
            int bestEmp2 = salesmanService.GetBestSalesmanCat2(maxU);

            labelBestEmp1.Text = employeeService.GetEmployeeNameByID(bestEmp1);
            labelBestEmp2.Text = employeeService.GetEmployeeNameByID(bestEmp2);

            int maxSaleCountP = productService.GetMaxSalesCount();
            // dataGridViewProduct.DataSource = productService.GetBestProducts(maxSaleCount);
            labelBSP1.Text = productService.GetBestProduct(maxSaleCountP);

            int maxSaleCountC = categoryService.GetMaxSalesCount();
            // dataGridViewProduct.DataSource = productService.GetBestProducts(maxSaleCount);
            labelBSP2.Text = categoryService.GetBestCategory(maxSaleCountC);

            labelPosition.Text = login.pos;


            UserService userService = new UserService();
            labelName.Text = userService.GetUserName(Convert.ToInt32(login.textBoxEmployeeId.Text));

            string filePath = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
            string fileName = employeeService.GetEmployeePictureByID(Convert.ToInt32(login.textBoxEmployeeId.Text));
            circlePictureBoxDP.Image = Image.FromFile(filePath + fileName);
        }

        private void toggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(this);
            this.Hide();
            inventory.Show();
        }

        private void toggleSwitch1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
                labelTitle1.ForeColor = Color.White;
                labelTitle2.ForeColor = Color.White;
                labelTitle3.ForeColor = Color.White;
                labelTitle4.ForeColor = Color.White;

                labelBSP1.ForeColor = Color.White;
                labelBSP2.ForeColor = Color.White;

                labelBestEmp1.ForeColor = Color.White;
                labelBestEmp2.ForeColor = Color.White;

                labelUnit.ForeColor = Color.White;
                labelMoney.ForeColor = Color.White;

                labelSA.ForeColor = Color.White;
                labelSU.ForeColor = Color.White;

                labelName1.ForeColor = Color.White;
                labelName2.ForeColor = Color.White;

                panel2.BackColor = Color.FromArgb(1, 18, 28);
                panel1.BackColor = Color.FromArgb(1, 18, 28);

                labelMC.ForeColor = Color.White;
                labelDM.ForeColor = Color.White;
                labelDM.Text = "Lite Mode";


            }
            else
            {
                this.BackColor = Color.White;

                labelTitle1.ForeColor = Color.Black;
                labelTitle2.ForeColor = Color.Black;
                labelTitle3.ForeColor = Color.Black;
                labelTitle4.ForeColor = Color.Black;

                labelBSP1.ForeColor = Color.Black;
                labelBSP2.ForeColor = Color.Black;

                labelBestEmp1.ForeColor = Color.Black;
                labelBestEmp2.ForeColor = Color.Black;

                labelUnit.ForeColor = Color.Black;
                labelMoney.ForeColor = Color.Black;

                labelSA.ForeColor = Color.Black;
                labelSU.ForeColor = Color.Black;

                labelName1.ForeColor = Color.Black;
                labelName2.ForeColor = Color.Black;

                panel2.BackColor = Color.WhiteSmoke;
                panel1.BackColor = Color.WhiteSmoke;

                labelMC.ForeColor = Color.Black;
                labelDM.ForeColor = Color.Black;
                labelDM.Text = "Dark Mode";
            }
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            SalesHistory salesHistory = new SalesHistory(this);
            this.Hide();
            salesHistory.Show();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(this);
            this.Hide();
            employeeManagement.Show();
        }
    }
}
