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
    public partial class SupervisorPage : Form
    {
        //String Sql;
        private string Sql { get; set; }
        //private string SqlLogin { get; set; }
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        public SupervisorPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
            this.AutoGenerateSupervisorID();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString());       
        }

        public void PopulateGridView(string sql = "select * from SupervisorTable;")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.SupervisorPageGridView.AutoGenerateColumns = false;
            this.SupervisorPageGridView.DataSource = this.Ds.Tables[0];
        }


        private void SupervisorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //this.Dac = new DatabaseConfiguration();
            string sql = "select * from SupervisorTable order by id;";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Sql = "select * from SupervisorTable where id = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.SupervisorPageGridView.CurrentRow.Cells[0].Value.ToString();
                this.Sql = @"delete from SupervisorTable where id = '" + id + "';" +
                    "delete from LoginTable where id = '" + id + "';";
                int count = this.Dc.ExecuteUpdateQuery(this.Sql);

                if (count == 2)
                {
                    MessageBox.Show(id + " Has Been Deleted");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridView();
                this.ClearAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {
                try
                {
                    this.Sql = @"insert into SupervisorTable 
                    values ('" + this.txtId.Text + "' ,'" + this.txtName.Text + "','" + this.txtPassword.Text + "','" + this.dtpDateOfBirth.Text + "'," +
                    "'" + this.cmbGender.Text + "','" + this.cmbBloodGroup.Text + "','" + this.txtPreAddress.Text + "','" + this.txtParAddress.Text + "'," +
                    "'" + "+88" + this.txtMobileNo.Text + "','" + this.txtNidNo.Text + "','" + this.txtPassportNo.Text + "');" +
                    "insert into LoginTable values('" + this.txtId.Text + "' ,'" + this.txtName.Text + "','" + this.txtPassword.Text + "', 'Supervisor');";

                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    

                    if (count == 2)
                    {
                        MessageBox.Show("New Supervisor Added Properly");

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
                    MessageBox.Show("An error has occured saving data\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Password does not match");
            }
            
            
        }

        private void SupervisorPageGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.ReadOnly = true;
            this.txtId.Text = this.SupervisorPageGridView.CurrentRow.Cells["id"].Value.ToString();
            this.txtName.Text = this.SupervisorPageGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txtPassword.Text = this.SupervisorPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.txtConfirmPassword.Text = this.SupervisorPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.dtpDateOfBirth.Text = this.SupervisorPageGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
            this.cmbGender.Text = this.SupervisorPageGridView.CurrentRow.Cells[4].Value.ToString();
            this.cmbBloodGroup.Text = this.SupervisorPageGridView.CurrentRow.Cells[5].Value.ToString();
            this.txtPreAddress.Text = this.SupervisorPageGridView.CurrentRow.Cells["presentaddress"].Value.ToString();
            this.txtParAddress.Text = this.SupervisorPageGridView.CurrentRow.Cells["parmanentaddress"].Value.ToString();
            this.txtMobileNo.Text = this.SupervisorPageGridView.CurrentRow.Cells["mobileno"].Value.ToString();
            this.txtNidNo.Text = this.SupervisorPageGridView.CurrentRow.Cells["nidno"].Value.ToString();
            this.txtPassportNo.Text = this.SupervisorPageGridView.CurrentRow.Cells["passportno"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"update SupervisorTable
                         set name = '" + this.txtName.Text + @"',
                         password = '" + this.txtPassword.Text + @"',
                         dateofbirth= '" + this.dtpDateOfBirth.Text + @"',
                         gender = '" + this.cmbGender.Text + @"',
                         bloodgroup = '" + this.cmbBloodGroup.Text + @"',
                         presentaddress = '" + this.txtPreAddress.Text + @"',
                         parmanentaddress = '" + this.txtParAddress.Text + @"',
                         mobileno = '" + this.txtMobileNo.Text + @"',
                         nidno = '" + this.txtNidNo.Text + @"',
                         passportno = '" + this.txtPassportNo.Text + @"'
                         where id = '" + this.txtId.Text + "';"+
                         // updating in Login Table for Supervisor
                         "update LoginTable set name ='" + this.txtName.Text + "',password = '" + this.txtPassword.Text + "',type = 'Supervisor'where id ='" + this.txtId.Text + "';";

                int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                if (count == 2)
                {
                    MessageBox.Show("Supervisor's Data Updated");
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
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtConfirmPassword.Clear();
            this.dtpDateOfBirth.Text = "";
            this.cmbGender.Text = "Select Gender";
            this.cmbBloodGroup.Text = "Choose Blood Group";
            this.txtPreAddress.Clear();
            this.txtParAddress.Clear();
            this.txtMobileNo.Clear();
            this.txtNidNo.Clear();
            this.txtPassportNo.Clear();
            this.AutoGenerateSupervisorID();
        }
        private void AutoGenerateSupervisorID()
        {
            this.Sql = "select * from SupervisorTable order by id desc;";
            this.Dt = this.Dc.ExecuteQueryTable(this.Sql);
            string id = Dt.Rows[0]["id"].ToString();
            string[] st = id.Split('-');
            int tempID = Convert.ToInt32(st[1]);
            string newId ="SV-"+(++tempID).ToString("d2");
            this.txtId.Text = newId;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void SupervisorPageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
