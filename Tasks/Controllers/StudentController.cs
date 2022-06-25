using Microsoft.AspNetCore.Mvc;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IStudentService _customerService;

        public StudentController(IStudentService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No Records Found");
        }
    }
}
