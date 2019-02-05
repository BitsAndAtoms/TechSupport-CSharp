using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentDBDAL
    {

        /// <summary>
        /// This method uses try/catch/finally and placed closing of the resources (connection, reader) in the 
        /// finally block.
        /// 
        /// </summary>
        /// <returns>a list of Incidents</returns>
        public List<Incident> GETCustomerDBIncidents()
        {
            List<Incident> IncidentList = new List<Incident>();
            SqlConnection connection = IncidentDBConnection.GetConnection();
            string selectStatement =
                "SELECT [ProductCode]" +
                ", t1.CustomerID" +
                ", FORMAT([DateOpened],'MM/dd/yyyy') as 'DateOpened'" +
                ",t2.Name AS Customer" +
                ",t3.Name AS Technician" +
                ",[Title] FROM[TechSupport].[dbo].[Incidents] " +
                "t1 LEFT JOIN[TechSupport].[dbo].[Customers]" +
                " t2 ON t1.CustomerID = t2.CustomerID" +
                " LEFT JOIN[TechSupport].[dbo].[Technicians]" +
                " t3 ON t1.TechID = t3.TechID " +
                "WHERE [DateClosed] IS NUll";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Incident Incident = new Incident();
                    Incident.CustomerID = (int)reader["CustomerID"];
                    Incident.Description = reader["Title"].ToString();
                    Incident.technicianName = reader["Technician"].ToString();
                    IncidentList.Add(Incident);
                }

            }
            //catch (SqlException ex)
            //{
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return IncidentList;
        }


    }
}
