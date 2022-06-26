using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;

        public StudentController(IStudentService studentService, IDepartmentService departmentService)
        {
            _studentService = studentService;
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _studentService.GetAll();
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
                var result = _studentService.GetById(id);
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
            SelectList depts = new SelectList(_departmentService.GetAll().ToList(), "Id", "Name");
            ViewBag.Depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Insert(student);
                return RedirectToAction("index", "student");
            }
            else
            {
                SelectList depts = new SelectList(_departmentService.GetAll().ToList(), "Id", "Name");
                ViewBag.Depts = depts;
                return View(student);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            SelectList depts = new SelectList(_departmentService.GetAll().ToList(), "Id", "Name");
            ViewBag.Depts = depts;

            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var result = _studentService.GetById(id);
                if (result is not null)
                {
                    return View(result);
                }
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Update(student);
                return RedirectToAction("index", "student");
            }
            else
            {
                SelectList depts = new SelectList(_departmentService.GetAll().ToList(), "Id", "Name");
                ViewBag.Depts = depts;
                return View(student);
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
                var result = _studentService.GetById(id);
                if (result is not null)
                {
                    return View(result);
                }
                return NotFound();
            }
        }

        [ActionName("delete")]
        [HttpPost]
        public IActionResult ConfirmDelete(int? id)
        {
            _studentService.Delete(id.Value);
            return RedirectToAction("index", "student");
        }

        public IActionResult CheckEmail(string Email, int Id = 0, int Age = 0, string Name = "")
        {
            //if(Id == 0) { 

            Student? student = _studentService.GetAll()
            .Where(s => s.Id != Id)
            .SingleOrDefault(s => s.Email == Email);

            if (student == null)
            {
                return Json(true);
            }
            return Json(false);
            //}
        }

        public IActionResult Check(string Email)
        {
            Student? student = _studentService.GetAll()
            .SingleOrDefault(d => d.Email == Email);
            if (student == null)
            {
                return Json(true);
            }
            return Json(false);
        }


    }
}



