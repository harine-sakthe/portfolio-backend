using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}

		public DbSet<ContactForm> contactForms { get; set; }
		public DbSet<Certifications> certifications { get; set; }
		public DbSet<Education> educations { get; set; }
		public DbSet<Internships> internships { get; set; }
		public DbSet<Languages> languages { get; set; }
		public DbSet<Projects> Projects { get; set; }


	}
}
