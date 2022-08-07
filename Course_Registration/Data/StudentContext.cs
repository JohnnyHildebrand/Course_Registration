using Course_Registration.Models;
using Microsoft.EntityFrameworkCore;

namespace Course_Registration.Data
		{
		public class StudentContext: DbContext
				{
			
					public DbSet<Student> Students { get; set; }
			 	public DbSet<Course> Courses { get; set; }

				protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
								{
								optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Student;Trusted_Connection=True;");
								}

				protected override void OnModelCreating(ModelBuilder modelBuilder)
						{
						modelBuilder.Entity<Student>()
								.HasMany(s => s.Courses)
								.WithMany(c => c.Students);
						}

						
				}
		}
