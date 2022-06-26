using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _departmentService.GetAll();
            if (result is not null)
            {
                return View(result);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Display(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var result = _departmentService.GetById(id);
                if (result is not null)
                {
                    return View(result);
                }
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Insert(department);
                return RedirectToAction("index", "department");
            }
            else
            {
                return View(department);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var result = _departmentService.GetById(id);
                if (result is not null)
                {
                    return View(result);
                }
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Update(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Update(department);
                return RedirectToAction("index", "department");
            }
            else
            {
                return View(department);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var result = _departmentService.GetById(id);
                if (result is not null)
                {
                    return View(result);
                }
                return NotFound();
            }
            //return View();
        }
        //[HttpDelete]
        [ActionName("delete")]
        [HttpPost]
        public IActionResult ConfirmDelete(int? id)
        {
            _departmentService.Delete(id.Value);
            return RedirectToAction("index", "department");
        }


    }
}
