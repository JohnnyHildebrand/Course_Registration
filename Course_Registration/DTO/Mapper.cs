using Course_Registration.Models;

namespace Course_Registration.DTO
		{
		public class Mapper
				{
				public StudentDTO Map(Student student)
						{
						return new StudentDTO
								{
								Id = student.Id,
								FirstName = student.FirstName,
								LastName = student.LastName,
								EmailAddress = student.EmailAddress,
								PhoneNumber = student.PhoneNumber,
								};
						}
				public Student Map(StudentDTO studentDTO)
						{
						return new Student
								{
								Id = studentDTO.Id,
								FirstName = studentDTO.FirstName,
								LastName = studentDTO.LastName,
								EmailAddress = studentDTO.EmailAddress,
								PhoneNumber = studentDTO.PhoneNumber,
								};
						}
				public CourseDTO Map(Course course)
						{
						return new CourseDTO
								{
								Id = course.Id,
								CourseNumber = course.CourseNumber,
								CourseName = course.CourseName,
								Description = course.Description,
								};
						}
				public Course Map(CourseDTO courseDTO)
						{
						return new Course
								{
								Id=courseDTO.Id,
								CourseNumber=courseDTO.CourseNumber,
								CourseName=courseDTO.CourseName,
								Description=courseDTO.Description,
								};
						}
				public InstructorDTO Map(Instructor instructor)
						{
						return new InstructorDTO
								{
								Id = instructor.Id,
								FirstName = instructor.FirstName,
								LastName = instructor.LastName,
								EmailAddress = instructor.EmailAddress,
								Course = instructor.Course,
								};
						}
				public Instructor Map(InstructorDTO instructorDTO)
						{
						return new Instructor
								{
								Id = instructorDTO.Id,
								FirstName = instructorDTO.FirstName,
								LastName = instructorDTO.LastName,
								EmailAddress = instructorDTO.EmailAddress,
								Course=instructorDTO.Course,
								};
						}
				}
		}



