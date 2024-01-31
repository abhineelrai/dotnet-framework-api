using EmployeeDepartmentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentApi.Repositories
{
	public interface IDepartmentRepository : IRepository<Department>
	{
		// Add other methods specific to Department
	}
}
