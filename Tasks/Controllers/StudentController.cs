using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        //private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _studentService.GetAll();
            if (result is not null)
            {
                return View(result);
            }
            return BadRequest("No Records Found");
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
            //ItDbContext iti = new ItDbContext();
            //SelectList depts = new SelectList(iti.Departments.ToList(), "DeptId", "Name");
            //ViewBag.Depts = depts;
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
                //ItDbContext iti = new ItDbContext();
                //SelectList depts = new SelectList(iti.Departments.ToList(), "DeptId", "Name");
                //ViewBag.Depts = depts;
                return View(student);
            }
        }

        [HttpGet]
        public IActionResult Update()
        {
            //ItDbContext iti = new ItDbContext();
            //SelectList depts = new SelectList(iti.Departments.ToList(), "DeptId", "Name");
            //ViewBag.Depts = depts;
            return View();
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Update(student);
                return RedirectToAction("index", "student");
            }
            else
            {
                //ItDbContext iti = new ItDbContext();
                //SelectList depts = new SelectList(iti.Departments.ToList(), "DeptId", "Name");
                //ViewBag.Depts = depts;
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
        //[HttpDelete]
        [ActionName("delete")]
        public IActionResult ConfirmDelete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("index", "student");
        }


    }
}



