using System;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class updateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// constructor for the searchIncidentUserControl form
        /// </summary>
        public updateIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

       
    }
}
