using EmployeeDepartmentApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;

namespace EmployeeDepartmentApi
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);

			var container = new UnityContainer();
			RegisterTypes(container);
		}

		private void RegisterTypes(IUnityContainer container)
		{
			// Register types
			container.RegisterType<IEmployeeRepository, EmployeeRepository>();
			container.RegisterType<IDepartmentRepository, DepartmentRepository>();
		}
	}
}
