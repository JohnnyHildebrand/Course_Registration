using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course_Registration.Controllers
		{
		public class InstructorController : Controller
				{
				private readonly InstructorContext _context;

				public InstructorController()
						{
						_context = new InstructorContext();
						}

				public IActionResult Instructor()
						{
						var instructors = _context.Instructors.ToList();
						return View(instructors);
						}

				[HttpPost]/*Post to sql Database*/
				public IActionResult AddInstructor(Instructor instructor)
						{
						//Validation check fro required fields
						if (ModelState.IsValid)
								{
								_context.Instructors.Add(instructor);
								_context.SaveChanges();
								}
						else
								{
								return BadRequest(ModelState);

								}
						return RedirectToAction(nameof(Instructor));
						}

				public IActionResult AddInstructor()
						{
						return View(new Instructor());
						}


				}
		}

