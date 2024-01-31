﻿using EmployeeDepartmentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentApi.Services
{
	public interface IEmployeeService
	{
		IEnumerable<Employee> GetAllEmployees();
		Employee GetEmployeeById(int id);
		void AddEmployee(Employee employee);
		void UpdateEmployee(Employee employee);
		void DeleteEmployee(int id);
	}
}
