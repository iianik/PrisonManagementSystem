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
    public partial class PrisonerPage : Form
    {
        private string Sql;
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        public PrisonerPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            
            this.PopulateGridView();
            this.AutoGeneratePrisonerID();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString()); 
        }
        public void PopulateGridView(string sql = "select * from PrisonerTable order by prisonerid;")
        {
            this.Dt = this.Dc.ExecuteQueryTable(sql);
            this.PrisonerGridView.AutoGenerateColumns = false;
            this.PrisonerGridView.DataSource = this.Dt;
        }

        private void PrisonerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionPage selectionPage = new SelectionPage();
            selectionPage.Show();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.PrisonerGridView.CurrentRow.Cells[0].Value.ToString();
                this.Sql = @"delete from PrisonerTable where prisonerid = '" + id + "';";
                int count = this.Dc.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(id + "Has Been Deleted");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"insert into PrisonerTable 
                values ('" + this.txtPrisonerId.Text + "' ,'" + this.txtPrisonerName.Text + "','" + this.dtpDateOfBirth.Text + "','" + this.txtAddress.Text + "'," +
                "'" + this.cmbReligion.Text + "','" + this.cmbGender.Text + "','" + this.cmbBloodGroup.Text + "','" + this.cmbMaritalStatus.Text + "','" + this.cmbMedicalCondition.Text + "'," +
                "'" + "+88" + this.txtEmergencyContact.Text + "','" + this.txtCrimeDetails.Text + "','" + this.dtpEntranceDate.Text + "','" + this.dtpReleaseDate.Text + "');";
                int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("New Prisoner Added Properly");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving data\n" + exc.Message);
            }
            
        }

        private void PrisonerGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtPrisonerId.ReadOnly = true;
                this.txtPrisonerId.Text = this.PrisonerGridView.CurrentRow.Cells["prisonerid"].Value.ToString();
                this.txtPrisonerName.Text = this.PrisonerGridView.CurrentRow.Cells["name"].Value.ToString();
                this.dtpDateOfBirth.Text = this.PrisonerGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
                this.txtAddress.Text = this.PrisonerGridView.CurrentRow.Cells["address"].Value.ToString();
                this.cmbReligion.Text = this.PrisonerGridView.CurrentRow.Cells["religion"].Value.ToString();
                this.cmbGender.Text = this.PrisonerGridView.CurrentRow.Cells["gender"].Value.ToString();
                this.cmbBloodGroup.Text = this.PrisonerGridView.CurrentRow.Cells["bloodgroup"].Value.ToString();
                this.cmbMaritalStatus.Text = this.PrisonerGridView.CurrentRow.Cells["maritalstatus"].Value.ToString();
                this.cmbMedicalCondition.Text = this.PrisonerGridView.CurrentRow.Cells["medicalcondition"].Value.ToString();
                this.txtEmergencyContact.Text = this.PrisonerGridView.CurrentRow.Cells["emergencycontact"].Value.ToString();
                this.txtCrimeDetails.Text = this.PrisonerGridView.CurrentRow.Cells["crimedetails"].Value.ToString();
                this.dtpEntranceDate.Text = this.PrisonerGridView.CurrentRow.Cells["entrancedate"].Value.ToString();
                this.dtpReleaseDate.Text = this.PrisonerGridView.CurrentRow.Cells["releasedate"].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Selection" + exc.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"update PrisonerTable
                         set name = '" + this.txtPrisonerName.Text + @"',
                         dateofbirth= '" + this.dtpDateOfBirth.Text + @"',
                         address = '" + this.txtAddress.Text + @"',
                         religion = '" + this.cmbReligion.Text + @"',
                         gender = '" + this.cmbGender.Text + @"',
                         bloodgroup = '" + this.cmbBloodGroup.Text + @"',
                         maritalstatus = '" + this.cmbMaritalStatus.Text + @"',
                         medicalcondition = '" + this.cmbMedicalCondition.Text + @"',
                         emergencycontact = '" +this.txtEmergencyContact.Text + @"',
                         crimedetails = '" + this.txtCrimeDetails.Text + @"',
                         entrancedate = '" + this.dtpEntranceDate.Text + @"',
                         releasedate = '" + this.dtpReleaseDate.Text + @"'
                         where prisonerid = '" + this.txtPrisonerId.Text + "';";

                int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Prisoner's Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured updating data" + exc.Message);
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
            this.dtpDateOfBirth.Text = "";
            this.txtAddress.Clear();
            this.cmbReligion.Text = "Select Religion";
            this.cmbGender.Text = "select Gender";
            this.cmbBloodGroup.Text = "Choose Blood Group";
            this.cmbMaritalStatus.Text = "Select Marital Status";
            this.cmbMedicalCondition.Text = "Select Medical Comdition";
            this.txtEmergencyContact.Clear();
            this.txtCrimeDetails.Clear();
            this.dtpEntranceDate.Text = "";
            this.dtpReleaseDate.Text = "";
            this.AutoGeneratePrisonerID();
        }
        private void AutoGeneratePrisonerID()
        {
            this.Sql = "select * from PrisonerTable order by prisonerid desc;";
            this.Dt = this.Dc.ExecuteQueryTable(this.Sql);
            string id = Dt.Rows[0]["prisonerid"].ToString();
            string[] st = id.Split('-');
            int tempID = Convert.ToInt32(st[1]);
            string newId = "PS-" + (++tempID).ToString("d4");
            this.txtPrisonerId.Text = newId;
        }

        private void txtPrisonerId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
