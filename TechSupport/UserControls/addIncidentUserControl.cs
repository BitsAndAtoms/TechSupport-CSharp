using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class addIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public addIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }


        /// <param name="e"> e is the even arg</param>
        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = Convert.ToInt32(this.customerIDField.Value);

                this.incidentController.Add(new Model.Incident(title, description, customerID));
                ///((Form)this.TopLevelControl).loadIncidentUserControl1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!\n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cancel the indcident add dialog
        /// </summary>
        /// <param name="sender">sender is the event object</param>
        /// <param name="e"> e is the even arg</param>
        private void resetIncidentTabButton_Click(object sender, EventArgs e)
        {
            this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.customerIDField.Value = 1;

        }


        private void tableLayoutPanelIncident_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
