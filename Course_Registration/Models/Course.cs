namespace Course_Registration.Models
		 {
		 public class Course
					{
					public int CourseId { get; set; }
					public int CourseNumber { get; set; }
					public string CourseName { get; set; }
					public string Description { get; set; }

					public List<Course> Courses { get; set; }
					public List<Student> Students { get; set; }
					}
		 }
