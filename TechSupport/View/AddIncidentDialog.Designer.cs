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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.customerIDField = new System.Windows.Forms.NumericUpDown();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancelAddIncident = new System.Windows.Forms.Button();
            this.addIncidentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).BeginInit();
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
            this.addIncidentTable.Controls.Add(this.descriptionTextBox, 1, 1);
            this.addIncidentTable.Controls.Add(this.label1, 0, 0);
            this.addIncidentTable.Controls.Add(this.titleTextBox, 1, 0);
            this.addIncidentTable.Controls.Add(this.customerIDField, 1, 2);
            this.addIncidentTable.Location = new System.Drawing.Point(12, 12);
            this.addIncidentTable.Name = "addIncidentTable";
            this.addIncidentTable.RowCount = 3;
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.addIncidentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addIncidentTable.Size = new System.Drawing.Size(485, 255);
            this.addIncidentTable.TabIndex = 0;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Incident title";
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
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(31, 289);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(156, 81);
            this.addIncidentButton.TabIndex = 1;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // cancelAddIncident
            // 
            this.cancelAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddIncident.Location = new System.Drawing.Point(288, 289);
            this.cancelAddIncident.Name = "cancelAddIncident";
            this.cancelAddIncident.Size = new System.Drawing.Size(156, 81);
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
            this.addIncidentTable.ResumeLayout(false);
            this.addIncidentTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addIncidentTable;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelAddIncident;
        private System.Windows.Forms.NumericUpDown customerIDField;
    }
}