using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course_Registration.Controllers
		{
		public class CourseController : Controller
				{
				/*private readonly CourseContext _context;

				public CourseController()
						{
						_context = new CourseContext();
						}

				public IActionResult Courses()
						{
						var courses = _context.Courses.Include(c => c.Students).ToList();
						return View(courses);
						}*/

				public IActionResult Course()
						{
						Course courses = new Course();
						List<Course> Cor = new List<Course>()

											{
		new Course{
					Id = 1,
					CourseNumber  = 23,
					CourseName = "C Sharp",
					Description= "This course is an introduction to computer programming for Windows. Emphasis will be on the fundamentals of structured design, development, testing, implementation, and documentation, including language syntax, data and file structures, input/output devices, files, and databases",
					Students = new List<Student>
							{
							new Student
										{
									Id = 123
										},
							new Student
										{
									Id = 221
										},
							new Student
										{
										Id = 334
										}
							}
					},


		};
						courses.Courses = Cor;
						return View(courses);
						}
				}
		}

