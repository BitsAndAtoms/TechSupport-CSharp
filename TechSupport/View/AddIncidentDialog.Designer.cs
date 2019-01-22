namespace TechSupport.View
{
    partial class AddIncidentDialog
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
            this.addIncidentTable = new System.Windows.Forms.TableLayoutPanel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancelAddIncident = new System.Windows.Forms.Button();
            this.addIncidentTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // addIncidentTable
            // 
            this.addIncidentTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentTable.ColumnCount = 2;
            this.addIncidentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.Controls.Add(this.label3, 0, 2);
            this.addIncidentTable.Controls.Add(this.label2, 0, 1);
            this.addIncidentTable.Controls.Add(this.titleTextBox, 1, 0);
            this.addIncidentTable.Controls.Add(this.descriptionTextBox, 1, 1);
            this.addIncidentTable.Controls.Add(this.customerIDTextBox, 1, 2);
            this.addIncidentTable.Controls.Add(this.label1, 0, 0);
            this.addIncidentTable.Location = new System.Drawing.Point(12, 12);
            this.addIncidentTable.Name = "addIncidentTable";
            this.addIncidentTable.RowCount = 3;
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.addIncidentTable.Size = new System.Drawing.Size(485, 255);
            this.addIncidentTable.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Location = new System.Drawing.Point(268, 16);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(191, 53);
            this.titleTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(268, 101);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(191, 53);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDTextBox.Location = new System.Drawing.Point(268, 190);
            this.customerIDTextBox.Multiline = true;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(191, 45);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Incident title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incident description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CustomerID";
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Location = new System.Drawing.Point(26, 288);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(156, 81);
            this.addIncidentButton.TabIndex = 1;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // cancelAddIncident
            // 
            this.cancelAddIncident.Location = new System.Drawing.Point(298, 288);
            this.cancelAddIncident.Name = "cancelAddIncident";
            this.cancelAddIncident.Size = new System.Drawing.Size(173, 81);
            this.cancelAddIncident.TabIndex = 2;
            this.cancelAddIncident.Text = "Cancel";
            this.cancelAddIncident.UseVisualStyleBackColor = true;
            this.cancelAddIncident.Click += new System.EventHandler(this.cancelIncidentAddButton_Click);
            // 
            // AddIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 382);
            this.Controls.Add(this.cancelAddIncident);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.addIncidentTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.AddIncidentDialog_Load);
            this.addIncidentTable.ResumeLayout(false);
            this.addIncidentTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addIncidentTable;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelAddIncident;
    }
}