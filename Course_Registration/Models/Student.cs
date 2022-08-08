namespace Course_Registration.Models
		{
		public class Student
				{
				public int Id { get; set; }

				public string FirstName { get; set; }
				public string LastName { get; set; }
				public string EmailAddress { get; set; }
				public string PhoneNumber { get; set; }

				public List<Student> Students { get; set; }


				public List<Course> Courses { get; set; }


				}
		}
