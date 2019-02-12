namespace TechSupport.UserControls
{
    partial class addIncidentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelIncident = new System.Windows.Forms.TableLayoutPanel();
            this.cancelAddIncident = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDField = new System.Windows.Forms.NumericUpDown();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelIncident
            // 
            this.tableLayoutPanelIncident.ColumnCount = 2;
            this.tableLayoutPanelIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.Controls.Add(this.cancelAddIncident, 0, 4);
            this.tableLayoutPanelIncident.Controls.Add(this.descriptionTextBox, 1, 2);
            this.tableLayoutPanelIncident.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelIncident.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanelIncident.Controls.Add(this.customerIDField, 1, 3);
            this.tableLayoutPanelIncident.Controls.Add(this.addIncidentButton, 0, 4);
            this.tableLayoutPanelIncident.Controls.Add(this.customerNameComboBox, 1, 0);
            this.tableLayoutPanelIncident.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelIncident.Controls.Add(this.productLabel, 0, 1);
            this.tableLayoutPanelIncident.Controls.Add(this.productNameComboBox, 1, 1);
            this.tableLayoutPanelIncident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIncident.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelIncident.Name = "tableLayoutPanelIncident";
            this.tableLayoutPanelIncident.RowCount = 5;
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.71585F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.28415F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIncident.Size = new System.Drawing.Size(507, 408);
            this.tableLayoutPanelIncident.TabIndex = 0;
            // 
            // cancelAddIncident
            // 
            this.cancelAddIncident.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddIncident.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cancelAddIncident.Location = new System.Drawing.Point(80, 375);
            this.cancelAddIncident.Name = "cancelAddIncident";
            this.cancelAddIncident.Size = new System.Drawing.Size(92, 29);
            this.cancelAddIncident.TabIndex = 11;
            this.cancelAddIncident.Text = "Reset";
            this.cancelAddIncident.UseVisualStyleBackColor = true;
            this.cancelAddIncident.Click += new System.EventHandler(this.resetIncidentTabButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(256, 181);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(248, 97);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incident description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Incident title";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerID";
            // 
            // customerIDField
            // 
            this.customerIDField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDField.Location = new System.Drawing.Point(256, 312);
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
            this.customerIDField.Size = new System.Drawing.Size(248, 29);
            this.customerIDField.TabIndex = 9;
            this.customerIDField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerIDField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(334, 375);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(92, 29);
            this.addIncidentButton.TabIndex = 10;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(271, 38);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(218, 21);
            this.customerNameComboBox.TabIndex = 12;
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(84, 126);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(85, 24);
            this.productLabel.TabIndex = 13;
            this.productLabel.Text = "Product :";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(272, 127);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(216, 21);
            this.productNameComboBox.TabIndex = 14;
            // 
            // addIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelIncident);
            this.Name = "addIncidentUserControl";
            this.Size = new System.Drawing.Size(507, 408);
            this.tableLayoutPanelIncident.ResumeLayout(false);
            this.tableLayoutPanelIncident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIncident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown customerIDField;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelAddIncident;
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productNameComboBox;
    }
}
