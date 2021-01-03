using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrisonManagementSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from LoginTable where id = '" + this.txtId.Text + "' and password = '" + this.txtPassword.Text + "';";
            DatabaseConfiguration dc = new DatabaseConfiguration();
            DataSet ds = dc.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1 && this.txtId.Text.Contains("AM"))
            {
                MessageBox.Show("Login Approved For " + ds.Tables[0].Rows[0][3].ToString());
                MessageBox.Show("Welcome " + ds.Tables[0].Rows[0][1].ToString());

                this.Hide();
                SupervisorPage supervisorPage = new SupervisorPage();
                supervisorPage.Show();
            }

            else if(ds.Tables[0].Rows.Count == 1 && this.txtId.Text.Contains("SV"))
            {
                MessageBox.Show("Login Approved For " + ds.Tables[0].Rows[0][3].ToString());
                MessageBox.Show("Welcome " + ds.Tables[0].Rows[0][1].ToString());
                this.Hide();
                SelectionPage selectionPage = new SelectionPage();
                selectionPage.Show();
            }
            else if (ds.Tables[0].Rows.Count == 1 && this.txtId.Text.Contains("G"))
            {
                MessageBox.Show("Login Approved For " + ds.Tables[0].Rows[0][3].ToString());
                MessageBox.Show("Welcome " + ds.Tables[0].Rows[0][1].ToString());
                this.Hide();
                GuardToPrisonerPage guardToPrisonerPage = new GuardToPrisonerPage();
                guardToPrisonerPage.Show();
            }
            else
            {
                MessageBox.Show("Login Invalid");
            }
             
        }

        private void lblVisitorButton_Click_1(object sender, EventArgs e)
        {
            /*this.Hide();
            VisitorPage visitorPage = new VisitorPage();
            visitorPage.Show();*/

            this.Hide();
            VisitorPage visitorpage = new VisitorPage();
            visitorpage.Show();

        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
