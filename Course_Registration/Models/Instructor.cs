using System.ComponentModel.DataAnnotations;

namespace Course_Registration.Models
		{
		public class Instructor
				{
				public int Id { get; set; }

				[Required(ErrorMessage = "First Name Mandatory")]

				public string? FirstName { get; set; }

				[Required(ErrorMessage = "Last Name Mandatory")]

				public string? LastName { get; set; }
				public string? EmailAddress { get; set; }

				[Required(ErrorMessage = "Course Name Mandatory")]

				public string? Course { get; set; }

				public List<Instructor>? Instructors { get; set; }

				}
		}
