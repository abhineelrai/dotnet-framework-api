using EmployeeDepartmentApi.Models;
using EmployeeDepartmentApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			this.employeeRepository = employeeRepository;
		}
		public void AddEmployee(Employee employee)
		{
			employeeRepository.Add(employee);
		}

		public void DeleteEmployee(int id)
		{
			employeeRepository.Delete(id);
		}

		public IEnumerable<Employee> GetAllEmployees()
		{
			return employeeRepository.GetAll();
		}

		public Employee GetEmployeeById(int id)
		{
			return employeeRepository.GetById(id);
		}

		public void UpdateEmployee(Employee employee)
		{
			employeeRepository.Update(employee);
		}
	}
}