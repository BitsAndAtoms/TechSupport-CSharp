namespace TechSupport.View
{
    partial class SearchIncidentDialog
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
            this.searchIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.searchCustomerIDField = new System.Windows.Forms.NumericUpDown();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchIncidentTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.searchIncidentTableLayoutPanel.Location = new System.Drawing.Point(59, 44);
            this.searchIncidentTableLayoutPanel.Name = "searchIncidentTableLayoutPanel";
            this.searchIncidentTableLayoutPanel.RowCount = 2;
            this.searchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchIncidentTableLayoutPanel.Size = new System.Drawing.Size(414, 132);
            this.searchIncidentTableLayoutPanel.TabIndex = 0;
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
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(59, 79);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 40);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancleSearchButton_click);
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
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(59, 204);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.Size = new System.Drawing.Size(414, 205);
            this.searchDataGridView.TabIndex = 1;
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.searchIncidentTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Incident";
            this.searchIncidentTableLayoutPanel.ResumeLayout(false);
            this.searchIncidentTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerIDField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchIncidentTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.NumericUpDown searchCustomerIDField;
    }
}