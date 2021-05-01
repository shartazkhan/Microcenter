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
//using Microcenter.Data_Access_Layer.Entities;
//using Microcenter.Data_Access_Layer;
using Microcenter.Presentation_Layer;

namespace Microcenter.PrintingLayer
{
    public partial class NewUserToken : Form
    {
       // EmployeeManagement employeeManagement;
      // private string name;
     //  public int Id;
      // private string position;
      // private string empType;

        public NewUserToken(EmployeeManagement employeeManagement)
        {
            InitializeComponent();
          /*  this.employeeManagement = employeeManagement;
            this.Id = employeeManagement.id;
            this.name = employeeManagement.textBoxName.Text;
            this.position = employeeManagement.comboBox2Position.Text;
            this.empType = employeeManagement.Emptype;

            labelID.Text = this.Id.ToString();
            labelName.Text = this.name;
            labelPosition.Text = this.position;
            labelEmpType.Text = this.empType;


            buttonPrint.Enabled = true;
            //textBoxPassword.Enabled = false;

            / UserService userService = new UserService();
             int result = userService.AddNewUser(Id, name, textBoxPassword.Text, empType, position);
             if (result > 0)
             {
                 MessageBox.Show("New User added successfully !!");

                 //Calling
                 //NewUserToken newUserToken = new NewUserToken(this);
                 //newUserToken.Show();

                 // UpdateList();
             }
             else
             {
                 MessageBox.Show("Error in adding.");
             }

            */
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserToken_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            reportViewerNUT reportViewer = new reportViewerNUT(Convert.ToInt32(textBoxID.Text));
            reportViewer.Show();
        }
    }
}
