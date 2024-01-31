using EmployeeDepartmentApi.Models;
using EmployeeDepartmentApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDepartmentApi.Controllers
{
	public class EmployeeController : ApiController
	{
		private readonly IEmployeeService employeeService;

		public EmployeeController(IEmployeeService employeeService)
		{
			this.employeeService = employeeService;
		}

		// GET api/employee
		[HttpGet]
		public IEnumerable<Employee> GetEmployees()
		{
			return employeeService.GetAllEmployees();
		}
	}
}
