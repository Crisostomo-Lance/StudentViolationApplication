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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaultForm));
            this.sidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.subSettingManageUser = new System.Windows.Forms.Button();
            this.subSettingAdmin = new System.Windows.Forms.Button();
            this.logoImagePanel = new System.Windows.Forms.Panel();
            this.adminPicture = new System.Windows.Forms.PictureBox();
            this.sideLogoAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.sideLogoPanel = new System.Windows.Forms.Panel();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.btnViolationForm = new System.Windows.Forms.Button();
            this.btnReportForm = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.subMenuSetting = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.logoImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).BeginInit();
            this.sideLogoAdmin.SuspendLayout();
            this.sideLogoPanel.SuspendLayout();
            this.subMenuSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanelTimer
            // 
            this.sidePanelTimer.Interval = 10;
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.sideMenuPanel.Controls.Add(this.subMenuSetting);
            this.sideMenuPanel.Controls.Add(this.btnSetting);
            this.sideMenuPanel.Controls.Add(this.btnReportForm);
            this.sideMenuPanel.Controls.Add(this.btnViolationForm);
            this.sideMenuPanel.Controls.Add(this.btnStudentForm);
            this.sideMenuPanel.Controls.Add(this.btnDashboardForm);
            this.sideMenuPanel.Controls.Add(this.sideLogoPanel);
            this.sideMenuPanel.Controls.Add(this.btnLogout);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(280, 703);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = global::StudentViolationApplication.Properties.Resources.logout_24d;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 653);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "               LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // subSettingManageUser
            // 
            this.subSettingManageUser.BackColor = System.Drawing.Color.Transparent;
            this.subSettingManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.subSettingManageUser.FlatAppearance.BorderSize = 0;
            this.subSettingManageUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subSettingManageUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subSettingManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subSettingManageUser.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subSettingManageUser.ForeColor = System.Drawing.Color.Transparent;
            this.subSettingManageUser.Image = global::StudentViolationApplication.Properties.Resources.settings_account_box_18dp;
            this.subSettingManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subSettingManageUser.Location = new System.Drawing.Point(0, 50);
            this.subSettingManageUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subSettingManageUser.Name = "subSettingManageUser";
            this.subSettingManageUser.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.subSettingManageUser.Size = new System.Drawing.Size(280, 50);
            this.subSettingManageUser.TabIndex = 8;
            this.subSettingManageUser.Text = "          Manage User";
            this.subSettingManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subSettingManageUser.UseVisualStyleBackColor = false;
            // 
            // subSettingAdmin
            // 
            this.subSettingAdmin.BackColor = System.Drawing.Color.Transparent;
            this.subSettingAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.subSettingAdmin.FlatAppearance.BorderSize = 0;
            this.subSettingAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subSettingAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subSettingAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subSettingAdmin.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subSettingAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.subSettingAdmin.Image = global::StudentViolationApplication.Properties.Resources.manage_accounts_18dp;
            this.subSettingAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subSettingAdmin.Location = new System.Drawing.Point(0, 0);
            this.subSettingAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subSettingAdmin.Name = "subSettingAdmin";
            this.subSettingAdmin.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.subSettingAdmin.Size = new System.Drawing.Size(280, 50);
            this.subSettingAdmin.TabIndex = 7;
            this.subSettingAdmin.Text = "          Admin Setting";
            this.subSettingAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subSettingAdmin.UseVisualStyleBackColor = false;
            this.subSettingAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoImagePanel
            // 
            this.logoImagePanel.Controls.Add(this.adminPicture);
            this.logoImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoImagePanel.Location = new System.Drawing.Point(0, 0);
            this.logoImagePanel.Name = "logoImagePanel";
            this.logoImagePanel.Size = new System.Drawing.Size(280, 138);
            this.logoImagePanel.TabIndex = 3;
            // 
            // adminPicture
            // 
            this.adminPicture.BackColor = System.Drawing.Color.Transparent;
            this.adminPicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminPicture.Image = ((System.Drawing.Image)(resources.GetObject("adminPicture.Image")));
            this.adminPicture.Location = new System.Drawing.Point(0, 34);
            this.adminPicture.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.adminPicture.Name = "adminPicture";
            this.adminPicture.Size = new System.Drawing.Size(280, 104);
            this.adminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPicture.TabIndex = 1;
            this.adminPicture.TabStop = false;
            // 
            // sideLogoAdmin
            // 
            this.sideLogoAdmin.Controls.Add(this.lblAdmin);
            this.sideLogoAdmin.Controls.Add(this.lblAdminID);
            this.sideLogoAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sideLogoAdmin.Location = new System.Drawing.Point(0, 144);
            this.sideLogoAdmin.Name = "sideLogoAdmin";
            this.sideLogoAdmin.Size = new System.Drawing.Size(280, 104);
            this.sideLogoAdmin.TabIndex = 2;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdmin.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(0, 39);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.lblAdmin.Size = new System.Drawing.Size(280, 52);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "ADMINISTRATOR";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(280, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1102, 703);
            this.mainPanel.TabIndex = 2;
            // 
            // lblAdminID
            // 
            this.lblAdminID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminID.Location = new System.Drawing.Point(0, 0);
            this.lblAdminID.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblAdminID.Size = new System.Drawing.Size(280, 39);
            this.lblAdminID.TabIndex = 1;
            this.lblAdminID.Text = "0123456789";
            this.lblAdminID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sideLogoPanel
            // 
            this.sideLogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.sideLogoPanel.Controls.Add(this.logoImagePanel);
            this.sideLogoPanel.Controls.Add(this.sideLogoAdmin);
            this.sideLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.sideLogoPanel.Name = "sideLogoPanel";
            this.sideLogoPanel.Size = new System.Drawing.Size(280, 248);
            this.sideLogoPanel.TabIndex = 9;
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardForm.FlatAppearance.BorderSize = 0;
            this.btnDashboardForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboardForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboardForm.Image = global::StudentViolationApplication.Properties.Resources.home_24dp_;
            this.btnDashboardForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardForm.Location = new System.Drawing.Point(0, 248);
            this.btnDashboardForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDashboardForm.Size = new System.Drawing.Size(280, 50);
            this.btnDashboardForm.TabIndex = 1;
            this.btnDashboardForm.Text = "               DASHBOARD";
            this.btnDashboardForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentForm.FlatAppearance.BorderSize = 0;
            this.btnStudentForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudentForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentForm.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnStudentForm.Image = global::StudentViolationApplication.Properties.Resources.home_24dp_;
            this.btnStudentForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentForm.Location = new System.Drawing.Point(0, 298);
            this.btnStudentForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnStudentForm.Size = new System.Drawing.Size(280, 50);
            this.btnStudentForm.TabIndex = 10;
            this.btnStudentForm.Text = "               STUDENTS";
            this.btnStudentForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click_1);
            // 
            // btnViolationForm
            // 
            this.btnViolationForm.BackColor = System.Drawing.Color.Transparent;
            this.btnViolationForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViolationForm.FlatAppearance.BorderSize = 0;
            this.btnViolationForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViolationForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnViolationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolationForm.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolationForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnViolationForm.Image = global::StudentViolationApplication.Properties.Resources.home_24dp_;
            this.btnViolationForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolationForm.Location = new System.Drawing.Point(0, 348);
            this.btnViolationForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnViolationForm.Name = "btnViolationForm";
            this.btnViolationForm.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnViolationForm.Size = new System.Drawing.Size(280, 50);
            this.btnViolationForm.TabIndex = 11;
            this.btnViolationForm.Text = "               VIOLATION";
            this.btnViolationForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolationForm.UseVisualStyleBackColor = false;
            this.btnViolationForm.Click += new System.EventHandler(this.btnViolationForm_Click_1);
            // 
            // btnReportForm
            // 
            this.btnReportForm.BackColor = System.Drawing.Color.Transparent;
            this.btnReportForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportForm.FlatAppearance.BorderSize = 0;
            this.btnReportForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportForm.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportForm.Image = global::StudentViolationApplication.Properties.Resources.home_24dp_;
            this.btnReportForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportForm.Location = new System.Drawing.Point(0, 398);
            this.btnReportForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnReportForm.Name = "btnReportForm";
            this.btnReportForm.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnReportForm.Size = new System.Drawing.Size(280, 50);
            this.btnReportForm.TabIndex = 12;
            this.btnReportForm.Text = "               REPORTS";
            this.btnReportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportForm.UseVisualStyleBackColor = false;
            this.btnReportForm.Click += new System.EventHandler(this.btnReportForm_Click_1);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = global::StudentViolationApplication.Properties.Resources.home_24dp_;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 448);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSetting.Size = new System.Drawing.Size(280, 50);
            this.btnSetting.TabIndex = 13;
            this.btnSetting.Text = "               SETTING";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // subMenuSetting
            // 
            this.subMenuSetting.BackColor = System.Drawing.Color.Gray;
            this.subMenuSetting.Controls.Add(this.subSettingManageUser);
            this.subMenuSetting.Controls.Add(this.subSettingAdmin);
            this.subMenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuSetting.Location = new System.Drawing.Point(0, 498);
            this.subMenuSetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subMenuSetting.Name = "subMenuSetting";
            this.subMenuSetting.Size = new System.Drawing.Size(280, 100);
            this.subMenuSetting.TabIndex = 7;
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 750);
            this.Name = "defaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Vialotion Application";
            this.Load += new System.EventHandler(this.defaultForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.logoImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).EndInit();
            this.sideLogoAdmin.ResumeLayout(false);
            this.sideLogoPanel.ResumeLayout(false);
            this.subMenuSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidePanelTimer;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button subSettingManageUser;
        private System.Windows.Forms.Button subSettingAdmin;
        private System.Windows.Forms.Panel logoImagePanel;
        private System.Windows.Forms.PictureBox adminPicture;
        private System.Windows.Forms.Panel sideLogoAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Panel sideLogoPanel;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Panel subMenuSetting;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReportForm;
        private System.Windows.Forms.Button btnViolationForm;
        private System.Windows.Forms.Button btnStudentForm;
    }
}

