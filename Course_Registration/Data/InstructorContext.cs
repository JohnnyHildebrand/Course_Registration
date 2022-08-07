using Course_Registration.Models;
using Microsoft.EntityFrameworkCore;

namespace Course_Registration.Data
		{
		public class InstructorContext : DbContext
				{


				public DbSet<Instructor> Instructors { get; set; }

				protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
						{
						optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Instructor;Trusted_Connection=True;");
						}


				}
		}

