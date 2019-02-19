using System;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class updateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// constructor for the searchIncidentUserControl form
        /// </summary>
        public updateIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void getIncidentButton_Click(object sender, EventArgs e)
        {
            Incident newIncident = new Incident();
            try
            {
                newIncident.IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text);
                newIncident = this.incidentController.getIncidentFromDBbyID(newIncident);

                if (newIncident.CustomerName == null)
                {
                    throw new System.ArgumentException("No incident found for the selected ID");
                }
                else
                {
                    this.customerNameTextBox.Text= newIncident.CustomerName;
                    this.descriptionTextBox.Text = newIncident.Description;
                    this.titleTextBox.Text = newIncident.Title;
                    this.dateOpenedTextBox.Text = newIncident.DateOpened;
                    this.productNameTextBox.Text = newIncident.ProductCode;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Input must be a numeric integer\n" + ex.Message,
                    "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Incident newIncident = new Incident();
            newIncident.IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text);
            newIncident = this.incidentController.getIncidentFromDBbyID(newIncident);
            
            newIncident.Description = newIncident.Description + this.editDescriptionTextBox.Text;
            this.incidentController.updateIncidentInDB(newIncident);
        }
    }
}
