﻿using System.ComponentModel.DataAnnotations;

namespace Course_Registration.Models
		{
		public class Instructor
				{
				public int Id { get; set; }
				
				public string FirstName { get; set; }

			
				public string LastName { get; set; }
				public string EmailAddress { get; set; }

			
				public string Course { get; set; }

				public List<Instructor> Instructors { get; set; }
			
				}
		}
