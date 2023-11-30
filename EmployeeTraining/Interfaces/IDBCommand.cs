using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeTraining.DAL.Common
{
    public interface IDBCommand
    {
        DataTable GetData(string query);
        DataTable GetDataWithConditions(string query, List<SqlParameter> parameters);
        int InsertUpdateData(string query, List<SqlParameter> parameters);
    }
}