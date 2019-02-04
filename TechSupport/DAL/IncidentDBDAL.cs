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
                "SELECT CustomerID, Title, techID FROM Incidents ";
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
                    Incident.technicianName = reader["techID"].ToString();
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
