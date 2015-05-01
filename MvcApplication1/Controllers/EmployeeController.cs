using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {

        public IEmployeeService EmployeeService { get; set; }
        
        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }
        
        [HttpGet]
        public Employee GetEmployeeById(string id)
        {
            return EmployeeService.GetEmployeeById(id);
        }

        [HttpGet]
        public Employee GetEmployeeByName(string name)
        {
            return EmployeeService.GetEmployeeByName(name);
        }


    }

}
