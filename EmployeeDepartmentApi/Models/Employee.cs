using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public int DepartmentId { get; set; }
		public string Position { get; set; }
		public DateTime HireDate { get; set; }
		public decimal Salary { get; set; }
		public bool IsFullTime { get; set; }

		// Manager Relationship
		public int? ManagerId { get; set; }
		public Employee Manager { get; set; }
	}
}