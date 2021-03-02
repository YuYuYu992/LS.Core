using LS.Core.Data.Entity;
using LS.Core.Data.ModelConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.SQLDataConnect
{
    public class StudentDataBase : DbContext
    {
        public StudentDataBase(DbContextOptions<StudentDataBase> options) : base(options)
        {

        }

       // public DbSet<Student> STUDENT { get; set; }

      //  public DbSet<Teacher> TEACHER { get; set; }

        //public DbSet<Class> CLASS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.Entity(typeof(Student));
            modelBuilder.Entity(typeof(Teacher));
            //modelBuilder.Entity(typeof(Class));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.en
        }

    }
}