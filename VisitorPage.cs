using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class VisitorPage : Form
    {
        private string Sql { get; set; }
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }

        public VisitorPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.autoGenerateToken();
        }


        private void VisitorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Sql = "select * from PrisonerTable where prisonerid = '" + this.cmbPrisonerId.Text+ "' and name = '" + this.txtPrisonerName.Text + "';";
            this.Ds = Dc.ExecuteQuery(Sql);
            if (Ds.Tables[0].Rows.Count == 1 )
            {
                try
                {
                    this.cmbPrisonerId.Text = "";
                    this.Sql = @"insert into VisitorTable 
                    values ('" + this.lblTokenNo.Text + "' ,'" + this.txtVisitorName.Text + "','" + this.txtPrisonerName.Text + "','" + this.cmbPrisonerId.Text + "'," +
                    "'" + this.dtpDate.Text + "','" + this.cmbTimeShift.Text + "','" + this.txtRelation.Text + "','" + this.txtNidNo.Text + "'," +
                    "'" + this.txtMobileNo.Text + "');";
                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Your application has been submitted.");
                        this.Hide();
                        VisitorConfirmationPage visitorConfirmationPage = new VisitorConfirmationPage(this.lblTokenNo.Text, this.txtVisitorName.Text, this.txtPrisonerName.Text, this.cmbPrisonerId.Text, this.cmbTimeShift.Text, this.dtpDate.Text);
                        visitorConfirmationPage.Show();

                    }
                    else
                    {
                        MessageBox.Show("An error has occured during submitting you data\n Please try again.");
                    }
                    //this.PopulateGridView();
                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during submitting\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Prisoner name and Prisoner ID does not match\n");
            }
               
            
        }
        private void autoGenerateToken()
        {
            Random randomNo = new Random();
            int temp = randomNo.Next(9999999, 100000000);
            string tokenNo = temp.ToString();
            this.lblTokenNo.Text = tokenNo;
        }
        private void VisitorPage_Load(object sender, EventArgs e)
        {
            //this.prisonerTableTableAdapter.Fill(this.prisonManagementSystemDataSet.PrisonerTable);
            //this.cmbPrisonerId.Text = "Select Prisoner Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
