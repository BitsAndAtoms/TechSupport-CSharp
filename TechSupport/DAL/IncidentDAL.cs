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
        private static List<Incident> _customerIncident = new List<Incident>
        {
            new Incident("Bathroom maintainence","plumbing is broken",101),
            new Incident("Hallway maintainence","Table is broken",101),
        };

    }
}
