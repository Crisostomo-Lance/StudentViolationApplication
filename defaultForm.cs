using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationApplication
{
    public partial class defaultForm : Form
    {
        private bool isResizing = false;
        public defaultForm()
        {
            InitializeComponent();
            loadForm(new dashboardForm());
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnDasboardForm_Click(object sender, EventArgs e)
        {
            loadForm(new dashboardForm());
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            loadForm(new studentForm());
        }

        private void btnViolationForm_Click(object sender, EventArgs e)
        {
            loadForm(new violationForm());
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            loadForm(new reportForm());
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Maximized)
            {
                // Resize the controls when maximized
                sideMenuPanel.Width = 310;
                sideLogoPanel.Height = 260;
                logoImagePanel.Size = new Size(280, 150);
                adminPicture.Size = new Size(280, 125);
            }
            sideMenuPanel.Width = 280;
            sideLogoPanel.Height = 248;
            logoImagePanel.Size = new Size(280, 138);
            adminPicture.Size = new Size(280, 104);


        }


        private void adminPicture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportForm_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViolationForm_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStudentForm_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {

        }

        private void defaultForm_Load(object sender, EventArgs e)
        {

        }
    }
}

