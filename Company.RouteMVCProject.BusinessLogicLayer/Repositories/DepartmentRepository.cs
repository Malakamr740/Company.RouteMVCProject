

using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
using Company.RouteMVCProject.DataAccessLayer.Data.Contexts;
using Company.RouteMVCProject.DataAccessLayer.Models;

namespace Company.RouteMVCProject.BusinessLogicLayer.Repositories
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly CompanyDBContext context;
        public IEnumerable<Department> GetAll()
        {
           return context.departments.ToList();
        }
        public Department? Get(int id)
        {
            return context.departments.Find(id);
        }

        public int Add(Department model)
        {
            context.departments.Add(model);
            return context.SaveChanges();
        }
        public int update(Department model)
        {
            context.departments.Update(model);
            return context.SaveChanges();
        }

        public int Delete(Department model)
        {
            context.departments.Remove(model);
            return context.SaveChanges();
        }


    }
}
