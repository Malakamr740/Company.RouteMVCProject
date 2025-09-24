using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
using Company.RouteMVCProject.BusinessLogicLayer.Repositories;
using Company.RouteMVCProject.DataAccessLayer.Models;
using Company.RouteMVCProject.PresentationLayer.DTOs;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDTO model) 
        { 
            if (ModelState.IsValid) //Server Side Validation 
            {
                var department = new Department()
                {
                    Code = model.Code,
                    Name = model.Name,
                    CreateAt = model.CreateAt
                };
                var count = _departmentRepository.Add(department);
                if (count > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
