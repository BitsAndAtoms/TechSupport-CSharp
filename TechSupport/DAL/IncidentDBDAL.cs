using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentDBDAL
    {
        /// <summary>
        /// This method fethces the incident data
        /// </summary>
        /// <returns>a list of Incidents</returns>
        public List<Incident> GETCustomerDBIncidents()
        {
            List<Incident> IncidentList = new List<Incident>();
            string selectStatement =
                "SELECT [ProductCode]" +
                ", t1.CustomerID, t1.Description" +
                ", FORMAT([DateOpened],'MM/dd/yyyy') as 'DateOpened'" +
                ",t2.Name AS Customer" +
                ",t3.Name AS Technician" +
                ",[Title] FROM[TechSupport].[dbo].[Incidents] " +
                "t1 LEFT JOIN[TechSupport].[dbo].[Customers]" +
                " t2 ON t1.CustomerID = t2.CustomerID" +
                " LEFT JOIN[TechSupport].[dbo].[Technicians]" +
                " t3 ON t1.TechID = t3.TechID " +
                "WHERE [DateClosed] IS NUll";


            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident Incident = new Incident();
                            Incident.CustomerID = (int)reader["CustomerID"];
                            Incident.Title = reader["Title"].ToString();
                            Incident.Description = reader["Description"].ToString();
                            Incident.technicianName = reader["Technician"].ToString();
                            Incident.customerName = reader["Customer"].ToString();
                            Incident.dateOpened = reader["DateOpened"].ToString();
                            Incident.productCode = reader["ProductCode"].ToString();
                            IncidentList.Add(Incident);
                        }
                    }
                }

                return IncidentList;
            }


        }
    }
}
