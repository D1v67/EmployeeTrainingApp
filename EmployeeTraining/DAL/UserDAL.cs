﻿using EmployeeTraining.DAL.Common;
using EmployeeTraining.Entities;
using EmployeeTraining.Enums;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class UserDAL : IUserDAL
    {
        public const string GET_ALL_USER_QUERY = @"SELECT  * FROM [dbo].[User]";

        public const string GET_USER_BY_ID_QUERY = @"SELECT u.*
                                                        FROM [User] u 
                                                        WHERE u.UserID = @UserID";

        public const string INSERT_USER_QUERY = @"INSERT INTO [dbo].[User]
                                                       ([FirstName]
                                                       ,[LastName]
                                                       ,[Email]
                                                       ,[NIC]
                                                       ,[MobileNumber]
                                                       ,[RoleID]
                                                       ,[DepartmentID]
                                                       ,[ManagerID]) 
                                                 VALUES
                                                       (@FirstName
                                                       ,@LastName
                                                       ,@Email
                                                       ,@NIC
                                                       ,@MobileNumber
                                                       ,@RoleID
                                                       ,@DepartmentID
                                                       ,@ManagerID)";

        public const string UPDATE_USER_QUERY = @"UPDATE [dbo].[User]
                                                   SET [FirstName] = @FirstName
                                                      ,[LastName] = @LastName
                                                      ,[Email] = @Email
                                                      ,[NIC] = @NIC
                                                      ,[MobileNumber] = @MobileNumber
                                                      ,[RoleID] = @RoleID
                                                      ,[DepartmentID] = @DepartmentID
                                                      ,[ManagerID] = @ManagerID
                                                 WHERE [UserID] = @UserID";

        public const string DELETE_USER_QUERY = @"DELETE FROM [dbo].[User] WHERE [UserID] = @UserID";

        public const string GET_USER_BY_NIC = "";
        public const string GET_USER_BY_EMAIL = "";
        public const string GET_USER_BY_MOBILE_NUMBER = "";

        public const string SET_USER_PASSWORD = "";

        public IEnumerable<UserModel> GetAll()
        {
            List<UserModel> users = new List<UserModel>();

            UserModel user;
            var dt = DBCommand.GetData(GET_ALL_USER_QUERY);
            foreach (DataRow row in dt.Rows)
            {
                user = new UserModel();
                user.UserID = int.Parse(row["UserID"].ToString());
                user.FirstName = row["FirstName"].ToString();
                user.LastName = row["LastName"].ToString() ;
                user.Email = row["Email"].ToString();
                user.NIC = row["NIC"].ToString();
                user.MobileNumber = row["MobileNumber"].ToString();
                user.RoleID = int.Parse(row["RoleID"].ToString());
                user.DepartmentID = int.Parse(row["DepartmentID"].ToString());
                user.ManagerID = int.Parse(row["ManagerID"].ToString());

                users.Add(user);
            }

            return users;
        }

        public UserModel GetByID(int id)
        {
            var parameters = new List<SqlParameter> { new SqlParameter("@UserID", id) };
            var dt = DBCommand.GetDataWithConditions(GET_USER_BY_ID_QUERY, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                UserModel user = new UserModel
                {
                    UserID = int.Parse(row["UserID"].ToString()),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Email = row["Email"].ToString(),
                    NIC = row["NIC"].ToString(),
                    MobileNumber = row["MobileNumber"].ToString(),
                    RoleID = int.Parse(row["RoleID"].ToString()),
                    DepartmentID = int.Parse(row["DepartmentID"].ToString()),
                    ManagerID = int.Parse(row["ManagerID"].ToString())
                };
                    return user;
                
            }

            return null;
        }


        public void Add(UserModel user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@FirstName", user.FirstName));
            parameters.Add(new SqlParameter("@LastName", user.LastName));
            parameters.Add(new SqlParameter("@Email", user.Email));
            parameters.Add(new SqlParameter("@NIC", user.NIC));
            parameters.Add(new SqlParameter("@MobileNumber", user.MobileNumber));
            parameters.Add(new SqlParameter("@RoleID", user.RoleID));
            parameters.Add(new SqlParameter("@DepartmentID", user.DepartmentID));
            parameters.Add(new SqlParameter("@ManagerID", user.ManagerID));

            DBCommand.InsertUpdateData(INSERT_USER_QUERY, parameters);
        }

        public void Delete(int id)
        {
            var parameters = new List<SqlParameter> { new SqlParameter("@UserID", id) };
            DBCommand.InsertUpdateData(DELETE_USER_QUERY, parameters);
        }

        public void Update(UserModel user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@FirstName", user.MobileNumber));
            parameters.Add(new SqlParameter("@LastName", user.LastName));
            parameters.Add(new SqlParameter("@Email", user.Email));
            parameters.Add(new SqlParameter("@NIC", user.NIC));
            parameters.Add(new SqlParameter("@MobileNumber", user.MobileNumber));
            parameters.Add(new SqlParameter("@RoleID", user.RoleID));
            parameters.Add(new SqlParameter("@DepartmentID", user.DepartmentID));
            parameters.Add(new SqlParameter("@ManagerID", user.ManagerID));

            DBCommand.InsertUpdateData(UPDATE_USER_QUERY, parameters);
        }

        public bool ApproveRequest(UserModel user, TrainingModel traning)
        {
            throw new NotImplementedException();
        }

        public bool DeclineRequest(UserModel user, TrainingModel traning)
        {
            throw new NotImplementedException();
        }


        public bool Login(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool Logout(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool Register(UserModel user)
        {
            throw new NotImplementedException();
        }


    }
}
