using Course_Registration.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Course_Registration.Controllers
		{
		public class StudentController : Controller
				{
				private readonly StudentContext _context;

				public StudentController()
						{
						_context = new StudentContext();
						}

				public IActionResult Student()
						{
						var students = _context.Students.Include(c => c.Students).ToList();
						return View(students);
						}

				}
		}
