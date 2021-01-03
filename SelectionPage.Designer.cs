namespace PrisonManagementSystem
{
    partial class SelectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.btnVisitorInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select First";
            // 
            // btnPrisoner
            // 
            this.btnPrisoner.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrisoner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrisoner.Location = new System.Drawing.Point(103, 98);
            this.btnPrisoner.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrisoner.Name = "btnPrisoner";
            this.btnPrisoner.Size = new System.Drawing.Size(94, 46);
            this.btnPrisoner.TabIndex = 1;
            this.btnPrisoner.Text = "Prisoner";
            this.btnPrisoner.UseVisualStyleBackColor = false;
            this.btnPrisoner.Click += new System.EventHandler(this.btnPrisoner_Click);
            // 
            // btnGuard
            // 
            this.btnGuard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuard.Location = new System.Drawing.Point(103, 171);
            this.btnGuard.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(94, 46);
            this.btnGuard.TabIndex = 1;
            this.btnGuard.Text = "Guard";
            this.btnGuard.UseVisualStyleBackColor = true;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // btnVisitorInfo
            // 
            this.btnVisitorInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorInfo.Location = new System.Drawing.Point(103, 242);
            this.btnVisitorInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisitorInfo.Name = "btnVisitorInfo";
            this.btnVisitorInfo.Size = new System.Drawing.Size(94, 46);
            this.btnVisitorInfo.TabIndex = 1;
            this.btnVisitorInfo.Text = "Visitor INFO";
            this.btnVisitorInfo.UseVisualStyleBackColor = true;
            this.btnVisitorInfo.Click += new System.EventHandler(this.btnVisitorInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 422);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVisitorInfo);
            this.Controls.Add(this.btnGuard);
            this.Controls.Add(this.btnPrisoner);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management Sysytem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectionPage_FormClosed);
            this.Load += new System.EventHandler(this.SelectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Button btnGuard;
        private System.Windows.Forms.Button btnVisitorInfo;
        private System.Windows.Forms.Button btnBack;
    }
}