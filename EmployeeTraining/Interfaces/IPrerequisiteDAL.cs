﻿using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IPrerequisiteDAL
    {
        IEnumerable<PrerequisiteModel> GetPrerequisiteByTrainingID(int TrainingID);
        IEnumerable<PrerequisiteModel> GetAll();
        PrerequisiteModel GetByID(int id);
        void Add(PrerequisiteModel prerequisite);
        void Delete(int id);
        void Update(PrerequisiteModel prerequisite);
    }
}
