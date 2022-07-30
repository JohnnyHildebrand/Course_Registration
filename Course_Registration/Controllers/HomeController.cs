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
							 InstructorViewModel ivm = new InstructorViewModel();
							 List<INST.Instructor> Instruct = new List<INST.Instructor>()
	{
	new INST.Instructor{ InstructorId = 1, FirstName = "Bernard", LastName = "Shins", EmailAddress = "BernardShins@Gmail.com", Course = "Data Entry" },
	new INST.Instructor{ InstructorId = 2, FirstName= "Wilma", LastName = "Gunner", EmailAddress = "WilmaGunner@Gmail.com", Course = "Word Processing" },
	new INST.Instructor{ InstructorId = 3, FirstName= "Monte", LastName= "Luxenburg", EmailAddress ="MonteLuxenberg@Gmail.com", Course = "Typing" }
	};
							 ivm.Instructors = Instruct;
							 return View(ivm);
							 }

					public IActionResult Student()
							 {
							 StudentViewModel svm = new StudentViewModel();
							 List<STUD.Student> Stu = new List<STUD.Student>()
	{
	new STUD.Student{ StudentId = 1, FirstName = "Thomas", LastName = "Train", EmailAddress = "ThomasTrain@Gmail.com", PhoneNumber = "1-204-555-1245" },
	new STUD.Student{ StudentId= 2, FirstName= "Julia", LastName = "Hubert", EmailAddress = "JuliaHubert@Hotmail.com", PhoneNumber = "1-555-159-9988" },
	new STUD.Student{ StudentId = 3, FirstName= "Mark", LastName= "Walberger", EmailAddress ="MarkWalberger@Gmail.com", PhoneNumber = "1-985-666-8912" }
	};
							 svm.Students = Stu;
							 return View(svm);
							 }

					public IActionResult Course()
							 {
							 CourseViewModel cvm = new CourseViewModel();
							 List<CRS.Course> Cor = new List<CRS.Course>()
	{
	new CRS.Course{ CourseId = 1, CourseNumber  = 23, CourseName = "C Sharp", Description= "This course is an introduction to computer programming for Windows. Emphasis will be on the fundamentals of structured design, development, testing, implementation, and documentation, including language syntax, data and file structures, input/output devices, files, and databases" },
	new CRS.Course{ CourseId= 2, CourseNumber = 31, CourseName = "Word Processing", Description = "This training provide an knowledge in use of office automation, internet and internet tools." },
	new CRS.Course{ CourseId = 3, CourseNumber = 11, CourseName= "Typing", Description = "Typing is the process of writing or inputting text by pressing keys on a typewriter, computer keyboard, cell phone, or calculator." }
	};
							 cvm.Courses = Cor;
							 return View(cvm);
							 }

					[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
					public IActionResult Error()
							 {
							 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
							 }
					}
		 }