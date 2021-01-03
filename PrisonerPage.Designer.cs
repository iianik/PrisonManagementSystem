namespace PrisonManagementSystem
{
    partial class PrisonerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrisonerPage));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.txtPrisonerId = new System.Windows.Forms.TextBox();
            this.txtPrisonerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrisonerGridView = new System.Windows.Forms.DataGridView();
            this.prisonerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalcondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencycontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimedetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrancedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMedicalCondition = new System.Windows.Forms.ComboBox();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntranceDate = new System.Windows.Forms.DateTimePicker();
            this.txtCrimeDetails = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(453, 241);
            this.cmbBloodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(259, 25);
            this.cmbBloodGroup.TabIndex = 27;
            this.cmbBloodGroup.Text = "Choose Blood Group";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(453, 214);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(259, 25);
            this.cmbGender.TabIndex = 26;
            this.cmbGender.Text = "Select Gender";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(453, 106);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(259, 20);
            this.dtpDateOfBirth.TabIndex = 25;
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContact.Location = new System.Drawing.Point(453, 324);
            this.txtEmergencyContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(259, 23);
            this.txtEmergencyContact.TabIndex = 21;
            // 
            // txtPrisonerId
            // 
            this.txtPrisonerId.Enabled = false;
            this.txtPrisonerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrisonerId.Location = new System.Drawing.Point(453, 53);
            this.txtPrisonerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrisonerId.Name = "txtPrisonerId";
            this.txtPrisonerId.ReadOnly = true;
            this.txtPrisonerId.Size = new System.Drawing.Size(259, 23);
            this.txtPrisonerId.TabIndex = 24;
            this.txtPrisonerId.TextChanged += new System.EventHandler(this.txtPrisonerId_TextChanged);
            // 
            // txtPrisonerName
            // 
            this.txtPrisonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrisonerName.Location = new System.Drawing.Point(453, 80);
            this.txtPrisonerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrisonerName.Name = "txtPrisonerName";
            this.txtPrisonerName.Size = new System.Drawing.Size(259, 23);
            this.txtPrisonerName.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(280, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Emergency Contact:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(280, 241);
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
            this.label7.Location = new System.Drawing.Point(280, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(279, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prisoner ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prisoner Name:";
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
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisoner";
            // 
            // PrisonerGridView
            // 
            this.PrisonerGridView.AllowUserToAddRows = false;
            this.PrisonerGridView.AllowUserToDeleteRows = false;
            this.PrisonerGridView.BackgroundColor = System.Drawing.Color.White;
            this.PrisonerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrisonerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prisonerid,
            this.name,
            this.dateofbirth,
            this.address,
            this.religion,
            this.gender,
            this.bloodgroup,
            this.maritalstatus,
            this.medicalcondition,
            this.emergencycontact,
            this.crimedetails,
            this.entrancedate,
            this.releasedate});
            this.PrisonerGridView.Location = new System.Drawing.Point(19, 432);
            this.PrisonerGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PrisonerGridView.Name = "PrisonerGridView";
            this.PrisonerGridView.ReadOnly = true;
            this.PrisonerGridView.RowHeadersWidth = 51;
            this.PrisonerGridView.RowTemplate.Height = 24;
            this.PrisonerGridView.Size = new System.Drawing.Size(1040, 228);
            this.PrisonerGridView.TabIndex = 0;
            this.PrisonerGridView.DoubleClick += new System.EventHandler(this.PrisonerGridView_DoubleClick);
            // 
            // prisonerid
            // 
            this.prisonerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prisonerid.DataPropertyName = "prisonerid";
            this.prisonerid.HeaderText = "PRISONER ID";
            this.prisonerid.MinimumWidth = 6;
            this.prisonerid.Name = "prisonerid";
            this.prisonerid.ReadOnly = true;
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
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DATE OF BIRTH";
            this.dateofbirth.MinimumWidth = 6;
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "RELIGION";
            this.religion.MinimumWidth = 6;
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
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
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BLOOD GROUP";
            this.bloodgroup.MinimumWidth = 6;
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // maritalstatus
            // 
            this.maritalstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maritalstatus.DataPropertyName = "maritalstatus";
            this.maritalstatus.HeaderText = "MARITAL STATUS";
            this.maritalstatus.MinimumWidth = 6;
            this.maritalstatus.Name = "maritalstatus";
            this.maritalstatus.ReadOnly = true;
            // 
            // medicalcondition
            // 
            this.medicalcondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicalcondition.DataPropertyName = "medicalcondition";
            this.medicalcondition.HeaderText = "MEDICAL CONDITION";
            this.medicalcondition.MinimumWidth = 6;
            this.medicalcondition.Name = "medicalcondition";
            this.medicalcondition.ReadOnly = true;
            // 
            // emergencycontact
            // 
            this.emergencycontact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emergencycontact.DataPropertyName = "emergencycontact";
            this.emergencycontact.HeaderText = "EMERGENCY CONTACT";
            this.emergencycontact.MinimumWidth = 6;
            this.emergencycontact.Name = "emergencycontact";
            this.emergencycontact.ReadOnly = true;
            // 
            // crimedetails
            // 
            this.crimedetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.crimedetails.DataPropertyName = "crimedetails";
            this.crimedetails.HeaderText = "CRIME DETAILS";
            this.crimedetails.MinimumWidth = 6;
            this.crimedetails.Name = "crimedetails";
            this.crimedetails.ReadOnly = true;
            // 
            // entrancedate
            // 
            this.entrancedate.DataPropertyName = "entrancedate";
            this.entrancedate.HeaderText = "ENTRANCE DATE";
            this.entrancedate.MinimumWidth = 6;
            this.entrancedate.Name = "entrancedate";
            this.entrancedate.ReadOnly = true;
            this.entrancedate.Width = 125;
            // 
            // releasedate
            // 
            this.releasedate.DataPropertyName = "releasedate";
            this.releasedate.HeaderText = "RELEASE DATE";
            this.releasedate.MinimumWidth = 6;
            this.releasedate.Name = "releasedate";
            this.releasedate.ReadOnly = true;
            this.releasedate.Width = 125;
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
            this.panel1.Controls.Add(this.cmbMedicalCondition);
            this.panel1.Controls.Add(this.cmbMaritalStatus);
            this.panel1.Controls.Add(this.cmbBloodGroup);
            this.panel1.Controls.Add(this.cmbReligion);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dtpReleaseDate);
            this.panel1.Controls.Add(this.dtpEntranceDate);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.txtEmergencyContact);
            this.panel1.Controls.Add(this.txtCrimeDetails);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPrisonerId);
            this.panel1.Controls.Add(this.txtPrisonerName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrisonerGridView);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 805);
            this.panel1.TabIndex = 1;
            // 
            // cmbMedicalCondition
            // 
            this.cmbMedicalCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicalCondition.FormattingEnabled = true;
            this.cmbMedicalCondition.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Hospitalized"});
            this.cmbMedicalCondition.Location = new System.Drawing.Point(453, 297);
            this.cmbMedicalCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMedicalCondition.Name = "cmbMedicalCondition";
            this.cmbMedicalCondition.Size = new System.Drawing.Size(259, 25);
            this.cmbMedicalCondition.TabIndex = 27;
            this.cmbMedicalCondition.Text = "Select Medical Condition";
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Unmarried",
            "Married"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(453, 269);
            this.cmbMaritalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(259, 25);
            this.cmbMaritalStatus.TabIndex = 27;
            this.cmbMaritalStatus.Text = "Select Marital Status";
            // 
            // cmbReligion
            // 
            this.cmbReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Cristian",
            "Buddhist",
            "Others"});
            this.cmbReligion.Location = new System.Drawing.Point(453, 186);
            this.cmbReligion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(259, 25);
            this.cmbReligion.TabIndex = 26;
            this.cmbReligion.Text = "Select Religion";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(-368, 75);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(453, 374);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(259, 20);
            this.dtpReleaseDate.TabIndex = 25;
            // 
            // dtpEntranceDate
            // 
            this.dtpEntranceDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntranceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntranceDate.Location = new System.Drawing.Point(453, 351);
            this.dtpEntranceDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntranceDate.Name = "dtpEntranceDate";
            this.dtpEntranceDate.Size = new System.Drawing.Size(259, 20);
            this.dtpEntranceDate.TabIndex = 25;
            // 
            // txtCrimeDetails
            // 
            this.txtCrimeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrimeDetails.Location = new System.Drawing.Point(22, 83);
            this.txtCrimeDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrimeDetails.Multiline = true;
            this.txtCrimeDetails.Name = "txtCrimeDetails";
            this.txtCrimeDetails.Size = new System.Drawing.Size(229, 307);
            this.txtCrimeDetails.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(453, 129);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 53);
            this.txtAddress.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(280, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Madical Condition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(279, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Marital Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(280, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Religion:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-741, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Date Of Birth:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-360, 195);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Date Of Birth:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(280, 373);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Release Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(279, 350);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Entrance Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(67, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Crime Details";
            // 
            // PrisonerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrisonerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrisonerPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.TextBox txtPrisonerId;
        private System.Windows.Forms.TextBox txtPrisonerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PrisonerGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMedicalCondition;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.DateTimePicker dtpEntranceDate;
        private System.Windows.Forms.TextBox txtCrimeDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisonerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalcondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencycontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn crimedetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrancedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedate;
    }
}