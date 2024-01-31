using EmployeeDepartmentApi.Repositories;
using EmployeeDepartmentApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;
using Unity.AspNet.WebApi;

namespace EmployeeDepartmentApi
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);

			var container = new UnityContainer();
			RegisterTypes(container);
			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}

		private void RegisterTypes(IUnityContainer container)
		{
			// Register types
			container.RegisterType<IEmployeeService, EmployeeService>();
			container.RegisterType<IEmployeeRepository, EmployeeRepository>();
			container.RegisterType<IDepartmentRepository, DepartmentRepository>();
		}
	}
}
