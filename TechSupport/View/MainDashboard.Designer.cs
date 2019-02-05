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
            this.searchIncidentUserControl1 = new TechSupport.UserControls.searchIncidentUserControl();
            this.loadIncident = new System.Windows.Forms.TabPage();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.addIncident = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.addIncidentUserControl();
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidents = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl1 = new TechSupport.UserControls.displayOpenIncidentsUserControl();
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
            this.searchIncident.Location = new System.Drawing.Point(4, 29);
            this.searchIncident.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(614, 434);
            this.searchIncident.TabIndex = 2;
            this.searchIncident.Text = "Search incident";
            this.searchIncident.UseVisualStyleBackColor = true;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(614, 434);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // loadIncident
            // 
            this.loadIncident.Controls.Add(this.loadIncidentUserControl1);
            this.loadIncident.Location = new System.Drawing.Point(4, 29);
            this.loadIncident.Name = "loadIncident";
            this.loadIncident.Size = new System.Drawing.Size(614, 434);
            this.loadIncident.TabIndex = 3;
            this.loadIncident.Text = "Load Incident";
            this.loadIncident.UseVisualStyleBackColor = true;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(614, 434);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // addIncident
            // 
            this.addIncident.Controls.Add(this.addIncidentUserControl1);
            this.addIncident.Location = new System.Drawing.Point(4, 29);
            this.addIncident.Name = "addIncident";
            this.addIncident.Size = new System.Drawing.Size(614, 434);
            this.addIncident.TabIndex = 4;
            this.addIncident.Text = "Add Incident";
            this.addIncident.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(614, 434);
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
            this.DashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.displayOpenIncidents.Controls.Add(this.displayOpenIncidentsUserControl1);
            this.displayOpenIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOpenIncidents.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidents.Name = "displayOpenIncidents";
            this.displayOpenIncidents.Size = new System.Drawing.Size(614, 434);
            this.displayOpenIncidents.TabIndex = 5;
            this.displayOpenIncidents.Text = "Display Open Incidents";
            this.displayOpenIncidents.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsUserControl1
            // 
            this.displayOpenIncidentsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.displayOpenIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.displayOpenIncidentsUserControl1.Name = "displayOpenIncidentsUserControl1";
            this.displayOpenIncidentsUserControl1.Size = new System.Drawing.Size(614, 434);
            this.displayOpenIncidentsUserControl1.TabIndex = 0;
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
        private UserControls.addIncidentUserControl addIncidentUserControl1;
        private UserControls.searchIncidentUserControl searchIncidentUserControl1;
        private UserControls.displayOpenIncidentsUserControl displayOpenIncidentsUserControl1;
    }
}