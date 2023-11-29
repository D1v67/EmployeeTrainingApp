﻿using EmployeeTraining.DAL.Common;
using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using EmployeeTraining.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class AccountDAL : IAccountDAL
    {
        public const string AUTHENTICATE_USER_QUERY = @"
                                                    SELECT u.* 
                                                    FROM [User] u
                                                    INNER JOIN Account a ON u.UserID = a.UserID
                                                    WHERE u.Email = @Email AND a.Password = @Password";
        public const string GET_USER_DETAILS_WITH_ROLE_QUERY = @"SELECT u.*, r.*
                                                    FROM [User] u WITH(NOLOCK)
                                                    INNER JOIN Role r WITH(NOLOCK) ON u.RoleID = r.RoleID
                                                    WHERE u.Email = @Email";

        public const string INSERT_ACCOUNT_QUERY = @"INSERT INTO [dbo].[Account]
                                                           (
                                                           ,[UserID]
                                                           ,[Password]) 
                                                     VALUES
                                                           (
                                                           ,@UserID
                                                           ,@Password)";

        public string INSERT_USER_AND_ACCOUNT_REGISTER_QUERY = @"
            BEGIN TRANSACTION;

            DECLARE @key int

            INSERT INTO [dbo].[User]  ([FirstName] ,[LastName],[Email],[NIC],[MobileNumber]) 
            VALUES (@FirstName, @LastName, @Email, @NIC, @MobileNumber)
 
            SELECT @key = @@IDENTITY
 
            INSERT INTO [dbo].[Account]([UserID],[Password]) 
            VALUES(@key, @Password)

            COMMIT;
         ";

        //public const string GetUserByEmailAddress = @"select user.*,r.* from User user with(nolock) 
        //inner join Account a with(nolock) on user.UserID = a.UserID
        //inner join Role r with(nolock) on a.RoleId = r.RoleId
        //WHERE user.Email = @Email";

        public  bool AuthenticateUser(AccountModel model)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", model.Email));
            parameters.Add(new SqlParameter("@Password", model.Password));

            var dt = DBCommand.GetDataWithConditions(AUTHENTICATE_USER_QUERY, parameters);

            return dt.Rows.Count > 0;


        }

        public  AccountModel GetUserDetailsWithRoles(AccountModel model)
        {
            AccountModel user = new AccountModel();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", model.Email));

            var dt = DBCommand.GetDataWithConditions(GET_USER_DETAILS_WITH_ROLE_QUERY, parameters);
            foreach (DataRow row in dt.Rows)
            {
                user.RoleName = row["RoleType"].ToString();
                user.Email = row["Email"].ToString().Trim();
                user.RoleId = int.Parse(row["RoleId"].ToString());
            }
            return user;
        }

        public void Register(RegisterViewModel model)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@FirstName", model.FirstName));
            parameters.Add(new SqlParameter("@LastName", model.LastName));
            parameters.Add(new SqlParameter("@NIC", model.NIC));
            parameters.Add(new SqlParameter("@Email", model.Email));
            parameters.Add(new SqlParameter("@MobileNumber", model.MobileNumber));
            parameters.Add(new SqlParameter("@Password", model.Password));

            DBCommand.InsertUpdateData(INSERT_USER_AND_ACCOUNT_REGISTER_QUERY, parameters);
        }


        public  void AddAccount(AccountModel model)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@UserID", model.UserID));
            parameters.Add(new SqlParameter("@Password", model.Password));

            DBCommand.InsertUpdateData(INSERT_ACCOUNT_QUERY, parameters);
        }


        //public static UserModel GetEmployeeDetail(LoginModel model)
        //{
        //    var employee = new UserModel();
        //    employee = UserDAL.GetEmployees().FirstOrDefault(emp => emp.EmailAddress == model.EmailAddress);

        //    return employee;
        //}

    }
}