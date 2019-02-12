using System;
using System.Collections.Generic;
using System.Linq;
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
            addIncidentDetails("PC Maintainence","Computer is faulty and not turning on.",101),
            addIncidentDetails("Software upgrade","OS needs to be updated by tech support.",23),
        };


        private static Incident addIncidentDetails(string Title, string description, int customerID)
        {
            Incident incident1 = new Incident();
            incident1.CustomerID = customerID;
            incident1.Description = description;
            incident1.Title = Title;
            return incident1;

        }


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
