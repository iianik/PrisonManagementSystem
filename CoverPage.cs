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
    public partial class CoverPage : Form
    {
        public CoverPage()
        {
            
            InitializeComponent();
            this.panel_articel.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.BackgroundImage = Properties.Resources.CoverPage;
            this.timerCoverPage.Start();
        }
        private void CoverPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerCoverPage_Tick(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.timerCoverPage.Stop();
        }

        private void panel_articel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
