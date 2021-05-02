
namespace Microcenter.Presentation_Layer
{
    partial class EmployeeManagement
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
            this.elipseEmployee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlEmployee = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox2Position = new Guna.UI2.WinForms.Guna2ComboBox();
            this.radioButtonParman = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonTempo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textBoxPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.circlePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDoB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateAcc = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonPRF = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePickerDoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseEmployee
            // 
            this.elipseEmployee.TargetControl = this;
            // 
            // dragControlEmployee
            // 
            this.dragControlEmployee.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1185, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.CheckedState.Parent = this.buttonBack;
            this.buttonBack.CustomImages.Parent = this.buttonBack;
            this.buttonBack.FillColor = System.Drawing.Color.LightCoral;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.buttonBack.HoverState.Parent = this.buttonBack;
            this.buttonBack.Location = new System.Drawing.Point(21, 52);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.ShadowDecoration.Parent = this.buttonBack;
            this.buttonBack.Size = new System.Drawing.Size(122, 36);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridViewEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployee.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEmployee.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 326);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersVisible = false;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1242, 308);
            this.dataGridViewEmployee.TabIndex = 5;
            this.dataGridViewEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewEmployee.ThemeStyle.ReadOnly = true;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderRadius = 6;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(490, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(212, 36);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxContact
            // 
            this.textBoxContact.BorderRadius = 6;
            this.textBoxContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContact.DefaultText = "";
            this.textBoxContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxContact.DisabledState.Parent = this.textBoxContact;
            this.textBoxContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxContact.FocusedState.Parent = this.textBoxContact;
            this.textBoxContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxContact.HoverState.Parent = this.textBoxContact;
            this.textBoxContact.Location = new System.Drawing.Point(490, 87);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.PasswordChar = '\0';
            this.textBoxContact.PlaceholderText = "Contact Number";
            this.textBoxContact.SelectedText = "";
            this.textBoxContact.ShadowDecoration.Parent = this.textBoxContact;
            this.textBoxContact.Size = new System.Drawing.Size(212, 36);
            this.textBoxContact.TabIndex = 7;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGender.BorderRadius = 6;
            this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxGender.FocusedState.Parent = this.comboBoxGender;
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.HoverState.Parent = this.comboBoxGender;
            this.comboBoxGender.ItemHeight = 30;
            this.comboBoxGender.ItemsAppearance.Parent = this.comboBoxGender;
            this.comboBoxGender.Location = new System.Drawing.Point(708, 45);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.ShadowDecoration.Parent = this.comboBoxGender;
            this.comboBoxGender.Size = new System.Drawing.Size(212, 36);
            this.comboBoxGender.TabIndex = 8;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBox2Position
            // 
            this.comboBox2Position.BackColor = System.Drawing.Color.Transparent;
            this.comboBox2Position.BorderRadius = 6;
            this.comboBox2Position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2Position.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox2Position.FocusedState.Parent = this.comboBox2Position;
            this.comboBox2Position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2Position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox2Position.FormattingEnabled = true;
            this.comboBox2Position.HoverState.Parent = this.comboBox2Position;
            this.comboBox2Position.ItemHeight = 30;
            this.comboBox2Position.ItemsAppearance.Parent = this.comboBox2Position;
            this.comboBox2Position.Location = new System.Drawing.Point(708, 87);
            this.comboBox2Position.Name = "comboBox2Position";
            this.comboBox2Position.ShadowDecoration.Parent = this.comboBox2Position;
            this.comboBox2Position.Size = new System.Drawing.Size(212, 36);
            this.comboBox2Position.TabIndex = 11;
            this.comboBox2Position.SelectedIndexChanged += new System.EventHandler(this.comboBox2Position_SelectedIndexChanged);
            // 
            // radioButtonParman
            // 
            this.radioButtonParman.AutoSize = true;
            this.radioButtonParman.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonParman.CheckedState.BorderThickness = 0;
            this.radioButtonParman.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonParman.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonParman.CheckedState.InnerOffset = -4;
            this.radioButtonParman.Location = new System.Drawing.Point(721, 203);
            this.radioButtonParman.Name = "radioButtonParman";
            this.radioButtonParman.Size = new System.Drawing.Size(76, 17);
            this.radioButtonParman.TabIndex = 12;
            this.radioButtonParman.TabStop = true;
            this.radioButtonParman.Text = "Permanent";
            this.radioButtonParman.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonParman.UncheckedState.BorderThickness = 2;
            this.radioButtonParman.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonParman.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonParman.UseVisualStyleBackColor = true;
            // 
            // radioButtonTempo
            // 
            this.radioButtonTempo.AutoSize = true;
            this.radioButtonTempo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTempo.CheckedState.BorderThickness = 0;
            this.radioButtonTempo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTempo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonTempo.CheckedState.InnerOffset = -4;
            this.radioButtonTempo.Location = new System.Drawing.Point(803, 203);
            this.radioButtonTempo.Name = "radioButtonTempo";
            this.radioButtonTempo.Size = new System.Drawing.Size(75, 17);
            this.radioButtonTempo.TabIndex = 13;
            this.radioButtonTempo.TabStop = true;
            this.radioButtonTempo.Text = "Temporary";
            this.radioButtonTempo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTempo.UncheckedState.BorderThickness = 2;
            this.radioButtonTempo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonTempo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonTempo.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.BorderRadius = 6;
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.DefaultText = "";
            this.textBoxPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPath.DisabledState.Parent = this.textBoxPath;
            this.textBoxPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPath.FocusedState.Parent = this.textBoxPath;
            this.textBoxPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPath.HoverState.Parent = this.textBoxPath;
            this.textBoxPath.Location = new System.Drawing.Point(284, 241);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.PasswordChar = '\0';
            this.textBoxPath.PlaceholderText = "";
            this.textBoxPath.SelectedText = "";
            this.textBoxPath.ShadowDecoration.Parent = this.textBoxPath;
            this.textBoxPath.Size = new System.Drawing.Size(102, 36);
            this.textBoxPath.TabIndex = 14;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.CheckedState.Parent = this.buttonBrowse;
            this.buttonBrowse.CustomImages.Parent = this.buttonBrowse;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.HoverState.Parent = this.buttonBrowse;
            this.buttonBrowse.Location = new System.Drawing.Point(392, 241);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.ShadowDecoration.Parent = this.buttonBrowse;
            this.buttonBrowse.Size = new System.Drawing.Size(68, 36);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // circlePictureBox
            // 
            this.circlePictureBox.Location = new System.Drawing.Point(284, 45);
            this.circlePictureBox.Name = "circlePictureBox";
            this.circlePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBox.ShadowDecoration.Parent = this.circlePictureBox;
            this.circlePictureBox.Size = new System.Drawing.Size(176, 177);
            this.circlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBox.TabIndex = 16;
            this.circlePictureBox.TabStop = false;
            this.circlePictureBox.Click += new System.EventHandler(this.circlePictureBox_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(935, 45);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(176, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.CheckedState.Parent = this.buttonUpdate;
            this.buttonUpdate.CustomImages.Parent = this.buttonUpdate;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.HoverState.Parent = this.buttonUpdate;
            this.buttonUpdate.Location = new System.Drawing.Point(935, 91);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.ShadowDecoration.Parent = this.buttonUpdate;
            this.buttonUpdate.Size = new System.Drawing.Size(176, 36);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FillColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.Location = new System.Drawing.Point(935, 139);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(176, 36);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(720, 187);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 13);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Employee Type: ";
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Location = new System.Drawing.Point(489, 128);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(74, 13);
            this.labelDoB.TabIndex = 21;
            this.labelDoB.Text = "Date of birth:  ";
            this.labelDoB.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hire Date:  ";
            // 
            // buttonClear
            // 
            this.buttonClear.CheckedState.Parent = this.buttonClear;
            this.buttonClear.CustomImages.Parent = this.buttonClear;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.HoverState.Parent = this.buttonClear;
            this.buttonClear.Location = new System.Drawing.Point(935, 187);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.ShadowDecoration.Parent = this.buttonClear;
            this.buttonClear.Size = new System.Drawing.Size(176, 36);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(348, 29);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(25, 13);
            this.labelEmployeeID.TabIndex = 27;
            this.labelEmployeeID.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Employee ID:";
            // 
            // buttonCreateAcc
            // 
            this.buttonCreateAcc.CheckedState.Parent = this.buttonCreateAcc;
            this.buttonCreateAcc.CustomImages.Parent = this.buttonCreateAcc;
            this.buttonCreateAcc.Enabled = false;
            this.buttonCreateAcc.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCreateAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCreateAcc.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAcc.HoverState.Parent = this.buttonCreateAcc;
            this.buttonCreateAcc.Location = new System.Drawing.Point(490, 241);
            this.buttonCreateAcc.Name = "buttonCreateAcc";
            this.buttonCreateAcc.ShadowDecoration.Parent = this.buttonCreateAcc;
            this.buttonCreateAcc.Size = new System.Drawing.Size(162, 36);
            this.buttonCreateAcc.TabIndex = 30;
            this.buttonCreateAcc.Text = "Create Login Account";
            this.buttonCreateAcc.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderRadius = 6;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(490, 184);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(195, 38);
            this.textBoxPassword.TabIndex = 32;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonPRF
            // 
            this.buttonPRF.CheckedState.Parent = this.buttonPRF;
            this.buttonPRF.CustomImages.Parent = this.buttonPRF;
            this.buttonPRF.Enabled = false;
            this.buttonPRF.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPRF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPRF.ForeColor = System.Drawing.Color.White;
            this.buttonPRF.HoverState.Parent = this.buttonPRF;
            this.buttonPRF.Location = new System.Drawing.Point(675, 241);
            this.buttonPRF.Name = "buttonPRF";
            this.buttonPRF.ShadowDecoration.Parent = this.buttonPRF;
            this.buttonPRF.Size = new System.Drawing.Size(122, 36);
            this.buttonPRF.TabIndex = 33;
            this.buttonPRF.Text = "Print Login Form";
            this.buttonPRF.Click += new System.EventHandler(this.buttonPRF_Click);
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.BorderRadius = 5;
            this.dateTimePickerDoB.CheckedState.Parent = this.dateTimePickerDoB;
            this.dateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDoB.HoverState.Parent = this.dateTimePickerDoB;
            this.dateTimePickerDoB.Location = new System.Drawing.Point(490, 144);
            this.dateTimePickerDoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.ShadowDecoration.Parent = this.dateTimePickerDoB;
            this.dateTimePickerDoB.Size = new System.Drawing.Size(212, 27);
            this.dateTimePickerDoB.TabIndex = 34;
            this.dateTimePickerDoB.Value = new System.DateTime(2021, 5, 1, 12, 52, 5, 352);
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.BorderRadius = 5;
            this.dateTimePickerHireDate.CheckedState.Parent = this.dateTimePickerHireDate;
            this.dateTimePickerHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerHireDate.HoverState.Parent = this.dateTimePickerHireDate;
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(708, 144);
            this.dateTimePickerHireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerHireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.ShadowDecoration.Parent = this.dateTimePickerHireDate;
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(212, 27);
            this.dateTimePickerHireDate.TabIndex = 35;
            this.dateTimePickerHireDate.Value = new System.DateTime(2021, 5, 1, 12, 52, 21, 164);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 634);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.buttonPRF);
            this.Controls.Add(this.buttonCreateAcc);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDoB);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.circlePictureBox);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.radioButtonTempo);
            this.Controls.Add(this.radioButtonParman);
            this.Controls.Add(this.comboBox2Position);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseEmployee;
        private Guna.UI2.WinForms.Guna2DragControl dragControlEmployee;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonParman;
        public Guna.UI2.WinForms.Guna2ComboBox comboBox2Position;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGender;
        private Guna.UI2.WinForms.Guna2TextBox textBoxContact;
        public Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label labelType;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBox;
        private Guna.UI2.WinForms.Guna2Button buttonBrowse;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPath;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTempo;
        private System.Windows.Forms.Label labelDoB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonCreateAcc;
        public Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2Button buttonPRF;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerHireDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerDoB;
    }
}