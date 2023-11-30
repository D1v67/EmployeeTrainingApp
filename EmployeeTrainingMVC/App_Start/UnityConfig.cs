using EmployeeTraining.DAL;
using EmployeeTraining.DAL.Common;
using EmployeeTraining.Interfaces;
using EmployeeTraining.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EmployeeTrainingMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<Test_IDataAccessLayer, Test_DataAccessLayer>();
            //container.RegisterType<Test_IDataAccessLayer, Test_DataAccessLayer>();

            //container.RegisterType<IDataAccessLayer, DataAccessLayer>();
            container.RegisterType<IDBCommand, DBCommand>();

            container.RegisterType<ITrainingDAL, TrainingDAL>();
            container.RegisterType<ITrainingService, TrainingService>();
            //container.RegisterType<IDataAccessLayer, DataAccessLayer>();
            container.RegisterType<IUserDAL, UserDAL>();
            container.RegisterType<IUserService, UserService>();

            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IAccountDAL, AccountDAL>();

            container.RegisterType<IEnrollmentService, EnrollmentService>();
            container.RegisterType<IEnrollmentDAL, EnrollmentDAL>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}