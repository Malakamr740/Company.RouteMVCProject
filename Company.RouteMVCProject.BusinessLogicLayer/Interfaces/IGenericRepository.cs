
using Company.RouteMVCProject.DataAccessLayer.Models;

namespace Company.RouteMVCProject.BusinessLogicLayer.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T? Get(int id);
        public int Add(T model);
        public int Update(T model);
        public int Delete(T model);
    }
}
