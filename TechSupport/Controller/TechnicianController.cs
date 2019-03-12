using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class TechnicianController
    {
        private TechnicianDBDAL TechnicianDBSource;
        /// <summary>
        /// constructor for Technician controller 
        /// instantiates a Technician DAL object
        /// </summary>
        public TechnicianController()
        {

            this.TechnicianDBSource = new TechnicianDBDAL();
        }

        /// <summary>
        /// method to access the list of technicians available in DB
        /// which have 
        /// </summary>
        /// <returns>Current list of technicians </returns>
        public List<Technician> GETTechnicianListFromDBWithOpenIncidents()
        {
            return this.TechnicianDBSource.GETTechnicianWithOpenIncidents();
        }

    }
}
