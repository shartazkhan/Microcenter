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

namespace Microcenter.Presentation_Layer
{
    public partial class label0 : Form
    {
        private AdminDashboard adminDashboard;
        List<string> genderList = new List<string>() { "Gender", "Male", "Female", "Other" };
        List<string> positionList = new List<string>() { "Position", "Manager", "Cashier", "Salesman","Owner" };
        private string tempFileName;
        private string tempFilePath = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
        public label0(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            comboBoxGender.DataSource = genderList;
            comboBox2Position.DataSource = positionList;
        }

        void UpdateList()
        {
            EmployeeService employeeService = new EmployeeService();
            dataGridViewEmployee.DataSource = employeeService.GetAllEmployee();
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
            EmployeeService employeeService = new EmployeeService();

            dataGridViewEmployee.DataSource = employeeService.GetAllEmployee();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonAdd.Enabled = false;

            //textBoxProductID.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxContact.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePickerDoB.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePickerHireDate.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxPath.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();

            string newImage = tempFilePath + dataGridViewEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();


            circlePictureBox.Image = Image.FromFile(newImage);

            if (dataGridViewEmployee.Rows[e.RowIndex].Cells[5].Value.ToString() == "Permanent")
            {
                radioButtonParman.Checked = true;
            }
            else
            {
                radioButtonTempo.Checked = true;
            }

            string genderIndex = dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            string positionIndex = dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
            {
                comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Male");
               
            }
            else if (dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString() == "Female")
            {
                comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Female");
               
            }
            else
            {
                comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Other");
            }

            /*comboBox2Position
            if (dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString() == "Manager")
            {
                comboBox2Position.SelectedIndex = comboBox2Position.FindStringExact("Manager");

            }
            else if (dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString() == "Cashier")
            {
                comboBox2Position.SelectedIndex = comboBox2Position.FindStringExact("Cashier");

            }
            else if (dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString() == "Salesman")
            {
                comboBox2Position.SelectedIndex = comboBox2Position.FindStringExact("Salesman");

            }

            else
            {
                comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Owner");
            }*/

            comboBox2Position.SelectedIndex = comboBox2Position.FindStringExact(dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                
            }
            else if (string.IsNullOrEmpty(textBoxContact.Text))
            {
                
            }
            else if (string.IsNullOrEmpty(textBoxPath.Text))
            {
                
            }
            else if (comboBoxGender.Text == "Gender")
            {
                
            }
            else if (comboBox2Position.Text == "Position")
            {
                
            }
            else if (radioButtonParman.Checked == false && radioButtonTempo.Checked == false)
            {

            }
            else
            {

                string pathOfFolder = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
                //string pathOfFolder2 = pathOfFolder + loggedUser + "_";

                string ln = Path.Combine(pathOfFolder,
                    Path.GetFileName(textBoxPath.Text));

                File.Copy(textBoxPath.Text, (ln + tempFileName), true);
               
                string Emptype;
                if (radioButtonParman.Checked == true)
                {
                    Emptype = radioButtonParman.Text;
                }
                else
                {
                    Emptype = radioButtonTempo.Text;
                }

                EmployeeService employeeService = new EmployeeService();
                int result = employeeService.AddNewEmployee(textBoxName.Text,textBoxContact.Text,comboBoxGender.Text,dateTimePickerDoB.Text, Emptype, dateTimePickerHireDate.Text,comboBox2Position.Text,tempFileName);
                if (result > 0)
                {
                    MessageBox.Show("New product added successfully !!");
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }
            }

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = open.FileName;
                circlePictureBox.Image = new Bitmap(open.FileName);
                // this.abc = System.IO.Path.GetFileNameWithoutExtension(open.FileName);
                this.tempFileName = open.SafeFileName;
            }
        }

        private void circlePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
