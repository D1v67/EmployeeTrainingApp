﻿using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class GenericDAL<T> : IGenericDAL<T> where T : class
    {
        public void Add(T entity)
        {
            //foreach(var property in entity.GetType().GetProperties())
            //{

            //}
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
