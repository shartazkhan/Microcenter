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
    public partial class CashierDashboard : Form
    {
        private SaleService saleService;
        private DateTime thisDay;
        private int invoiceid;
        private string productName;
        private int _unitR;
        private decimal _priceR;
        private decimal discountedPrice;
        private int rowIndex;
        public CashierDashboard()
        {
            InitializeComponent();
            saleService = new SaleService();
            this.thisDay = DateTime.Today;
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            CategoryService categoryService = new CategoryService();
            

            comboBoxCategoryName.DataSource = categoryService.GetCategoryNames();
            //comboBoxProductName.DataSource = productService.GetProductNames();
            textBoxInvoiceID.Text = (Convert.ToInt32(saleService.GetInvoiceID()) + 1).ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBoxSalemanID.Text))
            {
                MessageBox.Show("Enter Salesman ID");
            }
            else if (string.IsNullOrEmpty(textBoxUnit.Text))
            {
                MessageBox.Show("Unit Can't be less than 1");
            }
            else if (string.IsNullOrEmpty(textBoxPrice.Text) || Convert.ToDecimal(textBoxPrice.Text) < 0)
            {
                textBoxPrice.Enabled = true;
                MessageBox.Show("Invalid Price");
            }
            else if (string.IsNullOrEmpty(comboBoxCategoryName.Text))
            {
                MessageBox.Show("Select a Category");

            }
            else if (string.IsNullOrEmpty(comboBoxProductName.Text))
            {
                MessageBox.Show("Select a Product");
            }
            else if (string.IsNullOrEmpty(textBoxInvoiceID.Text))
            {
                MessageBox.Show("Invalid Invoice ID");
            }
            else if (string.IsNullOrEmpty(textBoxDiscount.Text) || Convert.ToDecimal(textBoxDiscount.Text) < 0 || Convert.ToDecimal(textBoxDiscount.Text) > Convert.ToDecimal(textBoxPrice.Text))
            {
                MessageBox.Show("Invalid Discount");
            }

            else
            {
                this.discountedPrice = (Convert.ToDecimal(textBoxPrice.Text) - Convert.ToDecimal(textBoxDiscount.Text));
                int result = saleService.AddNewSalesRecord(Convert.ToInt32(textBoxInvoiceID.Text), thisDay.ToString("D"),comboBoxCategoryName.Text,comboBoxProductName.Text,Convert.ToInt32(textBoxUnit.Text),this.discountedPrice, Convert.ToDecimal(textBoxDiscount.Text),Convert.ToInt32(textBoxSalemanID.Text));
                if (result > 0)
                {
                    MessageBox.Show("New Record added successfully !!");
                    //UpdateList();

                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }

                SalesmanService salesmanService = new SalesmanService();
                int _Unit = salesmanService.GetSalesmanUnit(Convert.ToInt32(textBoxSalemanID.Text));
                decimal _Money = salesmanService.GetSalesmanMoney(Convert.ToInt32(textBoxSalemanID.Text));

                _Unit += Convert.ToInt32(textBoxUnit.Text);
                _Money += discountedPrice;

                int result3 = salesmanService.AddSalesmanUM(Convert.ToInt32(textBoxSalemanID.Text), _Unit, _Money);

                ProductService productService = new ProductService();
                int _pSaleCount = productService.GetProductCount(comboBoxProductName.Text) + Convert.ToInt32(textBoxUnit.Text);
                int result4 = productService.UpdateProductCount(comboBoxProductName.Text, _pSaleCount);

                CategoryService categoryService = new CategoryService();
                int _cSaleCount = categoryService.GetCategoryCount(comboBoxCategoryName.Text) + Convert.ToInt32(textBoxUnit.Text);
                int result5 = categoryService.UpdateCategoryCount(comboBoxCategoryName.Text, _cSaleCount);


            }

            dataGridViewINV.Rows.Add(textBoxInvoiceID.Text,comboBoxProductName.Text,textBoxUnit.Text,textBoxDiscount.Text, discountedPrice);
            UpdateList();
        }

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            comboBoxProductName.DataSource = productService.GetProductNamesbyCategoryName(comboBoxCategoryName.Text);
        }

        private void CashierDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            int pid = productService.GetProductID(comboBoxProductName.Text);
            textBoxPrice.Text = productService.GetProductPrice(pid).ToString();
        }

        private void remove()
        {
            buttonAdd.Enabled = false;
            int result = saleService.DeleteSalesRecord(this.invoiceid, this.productName);
            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully !!");
                //UpdateList();
            }
            else
            {
                MessageBox.Show("Error in deleting.");
            }

            SalesmanService salesmanService = new SalesmanService();
            int _Unit = salesmanService.GetSalesmanUnit(Convert.ToInt32(textBoxSalemanID.Text));
            decimal _Money = salesmanService.GetSalesmanMoney(Convert.ToInt32(textBoxSalemanID.Text));

            _Unit -= Convert.ToInt32(this._unitR);
            _Money -= Convert.ToDecimal(this._priceR);

            int result3 = salesmanService.AddSalesmanUM(Convert.ToInt32(textBoxSalemanID.Text), _Unit, _Money);
            dataGridViewINV.Rows.RemoveAt(this.rowIndex);
            buttonRemove.Enabled = false;

            ProductService productService = new ProductService();
            int _pSaleCount = productService.GetProductCount(comboBoxProductName.Text) - this._unitR;
            int result4 = productService.UpdateProductCount(comboBoxProductName.Text, _pSaleCount);

            CategoryService categoryService = new CategoryService();
            int _cSaleCount = categoryService.GetCategoryCount(comboBoxCategoryName.Text) - this._unitR;
            int result5 = categoryService.UpdateCategoryCount(comboBoxCategoryName.Text, _cSaleCount);

            UpdateList();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            remove();
        }

        void UpdateList()
        {
            buttonAdd.Enabled = true;
            textBoxPrice.Text = String.Empty;
            textBoxDiscount.Text = "0";
            textBoxUnit.Text = "1";
            dataGridViewINV.Refresh();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonRemove.Enabled = true;
            
            this.invoiceid = Convert.ToInt32(dataGridViewINV.Rows[e.RowIndex].Cells[0].Value);
            this.productName = dataGridViewINV.Rows[e.RowIndex].Cells[1].Value.ToString();
            this._unitR = Convert.ToInt32(dataGridViewINV.Rows[e.RowIndex].Cells[2].Value);
            this._priceR = Convert.ToDecimal(dataGridViewINV.Rows[e.RowIndex].Cells[4].Value);
            this.rowIndex = dataGridViewINV.CurrentCell.RowIndex;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UpdateList();
            textBoxInvoiceID.Text = (Convert.ToInt32(saleService.GetInvoiceID()) + 1).ToString();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            UpdateList();
            textBoxInvoiceID.Text = (Convert.ToInt32(saleService.GetInvoiceID()) + 1).ToString();
        }
    }
}
