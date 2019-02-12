using System;
using System.Windows.Forms;
using TechSupport.Controller;

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
                ///var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = Convert.ToInt32(this.customerIDField.Value);
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
            this.customerIDField.Value = 1;
        }


    }
}
