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
                            Incident.TechnicianName = reader["Technician"].ToString();
                            Incident.CustomerName = reader["Customer"].ToString();
                            Incident.DateOpened = reader["DateOpened"].ToString();
                            Incident.ProductCode = reader["ProductCode"].ToString();
                            IncidentList.Add(Incident);
                        }
                    }
                }  
            }
            return IncidentList;
        }


        /// <summary>
        /// This method fethces the customer name and the product names
        /// of those customers who have registered their products
        /// </summary>
        /// <returns>a dictionary of Incidents</returns>
        public Dictionary<string, List<string>> GETRegisteredDBCustomersWithProducts()
        {
            Dictionary<string, List<string>> RegisteredCustomerAndProductsList = new Dictionary<string, List<string>>();

            string selectStatement = "SELECT " +
                "DISTINCT t2.Name AS customerName," +
                " t3.[Name] AS productName " +
                "FROM[TechSupport].[dbo].[Registrations] t1 " +
                "LEFT JOIN[TechSupport].[dbo].[Customers] t2 " +
                " ON t1.CustomerID = t2.CustomerID" +
                " LEFT JOIN[TechSupport].[dbo].[Products] t3" +
                " ON t1.ProductCode = t3.ProductCode" +
                " ORDER BY t2.Name;";

            string CurrentName = null;
            List<string> productList = new List<string>();

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string NewName = reader["customerName"].ToString();

                            if (NewName != CurrentName)
                            {
                                if (!String.IsNullOrEmpty(CurrentName))
                                {
                                    RegisteredCustomerAndProductsList.Add(CurrentName, new List<string>(productList));
                                }
                                CurrentName = NewName;
                                productList.Clear();
                            }
                            productList.Add(reader["productName"].ToString());
                        }
                    }
                }
            }
            return RegisteredCustomerAndProductsList;
        }

        /// <summary>
        /// method to add an incident to database using parameterized queries
        /// </summary>
        /// <param name="incident">is the incident to be added</param>
        internal void AddIncidentToDB(Incident incident)
        {
            string insertStatement =
                "INSERT INTO Incidents(Title,DateOpened,Description,CustomerID,ProductCode) " +
                "VALUES(@IncidentTitle, @IncidentDate, @Description, (SELECT DISTINCT[CustomerID] " +
                "FROM[TechSupport].[dbo].[Customers] " +
                "WHERE Name = @CustomerName),(SELECT DISTINCT[ProductCode] " +
                "FROM[TechSupport].[dbo].[Products] " +
                "WHERE Name = @ProductName)); ";


            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerName",incident.CustomerName);
                    insertCommand.Parameters.AddWithValue("@ProductName", incident.ProductName);
                    insertCommand.Parameters.AddWithValue("@IncidentDate", incident.DateOpened);
                    if(incident.Title == "") {
                        insertCommand.Parameters.AddWithValue("@IncidentTitle", DBNull.Value); 
                            }
                    else {
                        insertCommand.Parameters.AddWithValue("@IncidentTitle", incident.Title);
                            }
                    if (incident.Description == "")
                    {
                        insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("@Description", incident.Description);
                    }

                    insertCommand.ExecuteNonQuery();
                    
                }

                connection.Close();
            }

         
        }
    }
}
