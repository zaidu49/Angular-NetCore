using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Z_app.Models;


namespace Z_app.Controllers
{
    //[Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        AppDataAccessLayer objemployee = new AppDataAccessLayer();

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create([FromBody] Employee employee)
        {
            return objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public Employee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody]Employee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<City> Details()
        {
            return objemployee.GetCities();
        }
    }
}
