using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entities;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public class EmployeeRepository
    {
        private readonly IProductRepository _iProductRepo;
        // Injecition of Dependancy using constructor
        RepositoriesContext context;
        public EmployeeRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee E)
        {
            context.Employee.Add(E);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var E = context.Employee.Where(p => p.Id == id).SingleOrDefault();
            if (E != null)
            {
                context.Employee.Remove(E);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employee.ToList();
        }

        public int ModifyEmployee(Employee E)
        {
            var Employee = context.Employee.Where(p => p.Id == E.Id).SingleOrDefault();
            if (Employee != null)
            {
                Employee.Name = E.Name;
                Employee.Price = E.Price;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }

}

    
