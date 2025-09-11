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
        public defaultForm()
        {
            InitializeComponent();
            loadForm(new dashboardForm());
        }

        private void defaultForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDasboardForm_Click(object sender, EventArgs e)
        {
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


        private void btnReport_Click(object sender, EventArgs e)
        {
            loadForm(new reportForm());
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            loadForm(new studentForm());
        }

        private void btnViolation_Click(object sender, EventArgs e)
        {
            loadForm(new violationForm());
        }
    }
}

