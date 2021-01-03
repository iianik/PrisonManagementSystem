namespace PrisonManagementSystem
{
    partial class VisitorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPrisonerId = new System.Windows.Forms.ComboBox();
            this.prisonerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTimeShift = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtNidNo = new System.Windows.Forms.TextBox();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.txtPrisonerName = new System.Windows.Forms.TextBox();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonerTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 805);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 26);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPrisonerId);
            this.panel2.Controls.Add(this.cmbTimeShift);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.txtMobileNo);
            this.panel2.Controls.Add(this.txtNidNo);
            this.panel2.Controls.Add(this.txtRelation);
            this.panel2.Controls.Add(this.txtPrisonerName);
            this.panel2.Controls.Add(this.txtVisitorName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTokenNo);
            this.panel2.Controls.Add(this.lblToken);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(189, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 446);
            this.panel2.TabIndex = 3;
            // 
            // cmbPrisonerId
            // 
            this.cmbPrisonerId.DataSource = this.prisonerTableBindingSource;
            this.cmbPrisonerId.DisplayMember = "prisonerid";
            this.cmbPrisonerId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPrisonerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrisonerId.FormattingEnabled = true;
            this.cmbPrisonerId.Location = new System.Drawing.Point(347, 179);
            this.cmbPrisonerId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrisonerId.Name = "cmbPrisonerId";
            this.cmbPrisonerId.Size = new System.Drawing.Size(259, 30);
            this.cmbPrisonerId.TabIndex = 50;
            this.cmbPrisonerId.ValueMember = "prisonerid";
            // 
            // prisonerTableBindingSource
            // 
            this.prisonerTableBindingSource.DataMember = "PrisonerTable";
            // 
            // cmbTimeShift
            // 
            this.cmbTimeShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimeShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeShift.FormattingEnabled = true;
            this.cmbTimeShift.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbTimeShift.Items.AddRange(new object[] {
            "10.00 AM - 11.30 PM",
            "12.00 PM - 01.30 PM",
            "02.00 PM - 03.30 PM",
            "04.00 PM - 05.30 PM"});
            this.cmbTimeShift.Location = new System.Drawing.Point(347, 255);
            this.cmbTimeShift.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTimeShift.Name = "cmbTimeShift";
            this.cmbTimeShift.Size = new System.Drawing.Size(259, 30);
            this.cmbTimeShift.TabIndex = 50;
            this.cmbTimeShift.Text = "Select Time Shift";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(347, 217);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(259, 28);
            this.dtpDate.TabIndex = 49;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(347, 372);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(259, 28);
            this.txtMobileNo.TabIndex = 45;
            // 
            // txtNidNo
            // 
            this.txtNidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNidNo.Location = new System.Drawing.Point(347, 334);
            this.txtNidNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNidNo.Name = "txtNidNo";
            this.txtNidNo.Size = new System.Drawing.Size(259, 28);
            this.txtNidNo.TabIndex = 44;
            // 
            // txtRelation
            // 
            this.txtRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelation.Location = new System.Drawing.Point(347, 296);
            this.txtRelation.Margin = new System.Windows.Forms.Padding(2);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(259, 28);
            this.txtRelation.TabIndex = 43;
            // 
            // txtPrisonerName
            // 
            this.txtPrisonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrisonerName.Location = new System.Drawing.Point(347, 140);
            this.txtPrisonerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrisonerName.Name = "txtPrisonerName";
            this.txtPrisonerName.Size = new System.Drawing.Size(259, 28);
            this.txtPrisonerName.TabIndex = 40;
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorName.Location = new System.Drawing.Point(347, 100);
            this.txtVisitorName.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.Size = new System.Drawing.Size(259, 28);
            this.txtVisitorName.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(104, 375);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Your Mobile No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(104, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Your NID No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(104, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "Relation With Prisoner:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Select Time Shift:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prisoner ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prisoner Name:";
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.AutoSize = true;
            this.lblTokenNo.BackColor = System.Drawing.Color.White;
            this.lblTokenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.Black;
            this.lblTokenNo.Location = new System.Drawing.Point(342, 54);
            this.lblTokenNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(187, 26);
            this.lblTokenNo.TabIndex = 28;
            this.lblTokenNo.Text = "                         ";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.BackColor = System.Drawing.Color.White;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.ForeColor = System.Drawing.Color.Black;
            this.lblToken.Location = new System.Drawing.Point(224, 54);
            this.lblToken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(120, 26);
            this.lblToken.TabIndex = 28;
            this.lblToken.Text = "Token No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(224, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Please Fill Up the Form.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Your Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(471, 538);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 60);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // VisitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VisitorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitorPage_FormClosed);
            this.Load += new System.EventHandler(this.VisitorPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonerTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTimeShift;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtNidNo;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrisonerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrisonerId;
        private System.Windows.Forms.Label lblTokenNo;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.BindingSource prisonerTableBindingSource;
        private System.Windows.Forms.Button btnBack;
    }
}