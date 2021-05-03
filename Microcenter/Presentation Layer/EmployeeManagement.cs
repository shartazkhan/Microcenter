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
using Microcenter.Data_Access_Layer;
using Microcenter.PrintingLayer;

namespace Microcenter.Presentation_Layer
{
    public partial class EmployeeManagement : Form
    {
        AdminDashboard adminDashboard;
        ManagerDashboard managerDashboard;
        List<string> genderList = new List<string>() { "Gender", "Male", "Female", "Other" };
        List<string> positionList = new List<string>() { "Position", "Manager", "Cashier", "Salesman","Owner" };
        List<string> positionList2 = new List<string>() { "Position", "Cashier", "Salesman"};
        private string tempFileName;
        private string tempFilePath = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
        public string Emptype;
        public int id;
        public string pos;
        private string imageFileName;
        private int result;
        private string _pos;
        public EmployeeManagement(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            _pos = adminDashboard.labelPosition.Text;
            comboBoxGender.DataSource = genderList;
            comboBox2Position.DataSource = positionList;
            buttonPRF.Enabled = true;
            textBoxPassword.Enabled = false;

            EmployeeService employeeService = new EmployeeService();
            dataGridViewEmployee.DataSource = employeeService.GetAllEmployee();

            if (adminDashboard.toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
                dataGridViewEmployee.BackgroundColor = Color.FromArgb(63, 63, 70);

                textBoxName.ForeColor = Color.White;
                textBoxPassword.ForeColor = Color.White;
                textBoxContact.ForeColor = Color.White;
                textBoxPath.ForeColor = Color.White;
                comboBox2Position.ForeColor = Color.White;
                comboBoxGender.ForeColor = Color.White;

                radioButtonTempo.ForeColor = Color.White;
                radioButtonParman.ForeColor = Color.White;

                labelEmployeeID.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                labelDoB.ForeColor = Color.White;
                labelType.ForeColor = Color.White;

            }
        }

        public EmployeeManagement(ManagerDashboard managerDashboard)
        {
            InitializeComponent();
            this.managerDashboard = managerDashboard;
            _pos = managerDashboard.labelPosition.Text;
            comboBoxGender.DataSource = genderList;
            comboBox2Position.DataSource = positionList2;
            buttonPRF.Enabled = true;
            textBoxPassword.Enabled = false;

            EmployeeService employeeService = new EmployeeService();
            dataGridViewEmployee.DataSource = employeeService.GetAllEmployee2("Salesman", "Cashier");

            if (managerDashboard.toggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(6, 23, 33);
                dataGridViewEmployee.BackgroundColor = Color.FromArgb(63, 63, 70);

                textBoxName.ForeColor = Color.White;
                textBoxPassword.ForeColor = Color.White;
                textBoxContact.ForeColor = Color.White;
                textBoxPath.ForeColor = Color.White;
                comboBox2Position.ForeColor = Color.White;
                comboBoxGender.ForeColor = Color.White;

                radioButtonTempo.ForeColor = Color.White;
                radioButtonParman.ForeColor = Color.White;

                labelEmployeeID.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                labelDoB.ForeColor = Color.White;
                labelType.ForeColor = Color.White;

            }
        }

        void UpdateList()
        {
            EmployeeService employeeService = new EmployeeService();
            dataGridViewEmployee.DataSource = employeeService.GetAllEmployee();

            textBoxName.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            textBoxContact.Text = String.Empty;
            textBoxPath.Text = String.Empty;

            comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Gender");
            comboBox2Position.SelectedIndex = comboBoxGender.FindStringExact("Position");


            circlePictureBox.Image = Image.FromFile(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\Avatar.png");
            radioButtonParman.Checked = false;
            radioButtonTempo.Checked = false;

            buttonCreateAcc.Enabled = false;
            textBoxPassword.Enabled = false;
            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            //circleButtonLoginAccess.Enabled = true;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonAdd.Enabled = false;
            buttonCreateAcc.Enabled = true;
            textBoxPassword.Enabled = true;


            try
            {
                labelEmployeeID.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                id = Convert.ToInt32(labelEmployeeID.Text);

                textBoxName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxContact.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxSalary.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
                dateTimePickerDoB.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePickerHireDate.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();

                //textBoxPath.Text = tempFilePath + dataGridViewEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();
                imageFileName = dataGridViewEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();

                string newImage = tempFilePath + dataGridViewEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();


                circlePictureBox.Image = Image.FromFile(newImage);

                if (dataGridViewEmployee.Rows[e.RowIndex].Cells[5].Value.ToString() == "Permanent")
                {
                    radioButtonParman.Checked = true;
                    Emptype = radioButtonParman.Text;
                }
                else
                {
                    radioButtonTempo.Checked = true;
                    Emptype = radioButtonTempo.Text;
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

                comboBox2Position.SelectedIndex = comboBox2Position.FindStringExact(dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString());
                this.pos = dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: Your trying to select a header. Please select and index.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please Enter Your Name");
            }
            else if (string.IsNullOrEmpty(textBoxContact.Text))
            {
                MessageBox.Show("Please Enter Contact Number");
            }
            else if (string.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Please Select a Picture");
            }
            else if (comboBoxGender.Text == "Gender")
            {
                MessageBox.Show("Please Select a Gender");
            }
            else if (comboBox2Position.Text == "Position")
            {
                MessageBox.Show("Please Select a Position");
            }
            else if (radioButtonParman.Checked == false && radioButtonTempo.Checked == false)
            {
                MessageBox.Show("Please Select an Employee Type");
            }
            else
            {

                if (radioButtonParman.Checked == true)
                {
                    this.Emptype = radioButtonParman.Text;
                }
                else if (radioButtonTempo.Checked == true)
                {
                    this.Emptype = radioButtonTempo.Text;
                }
                else
                {
                    
                }

                string pathOfFolder = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
                //string pathOfFolder2 = pathOfFolder + loggedUser + "_";

                // string ln = Path.Combine(pathOfFolder,
                //     (id.ToString() + "_" + Path.GetFileName(textBoxPath.Text)));

                string ln = Path.Combine(pathOfFolder,
                    (textBoxName.Text + "_" + Path.GetFileName(textBoxPath.Text)));

                // Add in employee
                EmployeeService employeeService = new EmployeeService();
                this.result = employeeService.AddNewEmployee(textBoxName.Text,textBoxContact.Text,comboBoxGender.Text,dateTimePickerDoB.Text, this.Emptype, dateTimePickerHireDate.Text,comboBox2Position.Text, (textBoxName.Text + "_" + Path.GetFileName(textBoxPath.Text)),Convert.ToDecimal(textBoxSalary.Text));
                if (result > 0)
                {
                    MessageBox.Show("New Employee added successfully !!");
                  

                    File.Copy(textBoxPath.Text, ln, true);
                   
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }

                // Add employee by position table
                if (comboBox2Position.Text == "Salesman")
                {
                   // EmployeeService employeeService = new EmployeeService();
                    SalesmanService salesmanService = new SalesmanService();
                    int sl = employeeService.GetEmployeeID(textBoxName.Text, comboBox2Position.Text);
                    int result2 = salesmanService.AddNewSalesman(sl,0,0);
                    if (result2 > 0)
                    {
                        MessageBox.Show("New Employee added successfully !!");
                    }
                    else
                    {
                        MessageBox.Show("Error in adding.");
                    }

                }
                UpdateList();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (pos == "Cashier" || pos == "Manager")
            {
                UserService userService = new UserService();
                int result2 = userService.DeleteUser(id);
                if (result2 > 0)
                {
                
                }
                else
                {
                    MessageBox.Show("Error in deleting.");
                }

                EmployeeService employeeService = new EmployeeService();
                int result = employeeService.RemoveEmployee(id);
                if (result > 0)
                {
                    MessageBox.Show("Employee deleted successfully !!");
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Error in deleting.");
                }
            }
            else if (pos == "Salesman")
            {
                SalesmanService salesmanService = new SalesmanService();
                int result2 = salesmanService.RemoveSalesman(id);
                if (result > 0)
                {
                    EmployeeService employeeService = new EmployeeService();
                    int result = employeeService.RemoveEmployee(id);
                    if (result > 0)
                    {
                        MessageBox.Show("Employee deleted successfully !!");
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting.");
                    }
                }
                else
                {
                    MessageBox.Show("Error in deleting.");
                }
            }
            else
            {
                MessageBox.Show("Can not delete admin!");
            }

            if (imageFileName != "Avatar.png" && result > 0)
            {
                circlePictureBox.Image = Image.FromFile(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\Avatar.png");
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\" + imageFileName);
            }

        }

        private void circleButtonLoginAccess_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Please Enter a Password.");

                }
                else
                {
                    UserService userService = new UserService();
                    int result = userService.AddNewUser(id, textBoxName.Text, textBoxPassword.Text, Emptype, pos);
                    if (result > 0)
                    {
                        MessageBox.Show("New User added successfully !!");

                        // UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding.");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Login Account of this User Already Exists");
                
            }
           
        }

        private void buttonPRF_Click(object sender, EventArgs e)
        {
            //Calling
            NewUserToken newUserToken = new NewUserToken(this);
            newUserToken.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int result;
            string ln;
            if (string.IsNullOrEmpty(textBoxPath.Text))
            {
               

                 EmployeeService employeeService = new EmployeeService();
                 result = employeeService.UpdateExistingEmployee(Convert.ToInt32(labelEmployeeID.Text), textBoxName.Text, textBoxContact.Text, comboBoxGender.Text, dateTimePickerDoB.Text, this.Emptype, dateTimePickerHireDate.Text, comboBox2Position.Text, imageFileName, Convert.ToDecimal(textBoxSalary.Text));

            }
            else
            {
                MessageBox.Show("Story updated successfully !!");
                string pathOfFolder = @"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\";
                //string pathOfFolder2 = pathOfFolder + loggedUser + "_";

                // string ln = Path.Combine(pathOfFolder,
                //    (id.ToString() + "_" + Path.GetFileName(textBoxPath.Text)));

                ln = Path.Combine(pathOfFolder, (textBoxName.Text + "_" + Path.GetFileName(textBoxPath.Text)));
                File.Copy(textBoxPath.Text, ln, true);

                EmployeeService employeeService = new EmployeeService();
                result = employeeService.UpdateExistingEmployee(Convert.ToInt32(labelEmployeeID.Text), textBoxName.Text, textBoxContact.Text, comboBoxGender.Text, dateTimePickerDoB.Text, this.Emptype, dateTimePickerHireDate.Text, comboBox2Position.Text, (textBoxName.Text + "_" + Path.GetFileName(textBoxPath.Text)), Convert.ToDecimal(textBoxSalary.Text));

            }


            if (result > 0)
            {
                MessageBox.Show("Updated");
                UpdateList();
            }
            else
            {
                MessageBox.Show("Error in updating.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            textBoxContact.Text = String.Empty;
            textBoxPath.Text = String.Empty;

            comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact("Gender");
            comboBox2Position.SelectedIndex = comboBoxGender.FindStringExact("Position");


            circlePictureBox.Image = Image.FromFile(@"C:\Users\shart\source\repos\Microcenter\Microcenter\Image\Avatar.png");
            radioButtonParman.Checked = false;
            radioButtonTempo.Checked = false;

            buttonCreateAcc.Enabled = false;
            textBoxPassword.Enabled = false;
            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
