using EmployeeDepartmentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentApi.Services
{
	public interface IDepartmentService
	{
		IEnumerable<Department> GetAllDepartments();
		Department GetDepartmentById(int id);
		void AddDepartment(Department department);
		void UpdateDepartment(Department department);
		void DeleteDepartment(int id);
	}
}
