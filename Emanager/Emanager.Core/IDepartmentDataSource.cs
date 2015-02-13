using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanager.Core
{
    public interface IDepartmentDataSource
    {
         IQueryable<Employee> Employees { get; set; }
         IQueryable<Department> Departments { get; set; }

    }
}
