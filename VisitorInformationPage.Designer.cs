namespace PrisonManagementSystem
{
    partial class VisitorInformationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorInformationPage));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitorPageGridView = new System.Windows.Forms.DataGridView();
            this.tokenno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisonername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisonerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofvisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorPageGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(881, 83);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 27);
            this.txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(787, 83);
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
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(22, 83);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(105, 26);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(141, 83);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 26);
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
            this.label1.Location = new System.Drawing.Point(427, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitor Information";
            // 
            // VisitorPageGridView
            // 
            this.VisitorPageGridView.AllowUserToAddRows = false;
            this.VisitorPageGridView.AllowUserToDeleteRows = false;
            this.VisitorPageGridView.BackgroundColor = System.Drawing.Color.White;
            this.VisitorPageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorPageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tokenno,
            this.visitorname,
            this.prisonername,
            this.prisonerid,
            this.dateofvisit,
            this.timeshift,
            this.relationship,
            this.nidno,
            this.mobileno});
            this.VisitorPageGridView.GridColor = System.Drawing.Color.White;
            this.VisitorPageGridView.Location = new System.Drawing.Point(22, 122);
            this.VisitorPageGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VisitorPageGridView.Name = "VisitorPageGridView";
            this.VisitorPageGridView.ReadOnly = true;
            this.VisitorPageGridView.RowHeadersWidth = 51;
            this.VisitorPageGridView.RowTemplate.Height = 24;
            this.VisitorPageGridView.Size = new System.Drawing.Size(1040, 539);
            this.VisitorPageGridView.TabIndex = 0;
            // 
            // tokenno
            // 
            this.tokenno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tokenno.DataPropertyName = "tokenno";
            this.tokenno.HeaderText = "TOKEN NO";
            this.tokenno.MinimumWidth = 6;
            this.tokenno.Name = "tokenno";
            this.tokenno.ReadOnly = true;
            // 
            // visitorname
            // 
            this.visitorname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.visitorname.DataPropertyName = "visitorname";
            this.visitorname.HeaderText = "VISITOR NAME";
            this.visitorname.MinimumWidth = 6;
            this.visitorname.Name = "visitorname";
            this.visitorname.ReadOnly = true;
            // 
            // prisonername
            // 
            this.prisonername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prisonername.DataPropertyName = "prisonername";
            this.prisonername.HeaderText = "PRISONER NAME";
            this.prisonername.MinimumWidth = 6;
            this.prisonername.Name = "prisonername";
            this.prisonername.ReadOnly = true;
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
            // dateofvisit
            // 
            this.dateofvisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofvisit.DataPropertyName = "dateofvisit";
            this.dateofvisit.HeaderText = "DATE OF VISIT";
            this.dateofvisit.MinimumWidth = 6;
            this.dateofvisit.Name = "dateofvisit";
            this.dateofvisit.ReadOnly = true;
            // 
            // timeshift
            // 
            this.timeshift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeshift.DataPropertyName = "timeshift";
            this.timeshift.HeaderText = "TIME";
            this.timeshift.MinimumWidth = 6;
            this.timeshift.Name = "timeshift";
            this.timeshift.ReadOnly = true;
            // 
            // relationship
            // 
            this.relationship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.relationship.DataPropertyName = "relationship";
            this.relationship.HeaderText = "RELATIONSHIP";
            this.relationship.MinimumWidth = 6;
            this.relationship.Name = "relationship";
            this.relationship.ReadOnly = true;
            // 
            // nidno
            // 
            this.nidno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nidno.DataPropertyName = "nidno";
            this.nidno.HeaderText = "NID NO";
            this.nidno.MinimumWidth = 6;
            this.nidno.Name = "nidno";
            this.nidno.ReadOnly = true;
            // 
            // mobileno
            // 
            this.mobileno.DataPropertyName = "mobileno";
            this.mobileno.HeaderText = "MOBILE NO";
            this.mobileno.MinimumWidth = 6;
            this.mobileno.Name = "mobileno";
            this.mobileno.ReadOnly = true;
            this.mobileno.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::PrisonManagementSystem.Properties.Resources.CoverPage;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VisitorPageGridView);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 805);
            this.panel1.TabIndex = 1;
            // 
            // VisitorInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VisitorInformationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitorInformationPage_FormClosed);
            this.Load += new System.EventHandler(this.VisitorInformationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorPageGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VisitorPageGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenno;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisonername;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisonerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofvisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeshift;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
    }
}