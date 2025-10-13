using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
using Company.RouteMVCProject.DataAccessLayer.Data.Contexts;
using Company.RouteMVCProject.DataAccessLayer.Models;


namespace Company.RouteMVCProject.BusinessLogicLayer.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly CompanyDBContext _context;
        public EmployeeRepository(CompanyDBContext context) : base(context) //Ask CLR to create an object of CompanyDBContext
        {
            
        }
        //public IEnumerable<Employee> GetAll()
        //{
        //   return _context.employees.ToList();
        //}

        //public Employee? Get(int id)
        //{
        //    return _context.employees.Find(id);
        //}

        //public int Add(Employee model)
        //{
        //   _context.employees.Add(model);
        //    return _context.SaveChanges();
        //}
        //public int Update(Employee model)
        //{
        //    _context.employees.Update(model);
        //    return _context.SaveChanges();
        //}

        //public int Delete(Employee model)
        //{
        //    _context.employees.Remove(model);
        //    return _context.SaveChanges();
        //}

    }
}
