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
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.addIncident = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.addIncidentUserControl();
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidents = new System.Windows.Forms.TabPage();
            this.openIncidents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchIncidentUserControl1 = new TechSupport.UserControls.searchIncidentUserControl();
            this.searchIncident.SuspendLayout();
            this.loadIncident.SuspendLayout();
            this.addIncident.SuspendLayout();
            this.DashboardTabControl.SuspendLayout();
            this.displayOpenIncidents.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchIncident
            // 
            this.searchIncident.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncident.Location = new System.Drawing.Point(4, 34);
            this.searchIncident.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(614, 429);
            this.searchIncident.TabIndex = 2;
            this.searchIncident.Text = "Search incident";
            this.searchIncident.UseVisualStyleBackColor = true;
            // 
            // loadIncident
            // 
            this.loadIncident.Controls.Add(this.loadIncidentUserControl1);
            this.loadIncident.Location = new System.Drawing.Point(4, 34);
            this.loadIncident.Name = "loadIncident";
            this.loadIncident.Size = new System.Drawing.Size(614, 429);
            this.loadIncident.TabIndex = 3;
            this.loadIncident.Text = "Load Incident";
            this.loadIncident.UseVisualStyleBackColor = true;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(36, 6);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(483, 417);
            this.loadIncidentUserControl1.TabIndex = 0;
            this.loadIncidentUserControl1.Load += new System.EventHandler(this.loadIncidentUserControl1_Load);
            // 
            // addIncident
            // 
            this.addIncident.Controls.Add(this.addIncidentUserControl1);
            this.addIncident.Location = new System.Drawing.Point(4, 34);
            this.addIncident.Name = "addIncident";
            this.addIncident.Size = new System.Drawing.Size(614, 429);
            this.addIncident.TabIndex = 4;
            this.addIncident.Text = "Add Incident";
            this.addIncident.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(29, 6);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(507, 408);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.CausesValidation = false;
            this.DashboardTabControl.Controls.Add(this.addIncident);
            this.DashboardTabControl.Controls.Add(this.loadIncident);
            this.DashboardTabControl.Controls.Add(this.searchIncident);
            this.DashboardTabControl.Controls.Add(this.displayOpenIncidents);
            this.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(622, 467);
            this.DashboardTabControl.TabIndex = 0;
            this.DashboardTabControl.TabStop = false;
            this.DashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // displayOpenIncidents
            // 
            this.displayOpenIncidents.Controls.Add(this.openIncidents);
            this.displayOpenIncidents.Location = new System.Drawing.Point(4, 34);
            this.displayOpenIncidents.Name = "displayOpenIncidents";
            this.displayOpenIncidents.Size = new System.Drawing.Size(614, 429);
            this.displayOpenIncidents.TabIndex = 5;
            this.displayOpenIncidents.Text = "Display Open Incidents";
            this.displayOpenIncidents.UseVisualStyleBackColor = true;
            // 
            // openIncidents
            // 
            this.openIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.openIncidents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidents.Location = new System.Drawing.Point(0, 0);
            this.openIncidents.Name = "openIncidents";
            this.openIncidents.Size = new System.Drawing.Size(614, 429);
            this.openIncidents.TabIndex = 1;
            this.openIncidents.UseCompatibleStateImageBehavior = false;
            this.openIncidents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "customerID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "description";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "technician Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(63, 38);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(390, 321);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 467);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage searchIncident;
        private System.Windows.Forms.TabPage loadIncident;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private System.Windows.Forms.TabPage addIncident;
        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage displayOpenIncidents;
        private System.Windows.Forms.ListView openIncidents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private UserControls.addIncidentUserControl addIncidentUserControl1;
        private UserControls.searchIncidentUserControl searchIncidentUserControl1;
    }
}