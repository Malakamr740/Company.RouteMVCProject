using Company.RouteMVCProject.BusinessLogicLayer.Interfaces;
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

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id is null)
            {
                return BadRequest("Invalid Id");
            }

            var department = _departmentRepository.Get(id.Value);
            
            if (department is null) return NotFound(new { statusCode = 404, message = $"Department with Id {id} is Null" });


            return View(department);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null)
            {
                return BadRequest("Invalid Id");
            }

            var department = _departmentRepository.Get(id.Value);
            if (department is null) return NotFound(new { statusCode = 404, message = $"Department with Id {id} is Null" });

            var updateDepartmentDTO = new UpdateDepartmentDTO()
            {
                Code = department.Code,
                Name = department.Name,
                CreateAt = department.CreateAt
            };

            return View(updateDepartmentDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id , UpdateDepartmentDTO  model)
        {
            if (ModelState.IsValid)
            {
                var department = new Department()
                {
                    Id = id,
                    Code = model.Code,
                    Name = model.Name,
                    CreateAt = model.CreateAt
                };
                if (id == department.Id)
                {
                    var count = _departmentRepository.update(department);
                    if (count > 0) return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null) return BadRequest("Invalid Id");
            

            var department = _departmentRepository.Get(id.Value);
            if (department is null) return NotFound(new { statusCode = 404, message = $"Department with Id {id} is Null" });

            return View(department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Department model)
        {
            if (ModelState.IsValid)
            {
              
                if (id == model.Id)
                {
                    var count = _departmentRepository.Delete(model);
                    if (count > 0) return RedirectToAction("Index");
                }
                else { 
                return BadRequest("Id Mismatched");
                }
            }
            return View(model);
        }
    }
}
