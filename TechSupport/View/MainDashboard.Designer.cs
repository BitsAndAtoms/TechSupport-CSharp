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
            this.addIncidentTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.customerIDField = new System.Windows.Forms.NumericUpDown();
            this.cancelAddIncident = new System.Windows.Forms.Button();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.loadIncident = new System.Windows.Forms.TabPage();
            this.resultTableLabel = new System.Windows.Forms.Label();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.loginUsername = new System.Windows.Forms.Label();
            this.searchIncident = new System.Windows.Forms.TabPage();
            this.searchIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCustomerIDField = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.DashboardTabControl.SuspendLayout();
            this.addIncident.SuspendLayout();
            this.addIncidentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).BeginInit();
            this.loadIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.searchIncident.SuspendLayout();
            this.searchIncidentTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.Controls.Add(this.addIncident);
            this.DashboardTabControl.Controls.Add(this.loadIncident);
            this.DashboardTabControl.Controls.Add(this.searchIncident);
            this.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(536, 432);
            this.DashboardTabControl.TabIndex = 0;
            this.DashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // addIncident
            // 
            this.addIncident.Controls.Add(this.addIncidentTable);
            this.addIncident.Controls.Add(this.cancelAddIncident);
            this.addIncident.Controls.Add(this.addIncidentButton);
            this.addIncident.Location = new System.Drawing.Point(4, 34);
            this.addIncident.Margin = new System.Windows.Forms.Padding(6);
            this.addIncident.Name = "addIncident";
            this.addIncident.Padding = new System.Windows.Forms.Padding(6);
            this.addIncident.Size = new System.Drawing.Size(528, 394);
            this.addIncident.TabIndex = 0;
            this.addIncident.Text = "Add incident";
            this.addIncident.UseVisualStyleBackColor = true;
            this.addIncident.Click += new System.EventHandler(this.addIncident_Click);
            // 
            // addIncidentTable
            // 
            this.addIncidentTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentTable.ColumnCount = 2;
            this.addIncidentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.Controls.Add(this.label3, 0, 2);
            this.addIncidentTable.Controls.Add(this.label2, 0, 1);
            this.addIncidentTable.Controls.Add(this.descriptionTextBox, 1, 1);
            this.addIncidentTable.Controls.Add(this.label4, 0, 0);
            this.addIncidentTable.Controls.Add(this.titleTextBox, 1, 0);
            this.addIncidentTable.Controls.Add(this.customerIDField, 1, 2);
            this.addIncidentTable.Location = new System.Drawing.Point(22, 18);
            this.addIncidentTable.Name = "addIncidentTable";
            this.addIncidentTable.RowCount = 3;
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addIncidentTable.Size = new System.Drawing.Size(485, 255);
            this.addIncidentTable.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incident description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(255, 88);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(217, 79);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incident title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(268, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(191, 29);
            this.titleTextBox.TabIndex = 0;
            // 
            // customerIDField
            // 
            this.customerIDField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDField.Location = new System.Drawing.Point(295, 198);
            this.customerIDField.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.customerIDField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customerIDField.Name = "customerIDField";
            this.customerIDField.Size = new System.Drawing.Size(137, 29);
            this.customerIDField.TabIndex = 6;
            this.customerIDField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerIDField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cancelAddIncident
            // 
            this.cancelAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddIncident.Location = new System.Drawing.Point(298, 288);
            this.cancelAddIncident.Name = "cancelAddIncident";
            this.cancelAddIncident.Size = new System.Drawing.Size(156, 81);
            this.cancelAddIncident.TabIndex = 5;
            this.cancelAddIncident.Text = "Reset";
            this.cancelAddIncident.UseVisualStyleBackColor = true;
            this.cancelAddIncident.Click += new System.EventHandler(this.resetIncidentTabButton_Click);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(41, 288);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(156, 81);
            this.addIncidentButton.TabIndex = 4;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // loadIncident
            // 
            this.loadIncident.Controls.Add(this.resultTableLabel);
            this.loadIncident.Controls.Add(this.incidentDataGridView);
            this.loadIncident.Controls.Add(this.linkLabelLogout);
            this.loadIncident.Controls.Add(this.loginUsername);
            this.loadIncident.Location = new System.Drawing.Point(4, 34);
            this.loadIncident.Margin = new System.Windows.Forms.Padding(6);
            this.loadIncident.Name = "loadIncident";
            this.loadIncident.Padding = new System.Windows.Forms.Padding(6);
            this.loadIncident.Size = new System.Drawing.Size(528, 394);
            this.loadIncident.TabIndex = 1;
            this.loadIncident.Text = "Load incident";
            this.loadIncident.UseVisualStyleBackColor = true;
            this.loadIncident.Click += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // resultTableLabel
            // 
            this.resultTableLabel.AutoSize = true;
            this.resultTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTableLabel.Location = new System.Drawing.Point(57, 74);
            this.resultTableLabel.Name = "resultTableLabel";
            this.resultTableLabel.Size = new System.Drawing.Size(183, 20);
            this.resultTableLabel.TabIndex = 11;
            this.resultTableLabel.Text = "Incidents recorded  :";
            this.resultTableLabel.Click += new System.EventHandler(this.resultTableLabel_Click);
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Location = new System.Drawing.Point(49, 97);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.Size = new System.Drawing.Size(409, 268);
            this.incidentDataGridView.TabIndex = 9;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(418, 44);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(68, 24);
            this.linkLabelLogout.TabIndex = 7;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginUsername.Location = new System.Drawing.Point(164, 45);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(248, 23);
            this.loginUsername.TabIndex = 6;
            this.loginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchIncident
            // 
            this.searchIncident.Controls.Add(this.searchIncidentTableLayoutPanel);
            this.searchIncident.Controls.Add(this.searchDataGridView);
            this.searchIncident.Location = new System.Drawing.Point(4, 34);
            this.searchIncident.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncident.Name = "searchIncident";
            this.searchIncident.Size = new System.Drawing.Size(528, 394);
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
            this.searchIncidentTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchIncidentTableLayoutPanel_Paint);
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
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 432);
            this.Controls.Add(this.DashboardTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitForm);
            this.DashboardTabControl.ResumeLayout(false);
            this.addIncident.ResumeLayout(false);
            this.addIncidentTable.ResumeLayout(false);
            this.addIncidentTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).EndInit();
            this.loadIncident.ResumeLayout(false);
            this.loadIncident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.searchIncident.ResumeLayout(false);
            this.searchIncidentTableLayoutPanel.ResumeLayout(false);
            this.searchIncidentTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage addIncident;
        private System.Windows.Forms.TabPage loadIncident;
        private System.Windows.Forms.TabPage searchIncident;
        private System.Windows.Forms.TableLayoutPanel searchIncidentTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown searchCustomerIDField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.TableLayoutPanel addIncidentTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.NumericUpDown customerIDField;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Label resultTableLabel;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label loginUsername;
        private System.Windows.Forms.Button cancelAddIncident;
        private System.Windows.Forms.Button Cancel;
    }
}