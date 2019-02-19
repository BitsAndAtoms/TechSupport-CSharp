namespace TechSupport.View
{
    partial class MainDashboard
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
            this.searchIncident = new System.Windows.Forms.TabPage();
            this.loadIncident = new System.Windows.Forms.TabPage();
            this.addIncident = new System.Windows.Forms.TabPage();
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLabelLink = new System.Windows.Forms.LinkLabel();
            this.loginUsername = new System.Windows.Forms.Label();
            this.addIncidentUserControl1 = new TechSupport.UserControls.addIncidentUserControl();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.searchIncidentUserControl();
            this.displayOpenIncidentsUserControl1 = new TechSupport.UserControls.displayOpenIncidentsUserControl();
            this.searchIncident.SuspendLayout();
            this.loadIncident.SuspendLayout();
            this.addIncident.SuspendLayout();
            this.DashboardTabControl.SuspendLayout();
            this.displayOpenIncidents.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchIncident
            // 
            this.searchIncident.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncident.Location = new System.Drawing.Point(4, 29);
            this.searchIncident.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(614, 457);
            this.searchIncident.TabIndex = 2;
            this.searchIncident.Text = "Search incident";
            this.searchIncident.UseVisualStyleBackColor = true;
            // 
            // loadIncident
            // 
            this.loadIncident.Controls.Add(this.loadIncidentUserControl1);
            this.loadIncident.Location = new System.Drawing.Point(4, 29);
            this.loadIncident.Name = "loadIncident";
            this.loadIncident.Size = new System.Drawing.Size(614, 457);
            this.loadIncident.TabIndex = 3;
            this.loadIncident.Text = "Load Incident";
            this.loadIncident.UseVisualStyleBackColor = true;
            // 
            // addIncident
            // 
            this.addIncident.Controls.Add(this.addIncidentUserControl1);
            this.addIncident.Location = new System.Drawing.Point(4, 29);
            this.addIncident.Name = "addIncident";
            this.addIncident.Size = new System.Drawing.Size(614, 457);
            this.addIncident.TabIndex = 4;
            this.addIncident.Text = "Add Incident";
            this.addIncident.UseVisualStyleBackColor = true;
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.CausesValidation = false;
            this.DashboardTabControl.Controls.Add(this.addIncident);
            this.DashboardTabControl.Controls.Add(this.loadIncident);
            this.DashboardTabControl.Controls.Add(this.searchIncident);
            this.DashboardTabControl.Controls.Add(this.displayOpenIncidents);
            this.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardTabControl.Location = new System.Drawing.Point(0, 40);
            this.DashboardTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(622, 490);
            this.DashboardTabControl.TabIndex = 0;
            this.DashboardTabControl.TabStop = false;
            this.DashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // displayOpenIncidents
            // 
            this.displayOpenIncidents.Controls.Add(this.displayOpenIncidentsUserControl1);
            this.displayOpenIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOpenIncidents.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidents.Name = "displayOpenIncidents";
            this.displayOpenIncidents.Size = new System.Drawing.Size(614, 457);
            this.displayOpenIncidents.TabIndex = 5;
            this.displayOpenIncidents.Text = "Display Open Incidents";
            this.displayOpenIncidents.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.13044F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.86956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLabelLink, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginUsername, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 42);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // logoutLabelLink
            // 
            this.logoutLabelLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLabelLink.AutoSize = true;
            this.logoutLabelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabelLink.Location = new System.Drawing.Point(540, 9);
            this.logoutLabelLink.Name = "logoutLabelLink";
            this.logoutLabelLink.Size = new System.Drawing.Size(68, 24);
            this.logoutLabelLink.TabIndex = 13;
            this.logoutLabelLink.TabStop = true;
            this.logoutLabelLink.Text = "Logout";
            this.logoutLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabelLink_LinkClicked);
            // 
            // loginUsername
            // 
            this.loginUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginUsername.Location = new System.Drawing.Point(3, 6);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(299, 30);
            this.loginUsername.TabIndex = 14;
            this.loginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(614, 457);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(614, 457);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(614, 457);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentsUserControl1
            // 
            this.displayOpenIncidentsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.displayOpenIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.displayOpenIncidentsUserControl1.Name = "displayOpenIncidentsUserControl1";
            this.displayOpenIncidentsUserControl1.Size = new System.Drawing.Size(614, 457);
            this.displayOpenIncidentsUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DashboardTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitForm);
            this.searchIncident.ResumeLayout(false);
            this.loadIncident.ResumeLayout(false);
            this.addIncident.ResumeLayout(false);
            this.DashboardTabControl.ResumeLayout(false);
            this.displayOpenIncidents.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage searchIncident;
        private System.Windows.Forms.TabPage loadIncident;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private System.Windows.Forms.TabPage addIncident;
        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage displayOpenIncidents;
        private UserControls.addIncidentUserControl addIncidentUserControl1;
        private UserControls.searchIncidentUserControl searchIncidentUserControl1;
        private UserControls.displayOpenIncidentsUserControl displayOpenIncidentsUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel logoutLabelLink;
        private System.Windows.Forms.Label loginUsername;
    }
}