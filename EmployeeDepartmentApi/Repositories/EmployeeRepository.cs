using EmployeeDepartmentApi.Models;
using EmployeeDepartmentApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly List<Employee> _employees;
		public EmployeeRepository()
		{
			_employees = DataInitializer.Employees;
		}

		public IEnumerable<Employee> GetAll()
		{
			return _employees;
		}

		public Employee GetById(int id)
		{
			return _employees.FirstOrDefault(e => e.Id == id);
		}

		public void Add(Employee employee)
		{
			_employees.Add(employee);
		}

		public void Update(Employee employee)
		{
			var index = _employees.FindIndex(e => e.Id == employee.Id);
			if (index != -1)
			{
				_employees[index] = employee;
			}
		}

		public void Delete(int id)
		{
			var employee = _employees.FirstOrDefault(e => e.Id == id);
			if (employee != null)
			{
				_employees.Remove(employee);
			}
		}
	}
}