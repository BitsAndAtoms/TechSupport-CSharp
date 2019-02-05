using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// This class creates an incident object with
    /// title, description and customerID as properties
    /// </summary>
    public class Incident
    {
        internal string customerName;
        internal DateTime dateOpened;
        internal string productCode;

        public string Title { get; set;}
        public string Description { get; set; }
        public int CustomerID { get; set; }
        public string technicianName { get; set; }

        /// <summary>
        /// This method creates an incident 
        /// </summary>
        /// <param name="title">Title of the incident is non-empty string</param>
        /// <param name="description">Description of the incident is non-empty string</param>
        /// <param name="customerID">customerID is integer > 0</param>
        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title can not be null or empty", "title");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description can not be null or empty", "description");
            }

            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID needs to be an integer greater than 0", "customerID");
            }

            this.CustomerID = customerID;
            this.Description = description;
            this.Title = title;
        }

        public Incident() { }

    }
}
