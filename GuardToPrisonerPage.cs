using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class GuardToPrisonerPage : Form
    {
        private string Sql { get; set; }
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        public GuardToPrisonerPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";

            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from PrisonerTable order by prisonerid;")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.PrisonerGridView.AutoGenerateColumns = false;
            this.PrisonerGridView.DataSource = this.Ds.Tables[0];
        }

        private void GuardToPrisonerPage_Load(object sender, EventArgs e)
        {

        }

        private void GuardToPrisonerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //this.Dac = new DatabaseConfiguration();
            string sql = "select * from PrisonerTable order by prisonerid;";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Sql = "select * from PrisonerTable where prisonerid = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void PrisonerGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtPrisonerId.ReadOnly = true;
                this.txtPrisonerId.Text = this.PrisonerGridView.CurrentRow.Cells["prisonerid"].Value.ToString();
                this.txtPrisonerName.Text = this.PrisonerGridView.CurrentRow.Cells["name"].Value.ToString();
                this.dtpBirthDate.Text= this.PrisonerGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
                this.txtAddress.Text = this.PrisonerGridView.CurrentRow.Cells["address"].Value.ToString();
                this.txtReligion.Text = this.PrisonerGridView.CurrentRow.Cells["religion"].Value.ToString();
                this.txtGender.Text = this.PrisonerGridView.CurrentRow.Cells["gender"].Value.ToString();
                this.txtBloodGroup.Text = this.PrisonerGridView.CurrentRow.Cells["bloodgroup"].Value.ToString();
                this.txtMaritalStatus.Text = this.PrisonerGridView.CurrentRow.Cells["maritalstatus"].Value.ToString();
                this.txtMedicalCondition.Text = this.PrisonerGridView.CurrentRow.Cells["medicalcondition"].Value.ToString();
                this.txtEmergencyContact.Text = this.PrisonerGridView.CurrentRow.Cells["emergencycontact"].Value.ToString();
                this.txtCrimeDetails.Text = this.PrisonerGridView.CurrentRow.Cells["crimedetails"].Value.ToString();
                this.dtpEntry.Text= this.PrisonerGridView.CurrentRow.Cells["entrancedate"].Value.ToString();
                this.dtpRelease.Text = this.PrisonerGridView.CurrentRow.Cells["releasedate"].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Selection" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txtPrisonerId.Clear();
            this.txtPrisonerName.Clear();
            this.dtpBirthDate.Text = " ";
            this.txtAddress.Clear();
            this.txtReligion.Clear();
            this.txtGender.Clear();
            this.txtBloodGroup.Clear();
            this.txtMaritalStatus.Clear();
            this.txtMedicalCondition.Clear();
            this.txtEmergencyContact.Clear();
            this.txtCrimeDetails.Clear();
            this.dtpEntry.Text = "";
            this.dtpRelease.Text = "";
        }

        private void PrisonerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
