using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Authentication_MVC.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()  : base("name = EmployeeContext")
        {




        }

        public DbSet<Employee> Employees { get; set;}
        public DbSet<Student> Students { get; set;}
    }
}