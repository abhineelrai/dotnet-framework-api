using EmployeeDepartmentApi.Models;
using EmployeeDepartmentApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Repositories
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly List<Department> _departments;
		public DepartmentRepository()
		{
			_departments = DataInitializer.Departments;
		}

		public IEnumerable<Department> GetAll()
		{
			return _departments;
		}

		public Department GetById(int id)
		{
			return _departments.FirstOrDefault(d => d.Id == id);
		}

		public void Add(Department department)
		{
			_departments.Add(department);
		}

		public void Update(Department department)
		{
			var index = _departments.FindIndex(d => d.Id == department.Id);
			if (index != -1)
			{
				_departments[index] = department;
			}
		}

		public void Delete(int id)
		{
			var department = _departments.FirstOrDefault(d => d.Id == id);
			if (department != null)
			{
				_departments.Remove(department);

			}
		}
	}
}