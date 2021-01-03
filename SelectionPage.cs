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
    public partial class SelectionPage : Form
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void SelectionPage_Load(object sender, EventArgs e)
        {

        }

        private void SelectionPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrisonerPage prisonerPage = new PrisonerPage();
            prisonerPage.Show();
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardPage guardPage = new GuardPage();
            guardPage.Show();
        }

        private void btnVisitorInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitorInformationPage visitorInformationPage = new VisitorInformationPage();
            visitorInformationPage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }
    }
}
