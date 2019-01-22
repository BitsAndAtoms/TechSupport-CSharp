using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }



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

            if (customerID < 1 )
            {
                throw new ArgumentException("CustomerID needs to be greater than 0", "customerID");
            }

            this.CustomerID = customerID;
            this.Description = description;
            this.Title = title;
        }

        


    }
}
