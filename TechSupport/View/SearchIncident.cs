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
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancleSearchButton_click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void searchButton_click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(this.searchCustomerIDField.Value);
                this.RefreshDataGrid(customerID);
                
                //DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!\n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RefreshDataGrid(int customerID)
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource =  this.incidentController.Search(customerID);;
        }


    }
}
