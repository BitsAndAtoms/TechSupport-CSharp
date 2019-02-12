using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class creates an incident object with
    /// title, description and customerID as properties
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Default 0 parameter constructor
        /// </summary>
        public Incident() { }

        /// <summary>
        /// name of the customer get set
        /// </summary>
       public string customerName { get; set; }

        /// <summary>
        /// incident filed date get set
        /// </summary>
        public string dateOpened { get; set; }

        /// <summary>
        /// product code get set
        /// </summary>
        public string productCode { get; set; }

        /// <summary>
        /// product name get set
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// title of the incident get set
        /// </summary>
        public string Title { get; set;}

        /// <summary>
        /// description of the incident get set
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// customerID of the incident get set
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// technician of the incident get set
        /// </summary>
        public string technicianName { get; set; }
    
    }
}
