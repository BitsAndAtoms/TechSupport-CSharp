namespace TechSupport.UserControls
{
    partial class LoadIncidentUserControl
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
            this.resultTableLabel = new System.Windows.Forms.Label();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.loginUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTableLabel
            // 
            this.resultTableLabel.AutoSize = true;
            this.resultTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTableLabel.Location = new System.Drawing.Point(15, 47);
            this.resultTableLabel.Name = "resultTableLabel";
            this.resultTableLabel.Size = new System.Drawing.Size(183, 20);
            this.resultTableLabel.TabIndex = 15;
            this.resultTableLabel.Text = "Incidents recorded  :";
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Location = new System.Drawing.Point(9, 70);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.Size = new System.Drawing.Size(223, 140);
            this.incidentDataGridView.TabIndex = 14;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(175, 23);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(68, 24);
            this.linkLabelLogout.TabIndex = 13;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginUsername.Location = new System.Drawing.Point(15, 23);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(166, 24);
            this.loginUsername.TabIndex = 12;
            this.loginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.resultTableLabel);
            this.Controls.Add(this.incidentDataGridView);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.loginUsername);
            this.Name = "LoadIncidentUserControl";
            this.Size = new System.Drawing.Size(250, 258);
            this.Load += new System.EventHandler(this.LoadIncidentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultTableLabel;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label loginUsername;
    }
}
