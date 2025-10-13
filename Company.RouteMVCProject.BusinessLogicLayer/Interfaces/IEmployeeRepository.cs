using Company.RouteMVCProject.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.RouteMVCProject.BusinessLogicLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();
        public Employee? Get(int id);
        public int Add(Employee model);
        public int Update(Employee model);
        public int Delete(Employee model);

    }
}
