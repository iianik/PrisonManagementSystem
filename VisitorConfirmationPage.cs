using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class VisitorConfirmationPage : Form
    {


        public VisitorConfirmationPage(string tokenNO, string visitorName, string prisonerName, string prisonerId, string timeShift, string date)
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.lblTokenNo.Text = tokenNO;
            this.lblVisitorName.Text = visitorName;
            this.lblPrisonerName.Text = prisonerName;
            this.lblPrisonerId.Text = prisonerId;
            this.lblTimeShift.Text = timeShift;
            this.lblDate.Text = date;
            this.timerConfirmation.Start();

        }
        private void VisitorConfirmationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerConfirmation_Tick(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.timerConfirmation.Stop();

        }
    }
}
