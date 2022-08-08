using System.ComponentModel.DataAnnotations;

namespace Course_Registration.Models
		{
		public class Student
				{
				public int Id { get; set; }

				[Required(ErrorMessage = "First Name Mandatory")]
				public string? FirstName { get; set; }

				[Required(ErrorMessage = "Last Name Mandatory")]

				public string? LastName { get; set; }

				public string? EmailAddress { get; set; }

				[Required(ErrorMessage = "Phone Number Mandatory")]

				public string? PhoneNumber { get; set; }

				public List<Student>? Students { get; set; }


				public List<Course>? Courses { get; set; }


				}
		}
