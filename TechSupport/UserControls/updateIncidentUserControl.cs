using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class updateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        private int IncidentID;
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
            this.updateButton.Enabled = true;
            this.closeButton.Enabled = true;
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
                    List<string> TechnicianList = new System.Collections.Generic.List<string>(this.incidentController.GETTechnicianListFromDB());
                    TechnicianList.Insert(0, "--Unassigned--");
                    this.technicianNameComboBox.DataSource = TechnicianList;
                    this.technicianNameComboBox.SelectedIndex = Math.Max(this.technicianNameComboBox.Items.IndexOf(newIncident.TechnicianName),0);
                    this.IncidentID = newIncident.IncidentID;
                    
                }
            }
            catch (Exception ex)
            {
                this.clearButton_Click(null, null);
                MessageBox.Show("" + ex.Message,
                    "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to update the record based on entered incident data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            Incident newIncident = new Incident(); 
            newIncident.IncidentID = this.IncidentID;

            try
            {
                if (string.IsNullOrEmpty(this.editDescriptionTextBox.Text)){
                    throw new System.ArgumentException("Text to add field can not be empty ");
                }
                newIncident=this.incidentController.getIncidentFromDBbyID(newIncident);
                newIncident.Description = newIncident.Description + Environment.NewLine  + "<" +
                    DateTime.Today.ToString("MM/dd/yyyy") + ">" +
                    this.editDescriptionTextBox.Text;
                if (newIncident.Description.Length > 200)
                {
                    DialogResult dialogResult = MessageBox.Show("Only 200 character allowed. New description will be truncated", "Character limit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        newIncident.Description = newIncident.Description.Substring(0, 200);
                        if (this.technicianNameComboBox.SelectedIndex != 0)
                        {
                            newIncident.TechnicianName = this.technicianNameComboBox.Text;
                        }
                        this.incidentController.updateIncidentInDB(newIncident);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else {
                    if (this.technicianNameComboBox.SelectedIndex != 0)
                    {
                        newIncident.TechnicianName = this.technicianNameComboBox.Text;
                    }
                    this.incidentController.updateIncidentInDB(newIncident);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message,
                    "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.technicianNameComboBox.DataSource = null;
            this.incidentIDTextBox.Text = "";
            this.customerNameTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.dateOpenedTextBox.Text = "";
            this.productNameTextBox.Text = "";
            this.editDescriptionTextBox.Text = "";
        }
    }
}
