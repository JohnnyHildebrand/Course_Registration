using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Course_Registration.Controllers
		{
		public class CourseController : Controller
				{
				private readonly CourseContext _context;

				public CourseController()
						{
						_context = new CourseContext();
						}

				public IActionResult Course()
						{
						var courses = _context.Courses.Include(c => c.Students).ToList();
						return View(courses);
						}


				[HttpPost] /*Post to sql Database*/
 				public IActionResult AddCourse(Course course)
						{
						//Validation check fro required fields
						if (ModelState.IsValid)
								{
								_context.Courses.Add(course);
								_context.SaveChanges();


								}
						else
								{
								return BadRequest(ModelState);

								}
						return RedirectToAction(nameof(Course));
						}


				public IActionResult AddCourse()
						{

						return View(new Course());
						}





				}
		}

