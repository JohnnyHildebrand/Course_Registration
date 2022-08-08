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
				
				[HttpPost]/*Post to sql Database*/
				public IActionResult AddStudent(Student student)
						{
						//Validation check fro required fields
						if (ModelState.IsValid)
								{
								_context.Students.Add(student);
								_context.SaveChanges();
								}
						else
								{
								return BadRequest(ModelState);
																}
						return RedirectToAction(nameof(Student));
						}

				public IActionResult AddStudent()
						{
						return View(new Student());
						}

				}
		}
