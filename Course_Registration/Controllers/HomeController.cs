using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Course_Registration.Controllers
		 {
		 public class HomeController : Controller
					{
					private readonly ILogger<HomeController> _logger;

					public HomeController(ILogger<HomeController> logger)
							 {
							 _logger = logger;
							 }

					public IActionResult Index()
							 {
							 return View();
							 }

					public IActionResult Instructor()
							 {
							 Instructor instructs = new Instructor();
							 List<Instructor> Inst = new List<Instructor>()
	{
	new Instructor{ InstructorId = 1,
			 FirstName = "Bernard",
			 LastName = "Shins",
			 EmailAddress = "BernardShins@Gmail.com",
			 Course = "Data Entry" },
	new Instructor{ InstructorId = 2,
			 FirstName= "Wilma",
			 LastName = "Gunner",
			 EmailAddress = "WilmaGunner@Gmail.com",
			 Course = "Word Processing" },
	new Instructor{ InstructorId = 3,
			 FirstName= "Monte",
			 LastName= "Luxenburg",
			 EmailAddress ="MonteLuxenberg@Gmail.com",
			 Course = "Typing" }
	};
							 instructs.Instructors = Inst;
							 return View(instructs);
							 }


					public IActionResult Student()
							 {
							 Student students = new Student();
							 List<Student> Stu = new List<Student>()
	{
	new Student{ StudentId = 1,
			 FirstName = "Thomas",
			 LastName = "Train",
			 EmailAddress = "ThomasTrain@Gmail.com",
			 PhoneNumber = "1-204-555-1245" },
	new Student{ StudentId= 2,
			 FirstName= "Julia",
			 LastName = "Hubert",
			 EmailAddress = "JuliaHubert@Hotmail.com",
			 PhoneNumber = "1-555-159-9988" },
	new Student{ StudentId = 3,
			 FirstName= "Mark",
			 LastName= "Walberger",
			 EmailAddress ="MarkWalberger@Gmail.com",
			 PhoneNumber = "1-985-666-8912" }
	};
							 students.Students = Stu;
							 return View(students);
							 }

					public IActionResult Course()
							 {
							 Course courses = new Course();
							 List<Course> Cor = new List<Course>()

										{
	new Course{
			 CourseId = 1,
			 CourseNumber  = 23,
			 CourseName = "C Sharp",
			 Description= "This course is an introduction to computer programming for Windows. Emphasis will be on the fundamentals of structured design, development, testing, implementation, and documentation, including language syntax, data and file structures, input/output devices, files, and databases",
			 Students = new List<Student>
						{
						new Student
								 {
								 StudentId = 123
								 },
						new Student
								 {
								 StudentId = 221
								 },
						new Student
								 {
								 StudentId = 334
								 }
						}
			 },
	new Course{
			 CourseId= 2,
			 CourseNumber = 31,
			 CourseName = "Word Processing",
			 Description = "This training provide an knowledge in use of office automation, internet and internet tools.",

			 Students = new List<Student>
						{
						new Student
								 {
								 StudentId = 12
								 },
						new Student
								 {
								 StudentId = 22
								 },
						new Student
								 {
								 StudentId = 34
								 }
						}

			 },
	new Course{
			 CourseId = 3,
			 CourseNumber = 11,
			 CourseName= "Typing",
			 Description = "Typing is the process of writing or inputting text by pressing keys on a typewriter, computer keyboard, cell phone, or calculator.",
			 Students = new List<Student>
						{
						new Student
								 {
								 StudentId = 23
								 },
						new Student
								 {
								 StudentId = 20
								 },
						new Student
								 {
								 StudentId = 33
								 }
						}
			 },
	};
							 courses.Courses = Cor;
							 return View(courses);
							 }

					[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
					public IActionResult Error()
							 {
							 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
							 }
					}
		 }