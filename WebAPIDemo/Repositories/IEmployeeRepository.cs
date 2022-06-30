using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
   public interface IEmployeeRepository
    {
        int AddEmployee(Employee e);
        IEnumerable<Employee> GetAllEmployee();
        
        int ModifyEmployee(Employee E);
        int DeleteEmployee(int id);

    }
}
