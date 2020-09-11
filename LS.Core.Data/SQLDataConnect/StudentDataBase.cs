using LS.Core.Data.Entity;
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

        public DbSet<Student> STUDENT { get; set; }

        public DbSet<Teacher> TEACHER { get; set; }

        public DbSet<Class> CLASS { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasKey(c => c.Id);
        //    modelBuilder.Entity<Teacher>().HasKey(c => c.Id);
        //    modelBuilder.Entity<Class>().HasKey(c => c.Id);
        //}

    }
}