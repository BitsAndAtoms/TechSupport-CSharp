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
    public partial class searchIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public searchIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// populate dataGrid table for search dialog based on customerID
        /// </summary>
        /// <param name="customerID"></param>
        private void RefreshDataGrid(int customerID)
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource = this.incidentController.Search(customerID); ;
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
