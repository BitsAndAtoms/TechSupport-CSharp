using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Class IncidentDAL maintains a list of customer incidents\
    /// and provides methods to add, get and search incidents.
    /// </summary>
    public class IncidentDAL
    {
        private static List<Incident> _customerIncidents = new List<Incident>
        {
            new Incident("PC Maintainence","Computer is faulty and not turning on.",101),
            new Incident("Software upgrade","OS needs to be updated by tech support.",23),
        };

        /// <summary>
        /// method that returns current incidents list
        /// </summary>
        /// <returns>returns list of incidents</returns>
        public List<Incident> GETCustomerIncidents()
        {
            return _customerIncidents;
        }

        /// <summary>
        /// method to add incident to the _customerIncidents list
        /// </summary>
        /// <param name="incident">The incident to be added</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident can not be null");
            }
            _customerIncidents.Add(incident);
        }

        /// <summary>
        /// This method returns sublist which contains incidents with 
        /// a given customer ID
        /// </summary>
        /// <param name="customerID">The customerID which will be searched in the list</param>
        /// <returns></returns>
        public List<Incident> Search(int customerID)
        {
           return _customerIncidents.Where(incident => incident.CustomerID == customerID).ToList();
        }
    }
}
