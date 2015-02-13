namespace Emanager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Emanager.Core;

    internal sealed class Configuration : DbMigrationsConfiguration<Emanager.Web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Emanager.Web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department() { Name = "Engineering" },
                new Department() { Name = "Sales" },
                new Department() { Name = "Shipping" },
                new Department() { Name = "Human Resources" },
                new Department() { Name = "Support" },
                new Department() { Name = "Services" },
                new Department() { Name = "Product Management" },
                new Department() { Name = "IT" }
                
                );
        }
    }
}
