using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class UserDAL : IUserDAL
    {
        public void Add(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool ApproveRequest(UserModel user, TrainingModel traning)
        {
            throw new NotImplementedException();
        }

        public bool DeclineRequest(UserModel user, TrainingModel traning)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetByID(int id)
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

        public void Update(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
