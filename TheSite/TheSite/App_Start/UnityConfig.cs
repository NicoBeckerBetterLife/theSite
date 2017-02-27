using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Domain.interfaces;
using Domain.Services;

namespace TheSite
{
    public static class UnityConfig
    {
        public static UnityContainer Container;
        public static void RegisterComponents()
        {
			Container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            Container.RegisterType<IExpenditure, Expenditure>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
        }
    }
}