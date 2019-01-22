using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _customerIncidents = new List<Incident>
        {
            new Incident("Bathroom maintainence","plumbing is broken",101),
            new Incident("Hallway maintainence","Table is broken",101),
        };

        public List<Incident> GETCustomerIncidents()
        {
            return _customerIncidents;
        }


        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident can not be null");
            }
            _customerIncidents.Add(incident);
        }

        public List<Incident> Search(int customerID)
        {
           
            return _customerIncidents.Where(incident => incident.CustomerID == customerID).ToList();
        }
    }
}
