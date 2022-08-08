using Course_Registration.Models;
using Microsoft.EntityFrameworkCore;

namespace Course_Registration.Data
		{


		public class CourseContext : DbContext
				{

				public DbSet<Course> Courses { get; set; }
				public DbSet<Student> Students { get; set; }

				protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
						{
						optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Course;Trusted_Connection=True;");
						}

				/*	protected override void OnModelCreating(ModelBuilder modelBuilder)
							{
							modelBuilder.Entity<Student>()
									.HasMany(s => s.Courses)
									.WithMany(c => c.Students);
							}*/




				}
		}
