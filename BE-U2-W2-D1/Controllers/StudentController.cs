using BE_U2_W2_D1.Models.Entities;
using BE_U2_W2_D1.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W2_D1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentServices _studentServices;
        public StudentController(StudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var student = await _studentServices.GetAllStudents();

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(await _studentServices.GetAllStudents());

            }
            await _studentServices.CreateAsync(student);
            return RedirectToAction("Index");

        }
    }
}
