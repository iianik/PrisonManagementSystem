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
    public partial class VisitorInformationPage : Form
    {
        private string Sql { get; set; }
        //private string SqlLogin { get; set; }
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        public VisitorInformationPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "select * from VisitorTable;")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.VisitorPageGridView.AutoGenerateColumns = false;
            this.VisitorPageGridView.DataSource = this.Ds.Tables[0];
        }

        private void VisitorInformationPage_Load(object sender, EventArgs e)
        {

        }

        private void VisitorInformationPage_FormClosed(object sender, FormClosedEventArgs e)
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
            string sql = "select * from VisitorTable;";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Sql = "select * from VisitorTable where prisonerid = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tokenno = this.VisitorPageGridView.CurrentRow.Cells[0].Value.ToString();
            this.Sql = @"delete from VisitorTable where tokenno = '" + tokenno + "';";
            int count = this.Dc.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(tokenno + " Has Been Deleted");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateGridView();
        }
    }
}
