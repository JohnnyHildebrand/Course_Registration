using System.ComponentModel.DataAnnotations;

namespace Course_Registration.Models
		{
		public class Course
				{

				public int Id { get; set; }
				public int CourseNumber { get; set; }

				[Required(ErrorMessage = "Course Name Mandatory")]
				public string? CourseName { get; set; }

				public string? Description { get; set; }

				public List<Course>? Courses { get; set; }
				public List<Student>? Students { get; set; }
				}
		}
