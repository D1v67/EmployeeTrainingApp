using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface Test_IDataAccessLayer
    {
        string Connect();
        void Disconnect();
        string Connect(string connectionString);
        DataTable GetData(string sql,List<SqlParameter> parameters);
    }
}
