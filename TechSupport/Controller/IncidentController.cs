using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL incidentSource;

        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> GetCustomerIncidents()
        {
            return this.incidentSource.GETCustomerIncidents();
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident can not be null");
            }
            this.incidentSource.Add(incident);
        }

    }
}
