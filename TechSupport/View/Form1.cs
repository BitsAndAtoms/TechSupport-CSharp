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
        public Form1()
        {
            InitializeComponent();
            newTechnicianController = new TechnicianController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Technician> technicianList = newTechnicianController.GETTechnicianListFromDBWithOpenIncidents();
            technicianNameComboBox.DataSource = technicianList;



        }
    }
}
