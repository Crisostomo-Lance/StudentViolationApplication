namespace StudentViolationApplication
{
    partial class defaultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbl_IDNumber = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.mainpanel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnCloseSidepanel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSidepanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.btnCloseSidepanel);
            this.panelLogo.Controls.Add(this.lbl_IDNumber);
            this.panelLogo.Controls.Add(this.lbl_ID);
            this.panelLogo.Controls.Add(this.lblAdminName);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(8, 8);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(8);
            this.panelLogo.MaximumSize = new System.Drawing.Size(656, 464);
            this.panelLogo.MinimumSize = new System.Drawing.Size(656, 95);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(656, 464);
            this.panelLogo.TabIndex = 0;
            // 
            // lbl_IDNumber
            // 
            this.lbl_IDNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IDNumber.BackColor = System.Drawing.Color.DimGray;
            this.lbl_IDNumber.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDNumber.Location = new System.Drawing.Point(262, 337);
            this.lbl_IDNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_IDNumber.Name = "lbl_IDNumber";
            this.lbl_IDNumber.Size = new System.Drawing.Size(190, 48);
            this.lbl_IDNumber.TabIndex = 2;
            this.lbl_IDNumber.Text = "0281423643";
            this.lbl_IDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ID.BackColor = System.Drawing.Color.DimGray;
            this.lbl_ID.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(216, 337);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(68, 48);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(0, 386);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(656, 48);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "ADMINISTRATOR";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainpanel1
            // 
            this.mainpanel1.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel1.Location = new System.Drawing.Point(0, 0);
            this.mainpanel1.Margin = new System.Windows.Forms.Padding(6);
            this.mainpanel1.Name = "mainpanel1";
            this.mainpanel1.Size = new System.Drawing.Size(2564, 1197);
            this.mainpanel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DimGray;
            this.SidePanel.Controls.Add(this.panelLogo);
            this.SidePanel.Controls.Add(this.btnDashboard);
            this.SidePanel.Controls.Add(this.btnStudent);
            this.SidePanel.Controls.Add(this.button2);
            this.SidePanel.Controls.Add(this.btnReport);
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.btnLogout);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.MaximumSize = new System.Drawing.Size(664, 1197);
            this.SidePanel.MinimumSize = new System.Drawing.Size(150, 1197);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(664, 1197);
            this.SidePanel.TabIndex = 0;
            // 
            // sidePanelTimer
            // 
            this.sidePanelTimer.Interval = 10;
            this.sidePanelTimer.Tick += new System.EventHandler(this.sidePanelTimer_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::StudentViolationApplication.Properties.Resources.menu_38dp_E3E3E3_FILL0_wght400_GRAD0_opsz40;
            this.btnMenu.Location = new System.Drawing.Point(81, 47);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 43);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCloseSidepanel
            // 
            this.btnCloseSidepanel.Image = global::StudentViolationApplication.Properties.Resources.close_24dp;
            this.btnCloseSidepanel.Location = new System.Drawing.Point(556, 30);
            this.btnCloseSidepanel.Name = "btnCloseSidepanel";
            this.btnCloseSidepanel.Size = new System.Drawing.Size(60, 60);
            this.btnCloseSidepanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseSidepanel.TabIndex = 3;
            this.btnCloseSidepanel.TabStop = false;
            this.btnCloseSidepanel.Click += new System.EventHandler(this.btnCloseSidepanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::StudentViolationApplication.Properties.Resources.account_circle_96dp;
            this.pictureBox1.Location = new System.Drawing.Point(212, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::StudentViolationApplication.Properties.Resources.monitor_28dp;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(8, 488);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(660, 58);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::StudentViolationApplication.Properties.Resources.person_28dp;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(8, 562);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(8);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(660, 58);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "STUDENT";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::StudentViolationApplication.Properties.Resources.article_28dp;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(8, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(660, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "VIOLATIONS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::StudentViolationApplication.Properties.Resources.article_28dp;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(8, 710);
            this.btnReport.Margin = new System.Windows.Forms.Padding(8);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(660, 58);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "REPORTS";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StudentViolationApplication.Properties.Resources.article_28dp;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 784);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(660, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "RECORDS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::StudentViolationApplication.Properties.Resources.logout_28dp;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(8, 858);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8, 8, 8, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(656, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 935);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 100);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::StudentViolationApplication.Properties.Resources.logout_28dp;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-17, -5);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 16);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(682, 136);
            this.button3.TabIndex = 8;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1197);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.mainpanel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "defaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Vialotion Application";
            this.panelLogo.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSidepanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_IDNumber;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel mainpanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.PictureBox btnCloseSidepanel;
        private System.Windows.Forms.Timer sidePanelTimer;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}

