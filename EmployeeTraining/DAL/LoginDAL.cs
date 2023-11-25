using EmployeeTraining.DAL.Common;
using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class LoginDAL
    {
        public const string AuthenticateUserQuery = @"
                                                    SELECT u.* 
                                                    FROM [User] u
                                                    INNER JOIN Account a ON u.UserID = a.UserID
                                                    WHERE u.Email = @Email AND a.Password = @Password";
        public const string GetUserDetailsWithRolesQuery = @"SELECT u.*, r.*
                                                    FROM [User] u WITH(NOLOCK)
                                                    INNER JOIN Role r WITH(NOLOCK) ON u.RoleID = r.RoleID
                                                    WHERE u.Email = @Email";


        //public const string GetUserByEmailAddress = @"select user.*,r.* from User user with(nolock) 
        //inner join Account a with(nolock) on user.UserID = a.UserID
        //inner join Role r with(nolock) on a.RoleId = r.RoleId
        //WHERE user.Email = @Email";

        public static bool AuthenticateUser(LoginModel model)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", model.Email));
            parameters.Add(new SqlParameter("@Password", model.Password));

            var dt = DBCommand.GetDataWithConditions(AuthenticateUserQuery, parameters);

            return dt.Rows.Count > 0;


        }

        public static LoginModel GetUserDetailsWithRoles(LoginModel model)
        {
            LoginModel user = new LoginModel();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", model.Email));

            var dt = DBCommand.GetDataWithConditions(GetUserDetailsWithRolesQuery, parameters);
            foreach (DataRow row in dt.Rows)
            {
                user.RoleName = row["RoleType"].ToString();
                user.Email = row["Email"].ToString().Trim();
                user.RoleId = int.Parse(row["RoleId"].ToString());
            }
            return user;
        }

        //public static UserModel GetEmployeeDetail(LoginModel model)
        //{
        //    var employee = new UserModel();
        //    employee = UserDAL.GetEmployees().FirstOrDefault(emp => emp.EmailAddress == model.EmailAddress);

        //    return employee;
        //}

    }
}
