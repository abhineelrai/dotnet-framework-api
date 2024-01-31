using EmployeeDepartmentApi.Models;
using EmployeeDepartmentApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Services
{
	public class DepartmentService : IDepartmentService
	{
		private readonly IDepartmentRepository departmentRepository;

		public DepartmentService(IDepartmentRepository departmentRepository)
		{
			this.departmentRepository = departmentRepository;
		}
		public void AddDepartment(Department department)
		{
			departmentRepository.Add(department);
		}

		public void DeleteDepartment(int id)
		{
			departmentRepository.Delete(id);
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			return departmentRepository.GetAll();
		}

		public Department GetDepartmentById(int id)
		{
			return departmentRepository.GetById(id);
		}

		public void UpdateDepartment(Department department)
		{
			departmentRepository.Update(department);
		}
	}
}