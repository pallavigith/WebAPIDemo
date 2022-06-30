using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
   public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployee();
        int AddEmployee(Employee E);
        int ModifyEmployee(Employee E);
        int DeleteEmployee(int id);
    }
}
