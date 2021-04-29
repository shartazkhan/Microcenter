
namespace Microcenter.Presentation_Layer
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ellipseDasboard = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Sales = new Guna.UI2.WinForms.Guna2Button();
            this.buttonInventory = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.toggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ellipseDasboard
            // 
            this.ellipseDasboard.TargetControl = this;
            // 
            // dragControlDashboard
            // 
            this.dragControlDashboard.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1264, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelLeft.Controls.Add(this.guna2CirclePictureBox1);
            this.panelLeft.Controls.Add(this.Sales);
            this.panelLeft.Controls.Add(this.buttonInventory);
            this.panelLeft.Controls.Add(this.buttonEmployee);
            this.panelLeft.Controls.Add(this.buttonLogout);
            this.panelLeft.Location = new System.Drawing.Point(0, 38);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.ShadowDecoration.Parent = this.panelLeft;
            this.panelLeft.Size = new System.Drawing.Size(213, 632);
            this.panelLeft.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(26, 16);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(156, 142);
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Sales
            // 
            this.Sales.BorderColor = System.Drawing.Color.White;
            this.Sales.BorderThickness = 1;
            this.Sales.CheckedState.Parent = this.Sales;
            this.Sales.CustomImages.Parent = this.Sales;
            this.Sales.FillColor = System.Drawing.Color.MediumAquamarine;
            this.Sales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sales.ForeColor = System.Drawing.Color.White;
            this.Sales.HoverState.FillColor = System.Drawing.Color.White;
            this.Sales.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Sales.HoverState.Parent = this.Sales;
            this.Sales.Location = new System.Drawing.Point(-14, 266);
            this.Sales.Name = "Sales";
            this.Sales.ShadowDecoration.Parent = this.Sales;
            this.Sales.Size = new System.Drawing.Size(244, 45);
            this.Sales.TabIndex = 5;
            this.Sales.Text = "Sales History";
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.BorderColor = System.Drawing.Color.White;
            this.buttonInventory.BorderThickness = 1;
            this.buttonInventory.CheckedState.Parent = this.buttonInventory;
            this.buttonInventory.CustomImages.Parent = this.buttonInventory;
            this.buttonInventory.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonInventory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonInventory.ForeColor = System.Drawing.Color.White;
            this.buttonInventory.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonInventory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.buttonInventory.HoverState.Parent = this.buttonInventory;
            this.buttonInventory.Location = new System.Drawing.Point(-14, 222);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.ShadowDecoration.Parent = this.buttonInventory;
            this.buttonInventory.Size = new System.Drawing.Size(244, 45);
            this.buttonInventory.TabIndex = 4;
            this.buttonInventory.Text = "Manage Inventory";
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BorderColor = System.Drawing.Color.White;
            this.buttonEmployee.BorderThickness = 1;
            this.buttonEmployee.CheckedState.Parent = this.buttonEmployee;
            this.buttonEmployee.CustomImages.Parent = this.buttonEmployee;
            this.buttonEmployee.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonEmployee.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonEmployee.HoverState.ForeColor = System.Drawing.Color.Black;
            this.buttonEmployee.HoverState.Parent = this.buttonEmployee;
            this.buttonEmployee.Location = new System.Drawing.Point(-14, 178);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.ShadowDecoration.Parent = this.buttonEmployee;
            this.buttonEmployee.Size = new System.Drawing.Size(244, 45);
            this.buttonEmployee.TabIndex = 3;
            this.buttonEmployee.Text = "Manage Employee";
            // 
            // buttonLogout
            // 
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.buttonLogout.HoverState.Parent = this.buttonLogout;
            this.buttonLogout.Location = new System.Drawing.Point(-8, 576);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(227, 45);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitch1.CheckedState.Parent = this.toggleSwitch1;
            this.toggleSwitch1.Location = new System.Drawing.Point(1143, 21);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.ShadowDecoration.Parent = this.toggleSwitch1;
            this.toggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.toggleSwitch1.TabIndex = 2;
            this.toggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitch1.UncheckedState.Parent = this.toggleSwitch1;
            this.toggleSwitch1.CheckedChanged += new System.EventHandler(this.toggleSwitch1_CheckedChanged);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 669);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ellipseDasboard;
        private Guna.UI2.WinForms.Guna2DragControl dragControlDashboard;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        public Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitch1;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Guna.UI2.WinForms.Guna2Button Sales;
        private Guna.UI2.WinForms.Guna2Button buttonInventory;
        private Guna.UI2.WinForms.Guna2Button buttonEmployee;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}