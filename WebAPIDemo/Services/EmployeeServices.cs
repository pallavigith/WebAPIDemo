using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _iEmployeeRepo;
        // Injecition of Dependancy using constructor
        public EmployeeServices(IEmployeeRepository iEmployeeRepo)
        {
            _iEmployeeRepo = iEmployeeRepo;
        }
        public int AddEmployee(Employee E)
        {
            return _iEmployeeRepo.AddEmployee(E);
        }

      
        public int DeleteEmployee(int id)
        {
            return _iEmployeeRepo.DeleteEmployee(id);
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _iEmployeeRepo.GetAllEmployee();
        }

        public IEnumerable<Employee> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public int ModifyEmployee(Employee E)
        {
            return _iEmployeeRepo.ModifyEmployee(E);
        }

       

    }
}



    

