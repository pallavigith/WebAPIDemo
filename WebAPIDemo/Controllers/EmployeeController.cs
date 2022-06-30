using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class EmployeeController : Controller
    {
       private readonly IEmployeeServices _Eservice;
            public EmployeeController(IEmployeeServices Eservice)
            {
                _Eservice = Eservice;
            }
            [HttpGet]

            [Route("GetEmployee")]
            public IActionResult GetEmployee()
            {
                return new ObjectResult(_Eservice.GetAllEmployee());
                // test code
            }
            [HttpPost]
            [Route("AddEmployee")]
            public IActionResult AddEmployee(Employee E)
            {
                return new ObjectResult(_Eservice.AddEmployee(E));
            }

            [HttpPost]
            [Route("ModifyEmpployee")]
            public IActionResult ModifyEmpployee(Employee E)
            {
                return new ObjectResult(_Eservice.ModifyEmployee(E));
            }

            [HttpGet]
            [Route("DeleteEmployee/{id}")]
            public IActionResult DeleteEmployee(int id)
            {
                return new ObjectResult(_Eservice.DeleteEmployee(id));
            }
        }

    }



