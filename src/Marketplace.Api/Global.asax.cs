using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Autofac.Integration.WebApi;
using CommonServiceLocator;
using Marketplace.Api.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.UI;

namespace Marketplace.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);


            var container = new IoCConfig().GetContainer();
            var provider = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => provider);
            Infra.CrossCutting.ServiceLocator.Factory.ServiceLocator = ServiceLocator.Current;
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
