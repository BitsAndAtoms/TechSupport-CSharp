using System;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class searchIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// constructor for the searchIncidentUserControl form
        /// </summary>
        public searchIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// populate dataGrid table for search dialog based on customerID
        /// Search here calls up on the three method chained to incidinetDAL
        /// </summary>
        /// <param name="customerID"></param>
        private void RefreshDataGrid(int customerID)
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource = this.incidentController.Search(customerID)
                .Select(o=> new {customerID = o.CustomerID,
               incidentTitle = o.Title, IncidentDescription = o.Description})
               .ToList();
        }

        /// <summary>
        /// search button to acquire incident record based on customer ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(this.searchCustomerIDField.Value);
                this.RefreshDataGrid(customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!\n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// reset search tab value to 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetSearchTabButton_click(object sender, EventArgs e)
        {
            this.searchCustomerIDField.Value = 1;
        }

    }
}
