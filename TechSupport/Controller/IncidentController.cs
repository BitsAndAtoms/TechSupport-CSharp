using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This controller class interacts with the incident data source
    /// and performs all the operations on the incident data source.
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL incidentSource;

        /// <summary>
        /// constructor for incident controller 
        /// instantiates a incident DAL object
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// method to access the list of customer incidents
        /// maintained by the DAL
        /// </summary>
        /// <returns>Current list of incidents </returns>
        public List<Incident> GetCustomerIncidents()
        {
            return this.incidentSource.GETCustomerIncidents();
        }

        /// <summary>
        /// method to add a new incident to the incident list
        /// </summary>
        /// <param name="incident"> The incident to be added to the list</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident can not be null");
            }
            this.incidentSource.Add(incident);
        }

        /// <summary>
        /// method to search customerID in incidents list
        /// 
        /// </summary>
        /// <param name="customerID"> the customerID searched</param>
        /// <returns>The list of incidents for input customer ID</returns>
        public List<Incident> Search(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("customerID needs to be greater than 0");
            }

            return this.incidentSource.Search(customerID);
        }

    }
}
