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
using TechSupport.Model;

namespace TechSupport.View
{
    
    public partial class Form1 : Form
    {
        private TechnicianController newTechnicianController;
        private List<Technician> technicianList;
        public Form1()
        {
            InitializeComponent();
            newTechnicianController = new TechnicianController();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }
    }
}
