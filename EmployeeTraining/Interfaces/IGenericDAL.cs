using System.Collections.Generic;

namespace EmployeeTraining.DAL
{
    public interface IGenericDAL<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}