namespace Authentication_MVC.Migrations
{
    using Authentication_MVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Authentication_MVC.Models.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Authentication_MVC.Models.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Employees.Add(new Employee { UserName = "Ishan", Password = "Ishan123", Role="Admin" });
            context.Employees.Add(new Employee { UserName="Admin", Password="admin", Role="Admin" });
            context.Employees.Add(new Employee { UserName="Pawan", Password="pawan", Role="Employee" });
            context.Employees.Add(new Employee { UserName="User", Password="user", Role= "Employee" });


            context.SaveChanges();
            base.Seed(context);


        }
    }
}
