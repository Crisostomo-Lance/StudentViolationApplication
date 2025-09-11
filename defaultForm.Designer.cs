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
            this.sidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sideLogoPanel = new System.Windows.Forms.Panel();
            this.sideLogoAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.btnDasboardForm = new System.Windows.Forms.Button();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.violationPanel = new System.Windows.Forms.Panel();
            this.btnViolation = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.sideLogoPanel.SuspendLayout();
            this.sideLogoAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.violationPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanelTimer
            // 
            this.sidePanelTimer.Interval = 10;
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.sideMenuPanel.Controls.Add(this.sideLogoPanel);
            this.sideMenuPanel.Controls.Add(this.dashboardPanel);
            this.sideMenuPanel.Controls.Add(this.studentPanel);
            this.sideMenuPanel.Controls.Add(this.violationPanel);
            this.sideMenuPanel.Controls.Add(this.reportPanel);
            this.sideMenuPanel.Controls.Add(this.settingPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(280, 583);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // sideLogoPanel
            // 
            this.sideLogoPanel.BackColor = System.Drawing.Color.Gray;
            this.sideLogoPanel.Controls.Add(this.sideLogoAdmin);
            this.sideLogoPanel.Controls.Add(this.pictureBox1);
            this.sideLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.sideLogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideLogoPanel.Name = "sideLogoPanel";
            this.sideLogoPanel.Size = new System.Drawing.Size(280, 212);
            this.sideLogoPanel.TabIndex = 1;
            // 
            // sideLogoAdmin
            // 
            this.sideLogoAdmin.Controls.Add(this.lblAdmin);
            this.sideLogoAdmin.Location = new System.Drawing.Point(3, 141);
            this.sideLogoAdmin.Name = "sideLogoAdmin";
            this.sideLogoAdmin.Size = new System.Drawing.Size(274, 71);
            this.sideLogoAdmin.TabIndex = 2;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdmin.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(49, 40);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(174, 21);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "ADMINISTRATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentViolationApplication.Properties.Resources.account_circle_96dp;
            this.pictureBox1.Location = new System.Drawing.Point(93, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Controls.Add(this.btnDasboardForm);
            this.dashboardPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardPanel.ForeColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 212);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(280, 50);
            this.dashboardPanel.TabIndex = 2;
            // 
            // btnDasboardForm
            // 
            this.btnDasboardForm.BackColor = System.Drawing.Color.DimGray;
            this.btnDasboardForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDasboardForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDasboardForm.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboardForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDasboardForm.Location = new System.Drawing.Point(-11, -21);
            this.btnDasboardForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnDasboardForm.Name = "btnDasboardForm";
            this.btnDasboardForm.Size = new System.Drawing.Size(314, 87);
            this.btnDasboardForm.TabIndex = 0;
            this.btnDasboardForm.Text = "DASHBOARD";
            this.btnDasboardForm.UseVisualStyleBackColor = false;
            this.btnDasboardForm.Click += new System.EventHandler(this.btnDasboardForm_Click);
            // 
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.Transparent;
            this.studentPanel.Controls.Add(this.btnStudentForm);
            this.studentPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPanel.ForeColor = System.Drawing.Color.Transparent;
            this.studentPanel.Location = new System.Drawing.Point(0, 262);
            this.studentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(280, 50);
            this.studentPanel.TabIndex = 3;
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.DimGray;
            this.btnStudentForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStudentForm.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentForm.ForeColor = System.Drawing.Color.White;
            this.btnStudentForm.Location = new System.Drawing.Point(-11, -21);
            this.btnStudentForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(314, 87);
            this.btnStudentForm.TabIndex = 0;
            this.btnStudentForm.Text = "STUDENT";
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // violationPanel
            // 
            this.violationPanel.BackColor = System.Drawing.Color.Transparent;
            this.violationPanel.Controls.Add(this.btnViolation);
            this.violationPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.violationPanel.ForeColor = System.Drawing.Color.Transparent;
            this.violationPanel.Location = new System.Drawing.Point(0, 312);
            this.violationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.violationPanel.Name = "violationPanel";
            this.violationPanel.Size = new System.Drawing.Size(280, 50);
            this.violationPanel.TabIndex = 3;
            // 
            // btnViolation
            // 
            this.btnViolation.BackColor = System.Drawing.Color.DimGray;
            this.btnViolation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnViolation.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolation.ForeColor = System.Drawing.Color.White;
            this.btnViolation.Location = new System.Drawing.Point(-11, -21);
            this.btnViolation.Margin = new System.Windows.Forms.Padding(0);
            this.btnViolation.Name = "btnViolation";
            this.btnViolation.Size = new System.Drawing.Size(314, 87);
            this.btnViolation.TabIndex = 0;
            this.btnViolation.Text = "VIOLATION";
            this.btnViolation.UseVisualStyleBackColor = false;
            this.btnViolation.Click += new System.EventHandler(this.btnViolation_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.Transparent;
            this.reportPanel.Controls.Add(this.btnReport);
            this.reportPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPanel.ForeColor = System.Drawing.Color.Transparent;
            this.reportPanel.Location = new System.Drawing.Point(0, 362);
            this.reportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(280, 50);
            this.reportPanel.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DimGray;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(-11, -21);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(314, 87);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingPanel.Controls.Add(this.button4);
            this.settingPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingPanel.ForeColor = System.Drawing.Color.Silver;
            this.settingPanel.Location = new System.Drawing.Point(0, 412);
            this.settingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(280, 50);
            this.settingPanel.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(-11, -21);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(314, 87);
            this.button4.TabIndex = 0;
            this.button4.Text = "SETTINGS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(280, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(952, 583);
            this.mainPanel.TabIndex = 1;
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1232, 583);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "defaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Vialotion Application";
            this.Load += new System.EventHandler(this.defaultForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.sideLogoPanel.ResumeLayout(false);
            this.sideLogoAdmin.ResumeLayout(false);
            this.sideLogoAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.studentPanel.ResumeLayout(false);
            this.violationPanel.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidePanelTimer;
        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private System.Windows.Forms.Panel sideLogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sideLogoAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button btnDasboardForm;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.Panel violationPanel;
        private System.Windows.Forms.Button btnViolation;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel mainPanel;
    }
}

