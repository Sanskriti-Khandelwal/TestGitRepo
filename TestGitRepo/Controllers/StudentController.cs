using Microsoft.AspNetCore.Mvc;
using TestGitRepo.Models;

namespace TestGitRepo.Controllers
{
    public class StudentController : Controller
    {
       
        private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, FirstName = "John", LastName = "Doe" },
        new Student { Id = 2, FirstName = "Jane", LastName = "Smith" },
        new Student { Id = 3, FirstName = "Mike ", LastName = "John" }
       
    };

     
        public IActionResult Index()
        {
            return View(students);
        }
    }
}
