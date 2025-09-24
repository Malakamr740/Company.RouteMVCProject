using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
using Company.RouteMVCProject.BusinessLogicLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company.RouteMVCProject.PresentationLayer.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

     
        
        
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();

            return View(departments);
        }
    }
}
