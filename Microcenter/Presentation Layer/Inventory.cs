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

namespace Microcenter.Presentation_Layer
{
    public partial class Inventory : Form
    {
        private AdminDashboard adminDashboard;
        private ManagerDashboard managerDashboard;
        private bool _darkMode;
        private string _pos;
        private string pName;
        private string pCategory;
        private int pUnit;
        private decimal pLPrice;
        private decimal pRPrice;
        private int pStock;
        private int pID;

        public Inventory(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            _darkMode = adminDashboard.toggleSwitch1.Checked;
            _pos = adminDashboard.labelPosition.Text;

        }
        public Inventory(ManagerDashboard managerDashboard)
        {
            InitializeComponent();
            this.managerDashboard = managerDashboard;
            _darkMode = managerDashboard.toggleSwitch1.Checked;
            _pos = managerDashboard.labelPosition.Text;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            comboBoxDeleteCategory.DataSource = categoryService.GetCategoryNames();
            comboBoxUpdateCategory.DataSource = categoryService.GetCategoryNames();

            ProductService productService = new ProductService();
            dataGridViewProduct.DataSource = productService.GetAllProducts();
            comboBoxProductCategory.DataSource = categoryService.GetCategoryNames();
            buttonUpdateProduct.Enabled = false;
            buttonDeleteProduct.Enabled = false;

            if (_darkMode == true)
            {
                //this.BackColor = Color.FromArgb(6, 23, 33);
                guna2GroupBox1.BackColor = Color.FromArgb(6, 23, 33);
                guna2GroupBox2.BackColor = Color.FromArgb(6, 23, 33);
                guna2GroupBox1.FillColor = Color.FromArgb(6, 23, 33);
                guna2GroupBox2.FillColor = Color.FromArgb(6, 23, 33);

                guna2GroupBox1.BorderColor = Color.Black;
                guna2GroupBox2.BorderColor = Color.Black;

                this.BackColor = Color.FromArgb(6, 23, 33);
                labelListingPrice.ForeColor = Color.AliceBlue;
                labelRetailPrice.ForeColor = Color.AliceBlue;
                labelStock.ForeColor = Color.AliceBlue;
                labelCategory.ForeColor = Color.AliceBlue;
                labelProductID.ForeColor = Color.AliceBlue;
                labelProductName.ForeColor = Color.AliceBlue;
                labelUnit.ForeColor = Color.AliceBlue;
                radioButtonYes.ForeColor = Color.AliceBlue;
                radioButtonNo.ForeColor = Color.AliceBlue;

                textBoxProductName.FillColor = Color.FromArgb(63, 63, 70);
                textBoxProductListing.FillColor = Color.FromArgb(63, 63, 70);
                textBoxProductRetail.FillColor = Color.FromArgb(63, 63, 70);
                textBoxProductUnit.FillColor = Color.FromArgb(63, 63, 70);
                textBoxProductID.FillColor = Color.FromArgb(63, 63, 70);
                comboBoxProductCategory.FillColor = Color.FromArgb(63, 63, 70);

                textBoxUpdateCategoryName.FillColor = Color.FromArgb(63, 63, 70);
                textBoxAddCategory.FillColor = Color.FromArgb(63, 63, 70);
                textBoxDeleteCategoryId.FillColor = Color.FromArgb(63, 63, 70);
                textBoxUpdateCategoryId.FillColor = Color.FromArgb(63, 63, 70);

                comboBoxDeleteCategory.FillColor = Color.FromArgb(63, 63, 70);
                comboBoxUpdateCategory.FillColor = Color.FromArgb(63, 63, 70);

                dataGridViewProduct.BackgroundColor = Color.FromArgb(63, 63, 70);

                textBoxProductName.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxProductListing.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxProductRetail.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxProductUnit.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxProductID.BorderColor = Color.FromArgb(63, 63, 70);
                comboBoxProductCategory.BorderColor = Color.FromArgb(63, 63, 70);

                textBoxUpdateCategoryName.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxAddCategory.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxDeleteCategoryId.BorderColor = Color.FromArgb(63, 63, 70);
                textBoxUpdateCategoryId.BorderColor = Color.FromArgb(63, 63, 70);

                comboBoxDeleteCategory.BorderColor = Color.FromArgb(63, 63, 70);
                comboBoxUpdateCategory.BorderColor = Color.FromArgb(63, 63, 70);
                // text
                textBoxProductName.ForeColor = Color.AliceBlue;
                textBoxProductListing.ForeColor = Color.AliceBlue;
                textBoxProductRetail.ForeColor = Color.AliceBlue;
                textBoxProductUnit.ForeColor = Color.AliceBlue;
                textBoxProductID.ForeColor = Color.AliceBlue;
                comboBoxProductCategory.ForeColor = Color.AliceBlue;

                textBoxUpdateCategoryName.ForeColor = Color.AliceBlue;
                textBoxAddCategory.ForeColor = Color.AliceBlue;
                textBoxDeleteCategoryId.ForeColor = Color.AliceBlue;
                textBoxUpdateCategoryId.ForeColor = Color.AliceBlue;

                comboBoxDeleteCategory.ForeColor = Color.AliceBlue;
                comboBoxUpdateCategory.ForeColor = Color.AliceBlue;

                gunaLabel1.ForeColor = Color.AliceBlue;

                guna2PictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\Inventory_white.png");
            }
        }

        void UpdateListofCategories()
        {
            CategoryService categoryService = new CategoryService();
            comboBoxDeleteCategory.DataSource = categoryService.GetCategoryNames();
            comboBoxUpdateCategory.DataSource = categoryService.GetCategoryNames();
            UpdateListOfProducts();
        }
        void UpdateListOfProducts()
        {
            CategoryService categoryService = new CategoryService();
            ProductService productService = new ProductService();
            dataGridViewProduct.DataSource = productService.GetAllProducts();
            comboBoxProductCategory.DataSource = categoryService.GetCategoryNames();

            textBoxProductID.Text = String.Empty;
            textBoxProductName.Text = String.Empty;
            textBoxProductUnit.Text = String.Empty;
            textBoxProductRetail.Text = String.Empty;
            textBoxProductListing.Text = String.Empty;
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddCategory.Text))
            {
                MessageBox.Show("Please Enter a Category Name");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.AddNewCategory(textBoxAddCategory.Text,0);
                if (result > 0)
                {
                    MessageBox.Show("New category added successfully !!");
                    UpdateListofCategories();
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?",
                "Mood Test", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.DeleteCategory(Convert.ToInt32(textBoxDeleteCategoryId.Text));
                if (result > 0)
                {
                    MessageBox.Show("Category deleted successfully !!");
                    UpdateListofCategories();
                }
                else
                {
                    MessageBox.Show("Error in deleting.");
                }
            }
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUpdateCategoryName.Text))
            {
                MessageBox.Show("Please Enter a Category name.");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.UpdateExistingCategory(Convert.ToInt32(textBoxUpdateCategoryId.Text), textBoxUpdateCategoryName.Text);
                if (result > 0)
                {
                    MessageBox.Show("Category updated successfully !!");
                    UpdateListofCategories();
                }
                else
                {
                    MessageBox.Show("Error in updating.");
                }
            }
        }

        private void comboBoxUpdateCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            textBoxUpdateCategoryName.Text = comboBoxUpdateCategory.Text;
            textBoxUpdateCategoryId.Text = categoryService.GetCategoryID(comboBoxUpdateCategory.Text).ToString();

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonUpdateProduct.Enabled = true;
            buttonDeleteProduct.Enabled = true;
            buttonAddProduct.Enabled = false;

            try
            {
                textBoxProductID.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                //this.pID = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value);
                textBoxProductName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
               // this.pName = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                // textboxP.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxProductRetail.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
               // this.pRPrice = Convert.ToDecimal(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value);
                textBoxProductListing.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
              //  this.pLPrice = Convert.ToDecimal(dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value);
                textBoxProductUnit.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
               // this.pUnit = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value);
                //textBoxProduct.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value) == 1)
                {
                    radioButtonYes.Checked = true;
                    this.pStock = 1;
                }
                else
                {
                    radioButtonNo.Checked = true;
                    this.pStock = 0;
                }

                CategoryService categoryService = new CategoryService();
                comboBoxProductCategory.DataSource = categoryService.GetCategoryNames();
           
                int catIndex = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells[6].Value);
                comboBoxProductCategory.SelectedIndex =
                    comboBoxProductCategory.FindStringExact(categoryService.GetCategoryName(catIndex).ToString());
                pCategory = categoryService.GetCategoryName(catIndex).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: Your trying to select a header. Please select and index.");
            }

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            textBoxProductID.Text = String.Empty;
            textBoxProductName.Text = String.Empty;
            textBoxProductUnit.Text = String.Empty;
            textBoxProductRetail.Text = String.Empty;
            textBoxProductListing.Text = String.Empty;
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;
            buttonAddProduct.Enabled = true;
            buttonUpdateProduct.Enabled = false;
            buttonDeleteProduct.Enabled = false;
        }

      
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
 
                if (string.IsNullOrEmpty(textBoxProductName.Text))
                {
                    MessageBox.Show("Please Enter a Product Name");
                }
                else if (radioButtonYes.Checked == false && radioButtonNo.Checked == false)
                {
                    MessageBox.Show("Please select Stock Status");

                }
                else if (string.IsNullOrEmpty(textBoxProductUnit.Text))
                {
                    MessageBox.Show("Please Enter Available Unit");

                }
                else if (string.IsNullOrEmpty(textBoxProductRetail.Text))
                {
                    MessageBox.Show("Please Enter The Retail Price");
                }
                else if (string.IsNullOrEmpty(textBoxProductListing.Text))
                {
                    MessageBox.Show("Please Enter the Listing Price");
                }
                else
                {
                    int stock;
                    if (radioButtonYes.Checked == true)
                    {
                        stock = 1;
                    }
                    else
                    {
                        stock = 0;
                    }
                    
                    ProductService productService = new ProductService();
                    int result = productService.AddNewProduct(textBoxProductName.Text, stock, Convert.ToDecimal(textBoxProductRetail.Text), Convert.ToDecimal(textBoxProductListing.Text), Convert.ToInt32(textBoxProductUnit.Text), comboBoxProductCategory.Text,0);
                    if (result > 0)
                    {
                        MessageBox.Show("New product added successfully !!");
                        UpdateListOfProducts();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding.");
                    }
                }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {


            ProductService productService = new ProductService();
            int result = productService.DeleteProduct(Convert.ToInt32(textBoxProductID.Text));
            if (result > 0)
            {
                MessageBox.Show("Product deleted successfully !!");
                UpdateListofCategories();
            }
            else
            {
                MessageBox.Show("Error in deleting Product.");
            }
        }

        private void comboBoxDeleteCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            textBoxDeleteCategoryId.Text = categoryService.GetCategoryID(comboBoxDeleteCategory.Text).ToString();
        }

        private void comboBoxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(textBoxProductName.Text))
            {
                MessageBox.Show("Please Enter a Product Name");
            }
            else if (radioButtonYes.Checked == false && radioButtonNo.Checked == false)
            {
                MessageBox.Show("Please select Stock Status");

            }
            else if (string.IsNullOrEmpty(textBoxProductUnit.Text))
            {
                MessageBox.Show("Please Enter Available Unit");

            }
            else if (string.IsNullOrEmpty(textBoxProductRetail.Text))
            {
                MessageBox.Show("Please Enter The Retail Price");
            }
            else if (string.IsNullOrEmpty(textBoxProductListing.Text))
            {
                MessageBox.Show("Please Enter the Listing Price");
            }
            else
            {
               
                if (radioButtonYes.Checked == true)
                {
                    pStock = 1;
                }
                else
                {
                    pStock = 0;
                }

                pID = Convert.ToInt32(textBoxProductID.Text);
                pName = textBoxProductName.Text;
                pRPrice = Convert.ToDecimal(textBoxProductRetail.Text);
                pLPrice = Convert.ToDecimal(textBoxProductListing.Text);
                pUnit = Convert.ToInt32(textBoxProductUnit.Text);
                pCategory = comboBoxProductCategory.Text;


                ProductService productService = new ProductService();
                int result = productService.UpdateExistingProduct(pID, pName, pStock, pRPrice, pLPrice, pUnit, pCategory);
                if (result > 0)
                {
                    MessageBox.Show("Updated successfully !!");
                    UpdateListOfProducts();
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
