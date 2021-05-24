using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App {
    public class SchoolContext : DbContext
    {
        // public DbSet<Customer> Customers { get; set; }
        // public DbSet<Invoice> Invoices { get; set; }
        // public DbSet<InvoiceItem> InvoiceItems { get; set; }

        public DbSet<Grade> Grades {get; set;}
        public DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SchoolDB.db;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(new Student[] {
            new Student { Id = 1, FirstName = "Pickle", LastName = "Rick" },
            new Student { Id = 2, FirstName = "Rick", LastName = "Sanchez" },
            new Student { Id = 3, FirstName = "Tom", LastName = "Hanks" },
            new Student { Id = 4, FirstName = "Sussy", LastName = "Backa" },
            });

            modelBuilder.Entity<Grade>().HasData(new Grade[] { 
            new Grade { Id = 1, StudentId = 1, CourseName= "Spanish", GradeP = 0.20F },
            new Grade { Id = 2, StudentId = 2, CourseName = "Geometry", GradeP = 0.90F },
            new Grade { Id = 3, StudentId = 3, CourseName= "Mathematics", GradeP = 0.25F },
            new Grade {Id = 4, StudentId = 1, CourseName= "Mathematics", GradeP = 0.75F },
            new Grade {Id = 5, StudentId = 2, CourseName= "Mathematics", GradeP = 0.85F },
            new Grade {Id = 6, StudentId = 3, CourseName= "Geometry", GradeP = 0.75F }
            });

            base.OnModelCreating(modelBuilder);
        

        }
    }
}