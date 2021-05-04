
namespace Microcenter.Presentation_Layer
{
    partial class CashierDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipseCashierDashboard = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlCashierDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dataGridViewINV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PruductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCategoryName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSalesmanID = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxInvoiceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.labelTotal = new Guna.UI.WinForms.GunaLabel();
            this.comboBoxSalemanID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINV)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseCashierDashboard
            // 
            this.elipseCashierDashboard.TargetControl = this;
            // 
            // dragControlCashierDashboard
            // 
            this.dragControlCashierDashboard.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1186, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // dataGridViewINV
            // 
            this.dataGridViewINV.AllowUserToAddRows = false;
            this.dataGridViewINV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewINV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewINV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewINV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewINV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewINV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewINV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewINV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewINV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.PruductName,
            this.Quantity,
            this.Discount,
            this.Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewINV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewINV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewINV.EnableHeadersVisualStyles = false;
            this.dataGridViewINV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewINV.Location = new System.Drawing.Point(0, 245);
            this.dataGridViewINV.Name = "dataGridViewINV";
            this.dataGridViewINV.ReadOnly = true;
            this.dataGridViewINV.RowHeadersVisible = false;
            this.dataGridViewINV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewINV.Size = new System.Drawing.Size(1243, 375);
            this.dataGridViewINV.TabIndex = 1;
            this.dataGridViewINV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewINV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewINV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewINV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewINV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewINV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewINV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewINV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewINV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewINV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewINV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewINV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewINV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewINV.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridViewINV.ThemeStyle.ReadOnly = true;
            this.dataGridViewINV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewINV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewINV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewINV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewINV.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewINV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewINV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewINV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // PruductName
            // 
            this.PruductName.HeaderText = "Pruduct Name";
            this.PruductName.Name = "PruductName";
            this.PruductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCategoryName.BorderRadius = 6;
            this.comboBoxCategoryName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryName.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxCategoryName.FocusedState.Parent = this.comboBoxCategoryName;
            this.comboBoxCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.HoverState.Parent = this.comboBoxCategoryName;
            this.comboBoxCategoryName.ItemHeight = 30;
            this.comboBoxCategoryName.ItemsAppearance.Parent = this.comboBoxCategoryName;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(340, 71);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.ShadowDecoration.Parent = this.comboBoxCategoryName;
            this.comboBoxCategoryName.Size = new System.Drawing.Size(257, 36);
            this.comboBoxCategoryName.TabIndex = 2;
            this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxProductName.BorderRadius = 6;
            this.comboBoxProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductName.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxProductName.FocusedState.Parent = this.comboBoxProductName;
            this.comboBoxProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.HoverState.Parent = this.comboBoxProductName;
            this.comboBoxProductName.ItemHeight = 30;
            this.comboBoxProductName.ItemsAppearance.Parent = this.comboBoxProductName;
            this.comboBoxProductName.Location = new System.Drawing.Point(620, 71);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.ShadowDecoration.Parent = this.comboBoxProductName;
            this.comboBoxProductName.Size = new System.Drawing.Size(193, 36);
            this.comboBoxProductName.TabIndex = 3;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BorderRadius = 6;
            this.textBoxUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit.DefaultText = "1";
            this.textBoxUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUnit.DisabledState.Parent = this.textBoxUnit;
            this.textBoxUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUnit.FocusedState.Parent = this.textBoxUnit;
            this.textBoxUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUnit.HoverState.Parent = this.textBoxUnit;
            this.textBoxUnit.Location = new System.Drawing.Point(249, 130);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.PasswordChar = '\0';
            this.textBoxUnit.PlaceholderText = "";
            this.textBoxUnit.SelectedText = "";
            this.textBoxUnit.SelectionStart = 1;
            this.textBoxUnit.ShadowDecoration.Parent = this.textBoxUnit;
            this.textBoxUnit.Size = new System.Drawing.Size(92, 36);
            this.textBoxUnit.TabIndex = 4;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BorderRadius = 6;
            this.textBoxDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDiscount.DefaultText = "0";
            this.textBoxDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiscount.DisabledState.Parent = this.textBoxDiscount;
            this.textBoxDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiscount.FocusedState.Parent = this.textBoxDiscount;
            this.textBoxDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiscount.HoverState.Parent = this.textBoxDiscount;
            this.textBoxDiscount.Location = new System.Drawing.Point(486, 130);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.PasswordChar = '\0';
            this.textBoxDiscount.PlaceholderText = "";
            this.textBoxDiscount.SelectedText = "";
            this.textBoxDiscount.SelectionStart = 1;
            this.textBoxDiscount.ShadowDecoration.Parent = this.textBoxDiscount;
            this.textBoxDiscount.Size = new System.Drawing.Size(119, 36);
            this.textBoxDiscount.TabIndex = 6;
            // 
            // labelSalesmanID
            // 
            this.labelSalesmanID.AutoSize = true;
            this.labelSalesmanID.Location = new System.Drawing.Point(249, 55);
            this.labelSalesmanID.Name = "labelSalesmanID";
            this.labelSalesmanID.Size = new System.Drawing.Size(64, 13);
            this.labelSalesmanID.TabIndex = 7;
            this.labelSalesmanID.Text = "SalesmanID";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(340, 55);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(80, 13);
            this.labelCategoryName.TabIndex = 8;
            this.labelCategoryName.Text = "Category Name";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(621, 55);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 9;
            this.labelProductName.Text = "Product Name";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(249, 114);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(26, 13);
            this.labelUnit.TabIndex = 10;
            this.labelUnit.Text = "Unit";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(486, 113);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(49, 13);
            this.labelDiscount.TabIndex = 11;
            this.labelDiscount.Text = "Discount";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 6;
            this.buttonAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(918, 47);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(193, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add to Cart";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BorderRadius = 6;
            this.buttonRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buttonRemove.CheckedState.Parent = this.buttonRemove;
            this.buttonRemove.CustomImages.Parent = this.buttonRemove;
            this.buttonRemove.Enabled = false;
            this.buttonRemove.FillColor = System.Drawing.Color.LightCoral;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.HoverState.Parent = this.buttonRemove;
            this.buttonRemove.Location = new System.Drawing.Point(918, 88);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.ShadowDecoration.Parent = this.buttonRemove;
            this.buttonRemove.Size = new System.Drawing.Size(193, 35);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove form Cart";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BorderRadius = 6;
            this.buttonConfirm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buttonConfirm.CheckedState.Parent = this.buttonConfirm;
            this.buttonConfirm.CustomImages.Parent = this.buttonConfirm;
            this.buttonConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.HoverState.Parent = this.buttonConfirm;
            this.buttonConfirm.Location = new System.Drawing.Point(918, 170);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.ShadowDecoration.Parent = this.buttonConfirm;
            this.buttonConfirm.Size = new System.Drawing.Size(193, 35);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BorderRadius = 6;
            this.buttonClear.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buttonClear.CheckedState.Parent = this.buttonClear;
            this.buttonClear.CustomImages.Parent = this.buttonClear;
            this.buttonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.HoverState.Parent = this.buttonClear;
            this.buttonClear.Location = new System.Drawing.Point(918, 129);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.ShadowDecoration.Parent = this.buttonClear;
            this.buttonClear.Size = new System.Drawing.Size(193, 35);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear Cart";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.BorderRadius = 6;
            this.textBoxInvoiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInvoiceID.DefaultText = "";
            this.textBoxInvoiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxInvoiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxInvoiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInvoiceID.DisabledState.Parent = this.textBoxInvoiceID;
            this.textBoxInvoiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInvoiceID.Enabled = false;
            this.textBoxInvoiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInvoiceID.FocusedState.Parent = this.textBoxInvoiceID;
            this.textBoxInvoiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInvoiceID.HoverState.Parent = this.textBoxInvoiceID;
            this.textBoxInvoiceID.Location = new System.Drawing.Point(618, 130);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.PasswordChar = '\0';
            this.textBoxInvoiceID.PlaceholderText = "";
            this.textBoxInvoiceID.SelectedText = "";
            this.textBoxInvoiceID.ShadowDecoration.Parent = this.textBoxInvoiceID;
            this.textBoxInvoiceID.Size = new System.Drawing.Size(119, 36);
            this.textBoxInvoiceID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Invoice ID";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(354, 114);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderRadius = 6;
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.DefaultText = "";
            this.textBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.DisabledState.Parent = this.textBoxPrice;
            this.textBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.FocusedState.Parent = this.textBoxPrice;
            this.textBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.HoverState.Parent = this.textBoxPrice;
            this.textBoxPrice.Location = new System.Drawing.Point(354, 130);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = '\0';
            this.textBoxPrice.PlaceholderText = "";
            this.textBoxPrice.SelectedText = "";
            this.textBoxPrice.ShadowDecoration.Parent = this.textBoxPrice;
            this.textBoxPrice.Size = new System.Drawing.Size(119, 36);
            this.textBoxPrice.TabIndex = 19;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(20, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 17);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BorderColor = System.Drawing.Color.LightGray;
            this.buttonLogout.BorderRadius = 6;
            this.buttonLogout.BorderThickness = 1;
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.HoverState.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonLogout.HoverState.Parent = this.buttonLogout;
            this.buttonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLogout.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonLogout.Location = new System.Drawing.Point(12, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(122, 43);
            this.buttonLogout.TabIndex = 22;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(252, 190);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Total: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTotal.Location = new System.Drawing.Point(285, 190);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(22, 15);
            this.labelTotal.TabIndex = 24;
            this.labelTotal.Text = "0.0";
            // 
            // comboBoxSalemanID
            // 
            this.comboBoxSalemanID.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSalemanID.BorderRadius = 6;
            this.comboBoxSalemanID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSalemanID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalemanID.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxSalemanID.FocusedState.Parent = this.comboBoxSalemanID;
            this.comboBoxSalemanID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSalemanID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSalemanID.FormattingEnabled = true;
            this.comboBoxSalemanID.HoverState.Parent = this.comboBoxSalemanID;
            this.comboBoxSalemanID.ItemHeight = 30;
            this.comboBoxSalemanID.ItemsAppearance.Parent = this.comboBoxSalemanID;
            this.comboBoxSalemanID.Location = new System.Drawing.Point(249, 71);
            this.comboBoxSalemanID.Name = "comboBoxSalemanID";
            this.comboBoxSalemanID.ShadowDecoration.Parent = this.comboBoxSalemanID;
            this.comboBoxSalemanID.Size = new System.Drawing.Size(79, 36);
            this.comboBoxSalemanID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(1183, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "©shartaz";
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSalemanID);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInvoiceID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.labelSalesmanID);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.comboBoxCategoryName);
            this.Controls.Add(this.dataGridViewINV);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierDashboard_FormClosing);
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseCashierDashboard;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl dragControlCashierDashboard;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewINV;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDiscount;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUnit;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxProductName;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxInvoiceID;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private Guna.UI2.WinForms.Guna2Button buttonConfirm;
        private Guna.UI2.WinForms.Guna2Button buttonRemove;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelSalesmanID;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PruductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private System.Windows.Forms.Label labelName;
        private Guna.UI.WinForms.GunaLabel labelTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSalemanID;
        private System.Windows.Forms.Label label2;
    }
}