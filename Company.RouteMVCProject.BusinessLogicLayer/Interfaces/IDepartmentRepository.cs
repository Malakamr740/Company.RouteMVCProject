using Company.RouteMVCProject.DataAccessLayer.Models;

namespace Company.RouteMVCProject.BusinessLogicLayer.Interfaces
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAll();
        public Department? Get(int id);
        public int Add(Department model);
        public int update(Department model);
        public int Delete(Department model);
        
    }
}
