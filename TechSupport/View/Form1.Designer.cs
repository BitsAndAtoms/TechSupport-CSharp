namespace TechSupport.View
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label technicianNameLabel;
            this.technicianNameTextBox = new System.Windows.Forms.TextBox();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            technicianNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // technicianNameLabel
            // 
            technicianNameLabel.AutoSize = true;
            technicianNameLabel.Location = new System.Drawing.Point(59, 61);
            technicianNameLabel.Name = "technicianNameLabel";
            technicianNameLabel.Size = new System.Drawing.Size(94, 13);
            technicianNameLabel.TabIndex = 17;
            technicianNameLabel.Text = "Technician Name:";
            // 
            // technicianNameTextBox
            // 
            this.technicianNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "TechnicianName", true));
            this.technicianNameTextBox.Location = new System.Drawing.Point(172, 58);
            this.technicianNameTextBox.Name = "technicianNameTextBox";
            this.technicianNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.technicianNameTextBox.TabIndex = 18;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(TechSupport.Model.Incident);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(technicianNameLabel);
            this.Controls.Add(this.technicianNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.TextBox technicianNameTextBox;
    }
}