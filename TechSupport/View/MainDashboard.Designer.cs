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
            this.searchIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCustomerIDField = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.loadIncident = new System.Windows.Forms.TabPage();
            this.addIncident = new System.Windows.Forms.TabPage();
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidents = new System.Windows.Forms.TabPage();
            this.openIncidents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.addIncidentUserControl1 = new TechSupport.UserControls.addIncidentUserControl();
            this.searchIncident.SuspendLayout();
            this.searchIncidentTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.loadIncident.SuspendLayout();
            this.addIncident.SuspendLayout();
            this.DashboardTabControl.SuspendLayout();
            this.displayOpenIncidents.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchIncident
            // 
            this.searchIncident.Controls.Add(this.searchIncidentTableLayoutPanel);
            this.searchIncident.Controls.Add(this.searchDataGridView);
            this.searchIncident.Location = new System.Drawing.Point(4, 34);
            this.searchIncident.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(614, 429);
            this.searchIncident.TabIndex = 2;
            this.searchIncident.Text = "Search incident";
            this.searchIncident.UseVisualStyleBackColor = true;
            // 
            // searchIncidentTableLayoutPanel
            // 
            this.searchIncidentTableLayoutPanel.ColumnCount = 2;
            this.searchIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.searchIncidentTableLayoutPanel.Controls.Add(this.searchCustomerIDField, 1, 0);
            this.searchIncidentTableLayoutPanel.Controls.Add(this.Cancel, 0, 1);
            this.searchIncidentTableLayoutPanel.Controls.Add(this.searchButton, 1, 1);
            this.searchIncidentTableLayoutPanel.Location = new System.Drawing.Point(56, 21);
            this.searchIncidentTableLayoutPanel.Name = "searchIncidentTableLayoutPanel";
            this.searchIncidentTableLayoutPanel.RowCount = 2;
            this.searchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.Size = new System.Drawing.Size(414, 132);
            this.searchIncidentTableLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // searchCustomerIDField
            // 
            this.searchCustomerIDField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchCustomerIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDField.Location = new System.Drawing.Point(250, 18);
            this.searchCustomerIDField.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.searchCustomerIDField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchCustomerIDField.Name = "searchCustomerIDField";
            this.searchCustomerIDField.Size = new System.Drawing.Size(120, 29);
            this.searchCustomerIDField.TabIndex = 4;
            this.searchCustomerIDField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchCustomerIDField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(59, 79);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 40);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Reset";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.resetSearchTabButton_click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(258, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 40);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Button";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(56, 181);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.Size = new System.Drawing.Size(414, 205);
            this.searchDataGridView.TabIndex = 3;
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
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(29, 6);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(507, 408);
            this.addIncidentUserControl1.TabIndex = 0;
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
            this.searchIncidentTableLayoutPanel.ResumeLayout(false);
            this.searchIncidentTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.loadIncident.ResumeLayout(false);
            this.addIncident.ResumeLayout(false);
            this.DashboardTabControl.ResumeLayout(false);
            this.displayOpenIncidents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage searchIncident;
        private System.Windows.Forms.TableLayoutPanel searchIncidentTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown searchCustomerIDField;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
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
    }
}