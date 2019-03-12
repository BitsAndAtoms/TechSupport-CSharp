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
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class viewIncidentsByTechnician : UserControl
    {
        private TechnicianController newTechnicianController;
        private IncidentController newIncidentController;
        private List<Technician> technicianList;
        private List<Incident> incidentList;
        public viewIncidentsByTechnician()
        {
            InitializeComponent();
            newTechnicianController = new TechnicianController();
            newIncidentController = new IncidentController();
        }

        private void viewIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            this.technicianList = newTechnicianController.GETTechnicianListFromDBWithOpenIncidents();
            technicianNameComboBox.DataSource = technicianList;
        }

        private void technicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (technicianNameComboBox.SelectedIndex < 0)
            {
                return;
            }
            Technician technician = this.technicianList[technicianNameComboBox.SelectedIndex];

            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
            incidentBindingSource.Clear();
            this.incidentList = this.newIncidentController.GetOpenDBIncidentsForTechnicianID(technician);
            incidentBindingSource.DataSource = incidentList;
        }
    }
}
