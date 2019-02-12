using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class addIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// constructor for add incident user control form
        /// </summary>
        public addIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.LoadCustomerNameComboBox();
        }

        /// <summary>
        /// Add incident button adds the incident to the test data list or 
        /// throws the necessary exception
        /// </summary>
        ///param name="e"> e is the even arg</param>
        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Incident newIncident = new Incident();
                newIncident.Title = this.titleTextBox.Text;
                newIncident.Description = this.descriptionTextBox.Text;
                newIncident.CustomerName = this.customerNameComboBox.SelectedValue.ToString();
                newIncident.ProductName = this.productNameComboBox.SelectedValue.ToString();
                newIncident.DateOpened = DateTime.Now.ToString();
                this.incidentController.AddIncidentToDB(newIncident);
               /// this.incidentController.Add(new Model.Incident(title, description, customerID));
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
            ///this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            //this.customerIDField.Value = 1;
        }

        private void LoadProductNameComboBox()
        {
            this.productNameComboBox.DataSource = null;
            List<string> valueList = new List<string>(this.incidentController.GetRegisteredDBCustomersAndProducts()[this.customerNameComboBox.SelectedValue.ToString()]);
            this.productNameComboBox.DataSource = valueList;
        }

        private void LoadCustomerNameComboBox()
        {

            this.customerNameComboBox.DataSource = null;
            List<string> keyList = new List<string>(this.incidentController.GetRegisteredDBCustomersAndProducts().Keys);
            this.customerNameComboBox.DataSource = keyList;
            this.LoadProductNameComboBox();
        }

        private void customerNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            this.LoadProductNameComboBox();
        }

    }
}
