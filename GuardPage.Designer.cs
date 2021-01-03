namespace PrisonManagementSystem
{
    partial class GuardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardPage));
            this.mobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbBoodGroup = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPassportNo = new System.Windows.Forms.TextBox();
            this.txtNidNo = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtParAddress = new System.Windows.Forms.TextBox();
            this.txtPreAddress = new System.Windows.Forms.TextBox();
            this.presentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.parmanentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.passportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardPageGridView = new System.Windows.Forms.DataGridView();
            this.nidNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GuardPageGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileNo.DataPropertyName = "mobileno";
            this.mobileNo.HeaderText = "MOBILE NO";
            this.mobileNo.MinimumWidth = 6;
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(871, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 24);
            this.txtSearch.TabIndex = 28;
            // 
            // cmbBoodGroup
            // 
            this.cmbBoodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoodGroup.FormattingEnabled = true;
            this.cmbBoodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBoodGroup.Location = new System.Drawing.Point(418, 243);
            this.cmbBoodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoodGroup.Name = "cmbBoodGroup";
            this.cmbBoodGroup.Size = new System.Drawing.Size(259, 25);
            this.cmbBoodGroup.TabIndex = 27;
            this.cmbBoodGroup.Text = "Choose Blood Group";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(418, 210);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(259, 25);
            this.cmbGender.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(418, 180);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(259, 20);
            this.dtpDateOfBirth.TabIndex = 25;
            // 
            // txtPassportNo
            // 
            this.txtPassportNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportNo.Location = new System.Drawing.Point(418, 384);
            this.txtPassportNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassportNo.Name = "txtPassportNo";
            this.txtPassportNo.Size = new System.Drawing.Size(259, 23);
            this.txtPassportNo.TabIndex = 23;
            // 
            // txtNidNo
            // 
            this.txtNidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNidNo.Location = new System.Drawing.Point(418, 358);
            this.txtNidNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNidNo.Name = "txtNidNo";
            this.txtNidNo.Size = new System.Drawing.Size(259, 23);
            this.txtNidNo.TabIndex = 22;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(418, 331);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(259, 23);
            this.txtMobileNo.TabIndex = 21;
            // 
            // txtParAddress
            // 
            this.txtParAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParAddress.Location = new System.Drawing.Point(418, 303);
            this.txtParAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtParAddress.Name = "txtParAddress";
            this.txtParAddress.Size = new System.Drawing.Size(259, 23);
            this.txtParAddress.TabIndex = 20;
            // 
            // txtPreAddress
            // 
            this.txtPreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreAddress.Location = new System.Drawing.Point(418, 274);
            this.txtPreAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreAddress.Name = "txtPreAddress";
            this.txtPreAddress.Size = new System.Drawing.Size(259, 23);
            this.txtPreAddress.TabIndex = 19;
            // 
            // presentAddress
            // 
            this.presentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentAddress.DataPropertyName = "presentaddress";
            this.presentAddress.HeaderText = "PRESENT ADDRESS";
            this.presentAddress.MinimumWidth = 6;
            this.presentAddress.Name = "presentAddress";
            this.presentAddress.ReadOnly = true;
            // 
            // bloodGroup
            // 
            this.bloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodGroup.DataPropertyName = "bloodgroup";
            this.bloodGroup.HeaderText = "BLOOD GROUP";
            this.bloodGroup.MinimumWidth = 6;
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirth.DataPropertyName = "dateofbirth";
            this.dateOfBirth.HeaderText = "DATE OF BIRTH";
            this.dateOfBirth.MinimumWidth = 6;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "PASSWORD";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(418, 147);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(259, 23);
            this.txtConfirmPassword.TabIndex = 18;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(418, 116);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 23);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(418, 50);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(259, 23);
            this.txtId.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(418, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 23);
            this.txtName.TabIndex = 16;
            // 
            // parmanentAddress
            // 
            this.parmanentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parmanentAddress.DataPropertyName = "parmanentaddress";
            this.parmanentAddress.HeaderText = "PARMANENT ADDRESS";
            this.parmanentAddress.MinimumWidth = 6;
            this.parmanentAddress.Name = "parmanentAddress";
            this.parmanentAddress.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(174, 387);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Passport No:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(174, 360);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "NID No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(174, 333);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mobile No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(174, 306);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Parmanent Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(174, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Present Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(174, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Blood Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(174, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender:";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(174, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Of Birth:";
            // 
            // passportNo
            // 
            this.passportNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passportNo.DataPropertyName = "passportno";
            this.passportNo.HeaderText = "PASSPORT NO";
            this.passportNo.MinimumWidth = 6;
            this.passportNo.Name = "passportNo";
            this.passportNo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(174, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(776, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(776, 172);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(137, 60);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(917, 172);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 60);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(966, 95);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 59);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(871, 95);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 59);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 26);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(496, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guard";
            // 
            // GuardPageGridView
            // 
            this.GuardPageGridView.AllowUserToAddRows = false;
            this.GuardPageGridView.AllowUserToDeleteRows = false;
            this.GuardPageGridView.BackgroundColor = System.Drawing.Color.White;
            this.GuardPageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuardPageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.password,
            this.dateOfBirth,
            this.gender,
            this.bloodGroup,
            this.presentAddress,
            this.parmanentAddress,
            this.mobileNo,
            this.nidNo,
            this.passportNo});
            this.GuardPageGridView.Location = new System.Drawing.Point(19, 433);
            this.GuardPageGridView.Margin = new System.Windows.Forms.Padding(2);
            this.GuardPageGridView.Name = "GuardPageGridView";
            this.GuardPageGridView.ReadOnly = true;
            this.GuardPageGridView.RowHeadersWidth = 51;
            this.GuardPageGridView.RowTemplate.Height = 24;
            this.GuardPageGridView.Size = new System.Drawing.Size(1040, 228);
            this.GuardPageGridView.TabIndex = 0;
            this.GuardPageGridView.DoubleClick += new System.EventHandler(this.GuardPageGridView_DoubleClick);
            // 
            // nidNo
            // 
            this.nidNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nidNo.DataPropertyName = "nidno";
            this.nidNo.HeaderText = "NID NO";
            this.nidNo.MinimumWidth = 6;
            this.nidNo.Name = "nidNo";
            this.nidNo.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(776, 95);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 59);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbBoodGroup);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.txtPassportNo);
            this.panel1.Controls.Add(this.txtNidNo);
            this.panel1.Controls.Add(this.txtMobileNo);
            this.panel1.Controls.Add(this.txtParAddress);
            this.panel1.Controls.Add(this.txtPreAddress);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GuardPageGridView);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 805);
            this.panel1.TabIndex = 1;
            // 
            // GuardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GuardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuardPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GuardPageGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbBoodGroup;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPassportNo;
        private System.Windows.Forms.TextBox txtNidNo;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtParAddress;
        private System.Windows.Forms.TextBox txtPreAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmanentAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GuardPageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}