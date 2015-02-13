﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Emanager.Core;

namespace Emanager.Web.Infrastructure
{
    public class DepartmentDb:DbContext, IDepartmentDataSource
    {
       
        public DepartmentDb()
            : base("DefaultConnection")
        {

        }
       
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Department> Departments{ get; set; }



        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return Employees;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get
            {
                return Departments;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}