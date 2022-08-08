using Course_Registration.Data;
using Course_Registration.Models;
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
				[HttpPost]
				public IActionResult AddStudent(Student student)
						{

						_context.Students.Add(student);
						_context.SaveChanges();
						return RedirectToAction(nameof(Student));


						}

				public IActionResult AddStudent()
						{

						return View(new Student());
						}

				}
		}
