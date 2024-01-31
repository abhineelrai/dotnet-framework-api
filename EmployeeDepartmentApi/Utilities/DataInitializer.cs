using EmployeeDepartmentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApi.Utilities
{
	public static class DataInitializer
	{
		public static List<Employee> Employees { get; private set; }
		public static List<Department> Departments { get; private set; }

		static DataInitializer()
		{
			InitializeData();
		}

		private static void InitializeData()
		{
			// Initialize Departments
			Departments = new List<Department>
			{
				new Department{Id=1, Name="Executive",Description="Executive Leadership",Location="Headquarters"},
				new Department{Id=2, Name="Human Resources",Description="Handles HR activities",Location="Building A"},
				new Department{Id=3,Name="IT",Description="Handles IT and systems",Location="Building B"}
			};

			// Initialize Employees
			Employees = new List<Employee>
			{
				new Employee{Id=1, Name="Alice CEO", Email="alice.ceo@example.com", DepartmentId=1, Position="CEO", HireDate=DateTime.Now.AddYears(-5), Salary=150000, IsFullTime=true, ManagerId=null},
				new Employee{Id=2, Name="Bob HR", Email="bob.hr@example.com", DepartmentId=2, Position="HR Manager", HireDate=DateTime.Now.AddYears(-3), Salary=80000, IsFullTime=true, ManagerId=1},
				new Employee{Id=3, Name="Charlie HR", Email="charlie.hr@example.com", DepartmentId=2, Position="HR Assistant", HireDate=DateTime.Now.AddYears(-1), Salary=50000, IsFullTime=true, ManagerId=2},
				new Employee{Id=4, Name="Dave IT", Email="dave.it@example.com", DepartmentId=3, Position="IT Manager", HireDate=DateTime.Now.AddYears(-4), Salary=85000, IsFullTime=true, ManagerId=1},
				new Employee{Id=5, Name="Eve IT", Email="eve.it@example.com", DepartmentId=3, Position="IT Specialist", HireDate=DateTime.Now.AddYears(-2), Salary=60000, IsFullTime=true, ManagerId=4},
			};
		}
	}
}