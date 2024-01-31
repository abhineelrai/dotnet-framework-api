using EmployeeDepartmentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentApi.Repositories
{
	public interface IEmployeeRepository : IRepository<Employee>
	{
		// Add other methods specific to Employee
	}
}
