﻿using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class PrerequisiteService : IPrerequisiteService
    {
        private readonly IPrerequisiteDAL _prerequisiteDAL;
        public PrerequisiteService(IPrerequisiteDAL prerequisiteDAL)
        {
            _prerequisiteDAL = prerequisiteDAL;
        }
        public IEnumerable<PrerequisiteModel> GetPrerequisiteByTrainingID(int TrainingID)
        {
            return _prerequisiteDAL.GetPrerequisiteByTrainingID(TrainingID);
        }

        public void Add(PrerequisiteModel prerequisite)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrerequisiteModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PrerequisiteModel GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PrerequisiteModel prerequisite)
        {
            throw new NotImplementedException();
        }
    }
}
