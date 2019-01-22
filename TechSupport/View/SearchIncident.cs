using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// searchIncidentDialog class makes a dialog to search incidents based on customer ID
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// constructor for searchIncidentDialog class
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// cancel the search and return to main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancleSearchButton_click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
        /// populate dataGrid table for search dialog based on customerID
        /// </summary>
        /// <param name="customerID"></param>
        private void RefreshDataGrid(int customerID)
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource =  this.incidentController.Search(customerID);;
        }


    }
}
