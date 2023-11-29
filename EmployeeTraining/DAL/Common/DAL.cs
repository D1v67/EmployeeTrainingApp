using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL.Common
{
    public class DAL
    {
        //public const string connectionstring = @"server=localhost;database=EmployeeTrainingDB;uid=wbpoc;pwd=sql@tfs2008";

        public string connectionstring = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public SqlConnection connection;
        public DAL()
        {
            connection = new SqlConnection(connectionstring);
            OpenConnection();
        }
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

    }
}
