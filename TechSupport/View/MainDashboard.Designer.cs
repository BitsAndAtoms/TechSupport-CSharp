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
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.addIncident = new System.Windows.Forms.TabPage();
            this.loadIncident = new System.Windows.Forms.TabPage();
            this.searchIncident = new System.Windows.Forms.TabPage();
            this.DashboardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.Controls.Add(this.addIncident);
            this.DashboardTabControl.Controls.Add(this.loadIncident);
            this.DashboardTabControl.Controls.Add(this.searchIncident);
            this.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(801, 501);
            this.DashboardTabControl.TabIndex = 0;
            // 
            // addIncident
            // 
            this.addIncident.Location = new System.Drawing.Point(4, 22);
            this.addIncident.Name = "addIncident";
            this.addIncident.Padding = new System.Windows.Forms.Padding(3);
            this.addIncident.Size = new System.Drawing.Size(793, 475);
            this.addIncident.TabIndex = 0;
            this.addIncident.Text = "Add incident";
            this.addIncident.UseVisualStyleBackColor = true;
            // 
            // loadIncident
            // 
            this.loadIncident.Location = new System.Drawing.Point(4, 22);
            this.loadIncident.Name = "loadIncident";
            this.loadIncident.Padding = new System.Windows.Forms.Padding(3);
            this.loadIncident.Size = new System.Drawing.Size(793, 475);
            this.loadIncident.TabIndex = 1;
            this.loadIncident.Text = "Load incident";
            this.loadIncident.UseVisualStyleBackColor = true;
            // 
            // searchIncident
            // 
            this.searchIncident.Location = new System.Drawing.Point(4, 22);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(793, 475);
            this.searchIncident.TabIndex = 2;
            this.searchIncident.Text = "Search incident";
            this.searchIncident.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 501);
            this.Controls.Add(this.DashboardTabControl);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.DashboardTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage addIncident;
        private System.Windows.Forms.TabPage loadIncident;
        private System.Windows.Forms.TabPage searchIncident;
    }
}