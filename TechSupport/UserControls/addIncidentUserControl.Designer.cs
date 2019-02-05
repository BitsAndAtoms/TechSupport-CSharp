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
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDField = new System.Windows.Forms.NumericUpDown();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancelAddIncident = new System.Windows.Forms.Button();
            this.tableLayoutPanelIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDField)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelIncident
            // 
            this.tableLayoutPanelIncident.ColumnCount = 2;
            this.tableLayoutPanelIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.Controls.Add(this.cancelAddIncident, 0, 3);
            this.tableLayoutPanelIncident.Controls.Add(this.descriptionTextBox, 1, 1);
            this.tableLayoutPanelIncident.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelIncident.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanelIncident.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelIncident.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelIncident.Controls.Add(this.customerIDField, 1, 2);
            this.tableLayoutPanelIncident.Controls.Add(this.addIncidentButton, 0, 3);
            this.tableLayoutPanelIncident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIncident.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelIncident.Name = "tableLayoutPanelIncident";
            this.tableLayoutPanelIncident.RowCount = 4;
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanelIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelIncident.Size = new System.Drawing.Size(507, 408);
            this.tableLayoutPanelIncident.TabIndex = 0;
            this.tableLayoutPanelIncident.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelIncident_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 141);
            this.label4.TabIndex = 4;
            this.label4.Text = "Incident title";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(256, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(248, 29);
            this.titleTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 141);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incident description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(256, 144);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(248, 79);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 72);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerID";
            // 
            // customerIDField
            // 
            this.customerIDField.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDField.Location = new System.Drawing.Point(256, 285);
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
            this.addIncidentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(94, 357);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(156, 48);
            this.addIncidentButton.TabIndex = 10;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // cancelAddIncident
            // 
            this.cancelAddIncident.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddIncident.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cancelAddIncident.Location = new System.Drawing.Point(386, 357);
            this.cancelAddIncident.Name = "cancelAddIncident";
            this.cancelAddIncident.Size = new System.Drawing.Size(118, 48);
            this.cancelAddIncident.TabIndex = 11;
            this.cancelAddIncident.Text = "Reset";
            this.cancelAddIncident.UseVisualStyleBackColor = true;
            this.cancelAddIncident.Click += new System.EventHandler(this.resetIncidentTabButton_Click);
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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown customerIDField;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelAddIncident;
    }
}
