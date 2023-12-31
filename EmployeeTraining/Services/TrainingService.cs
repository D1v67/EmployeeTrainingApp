﻿using EmployeeTraining.DAL;
using EmployeeTraining.Entities;
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

        public void Add(TrainingModel training)
        {
            _trainingDAL.Add(training);
        }

        public void Delete(int id)
        {
            _trainingDAL.Delete(id);
        }

        public IEnumerable<TrainingModel> GetAll()
        {
            return _trainingDAL.GetAll();
        }

        public TrainingModel GetByID(int id)
        {
            return _trainingDAL.GetByID(id);
        }

        public void Update(TrainingModel training)
        {
             _trainingDAL.Update(training);
        }
    }
}
