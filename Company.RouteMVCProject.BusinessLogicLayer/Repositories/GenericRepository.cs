

using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
using Company.RouteMVCProject.DataAccessLayer.Data.Contexts;
using Company.RouteMVCProject.DataAccessLayer.Models;

namespace Company.RouteMVCProject.BusinessLogicLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyDBContext _context;
        public GenericRepository(CompanyDBContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T? Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Add(T model)
        {
            _context.Set<T>().Add(model);
            return _context.SaveChanges();
        }

        public int Update(T model)
        {

            _context.Set<T>().Update(model);
            return _context.SaveChanges();
        }

        public int Delete(T model)
        {

            _context.Set<T>().Remove(model);
            return _context.SaveChanges();
        }


    
    }
}
