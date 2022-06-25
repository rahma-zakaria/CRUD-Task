using Microsoft.AspNetCore.Mvc;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IDepartmentService _customerService;

        public DepartmentController(IDepartmentService customerService)
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
