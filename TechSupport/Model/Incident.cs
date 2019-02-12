using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class creates an incident object with
    /// title, description and customerID as properties
    /// </summary>
    public class Incident
    {
       public string customerName { get; set; }
       public string dateOpened { get; set; }
       public string productCode { get; set; }
        public string productName { get; set; }
        public string Title { get; set;}
        public string Description { get; set; }
        public int CustomerID { get; set; }
        public string technicianName { get; set; }

        /// <summary>
        /// This method creates an incident  if the three parameter constructor is called
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

        /// <summary>
        /// this constructor is created to instantiate and emtpy incident object for
        /// use with DB
        /// </summary>
        public Incident() { }

    }
}
