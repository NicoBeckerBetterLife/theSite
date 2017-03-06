using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Domain.interfaces;
using Domain.Services;
using TheSite.Controllers;

namespace TheSite
{
    public static class UnityConfig
    {
        public static UnityContainer container;
        public static void RegisterComponents()
        {
			container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IExpenditure, ExpenditureService>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<UsersAdminController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}