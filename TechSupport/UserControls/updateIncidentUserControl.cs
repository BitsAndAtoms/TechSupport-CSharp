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
            newIncident.IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text);
            newIncident=this.incidentController.getIncidentFromDBbyID(newIncident);
            this.descriptionTextBox.Text = newIncident.Description;
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
