﻿using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly ITrainingDAL _trainingDAL;

        public TrainingService(ITrainingDAL trainingDAL)
        {
            _trainingDAL = trainingDAL;
        }

        public void Add(Training training)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public Training GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
