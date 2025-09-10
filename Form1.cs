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
            btnMenu.Hide();
            sidePanelTimer.Start();

        }
        bool sidePanelExpand;
        public void loadForm(object Form)
        {
            if (this.mainpanel1.Controls.Count > 0)
                this.mainpanel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel1.Controls.Add(f);
            this.mainpanel1.Tag = f;
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new dashboardForm());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            loadForm(new studentForm());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            loadForm(new reportForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCloseSidepanel_Click(object sender, EventArgs e)
        {
            sidePanelTimer.Start();
            
        }

        private void sidePanelTimer_Tick(object sender, EventArgs e)
        {
            
            if (sidePanelExpand)
            {
                SidePanel.Width -= 10;
                if (SidePanel.Width == SidePanel.MinimumSize.Width)
                {
                    sidePanelExpand = false;
                    btnCloseSidepanel.Hide();
                    btnMenu.Show();
                    sidePanelTimer.Stop();

                }
            }
            else
            {
                SidePanel.Width += 10;
                if (SidePanel.Width == SidePanel.MaximumSize.Width)
                {
                    sidePanelExpand = true;
                    sidePanelTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidePanelTimer.Start();
            btnCloseSidepanel.Show();
        }
    }
}

