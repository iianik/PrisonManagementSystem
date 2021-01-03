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
    public partial class GuardPage : Form
    {
        String Sql;
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        public GuardPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
            this.AutoGenerateGuardsID();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString());     
        }
        public void PopulateGridView(string sql = "select * from GuardsTable;")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.GuardPageGridView.AutoGenerateColumns = false;
            this.GuardPageGridView.DataSource = this.Ds.Tables[0];
        }

        private void GuardPage_FormClosed(object sender, FormClosedEventArgs e)
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
            string sql = "select * from GuardsTable;";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Sql = "select * from GuardsTable where id = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.GuardPageGridView.CurrentRow.Cells[0].Value.ToString();
                this.Sql = @"delete from GuardsTable where id = '" + id + "';delete from LoginTable where id= '" + id + "';";
                int count = this.Dc.ExecuteUpdateQuery(this.Sql);

                if (count == 2)
                {
                    MessageBox.Show(id + "Has Been Deleted");
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
                    this.Sql = @"insert into GuardsTable 
                values ('" + this.txtId.Text + "' ,'" + this.txtName.Text + "','" + this.txtPassword.Text + "','" + this.dtpDateOfBirth.Text + "'," +
                    "'" + this.cmbGender.Text + "','" + this.cmbBoodGroup.Text + "','" + this.txtPreAddress.Text + "','" + this.txtParAddress.Text + "'," +
                    "'" + "+88" + this.txtMobileNo.Text + "','" + this.txtNidNo.Text + "','" + this.txtPassportNo.Text + "');" +
                    "insert into LoginTable values('" + this.txtId.Text + "' ,'" + this.txtName.Text + "','" + this.txtPassword.Text + "', 'Guards');";
                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    if (count == 2)
                    {
                        MessageBox.Show("New Guard Added Properly");
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
                    MessageBox.Show("An error has occured during saving data\n" + exc.Message);
                }

            }
            else
            {
                MessageBox.Show("Password does not match");
            }
            
            
        }

        private void GuardPageGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.ReadOnly = true;
            this.txtId.Text = this.GuardPageGridView.CurrentRow.Cells["id"].Value.ToString();
            this.txtName.Text = this.GuardPageGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txtPassword.Text = this.GuardPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.txtConfirmPassword.Text = this.GuardPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.dtpDateOfBirth.Text = this.GuardPageGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
            this.cmbGender.Text = this.GuardPageGridView.CurrentRow.Cells["gender"].Value.ToString();
            this.cmbBoodGroup.Text = this.GuardPageGridView.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtPreAddress.Text = this.GuardPageGridView.CurrentRow.Cells["presentaddress"].Value.ToString();
            this.txtParAddress.Text = this.GuardPageGridView.CurrentRow.Cells["parmanentaddress"].Value.ToString();
            this.txtMobileNo.Text = this.GuardPageGridView.CurrentRow.Cells["mobileno"].Value.ToString();
            this.txtNidNo.Text = this.GuardPageGridView.CurrentRow.Cells["nidno"].Value.ToString();
            this.txtPassportNo.Text = this.GuardPageGridView.CurrentRow.Cells["passportno"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {
                try
                {
                    this.Sql = @"update GuardsTable
                         set name = '" + this.txtName.Text + @"',
                         password = '" + this.txtPassword.Text + @"',
                         dateofbirth= '" + this.dtpDateOfBirth.Text + @"',
                         gender = '" + this.cmbGender.Text + @"',
                         bloodgroup = '" + this.cmbBoodGroup.Text + @"',
                         presentaddress = '" + this.txtPreAddress.Text + @"',
                         parmanentaddress = '" + this.txtParAddress.Text + @"',
                         mobileno = '" + this.txtMobileNo.Text + @"',
                         nidno = '" + this.txtNidNo.Text + @"',
                         passportno = '" + this.txtPassportNo.Text + @"'
                         where id = '" + this.txtId.Text + "';" +
                            // updating in Login Table for Guards
                            "update LoginTable set name ='" + this.txtName.Text + "',password = '" + this.txtPassword.Text + "',type = 'Guards'where id ='" + this.txtId.Text + "';";

                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    if (count == 2)
                    {
                        MessageBox.Show("Guards's Data Updated");
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
                    MessageBox.Show("An error has occured during saving data\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Password does not match");
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
            this.cmbBoodGroup.Text = "Choose Blood Group";
            this.txtPreAddress.Clear();
            this.txtParAddress.Clear();
            this.txtMobileNo.Clear();
            this.txtNidNo.Clear();
            this.txtPassportNo.Clear();
            this.AutoGenerateGuardsID();
        }
        private void AutoGenerateGuardsID()
        {
            
            this.Sql = "select * from GuardsTable order by id desc;";
            DataTable dt = this.Dc.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0]["id"].ToString();
            string[] st = id.Split('-');
            int tempID = Convert.ToInt32(st[1]);
            string newId = "G-" + (++tempID).ToString("d3");
            this.txtId.Text = newId;
        }
    }
}
