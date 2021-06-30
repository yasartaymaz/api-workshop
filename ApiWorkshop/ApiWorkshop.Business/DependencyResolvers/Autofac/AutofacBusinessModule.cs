using ApiWorkshop.Business.Abstract;
using ApiWorkshop.Business.Concrete;
using ApiWorkshop.DataAccess.Abstract;
using ApiWorkshop.DataAccess.Concrete.EntityFramework.MainContext.Operations;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerDA>().As<ICustomerDA>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();

            base.Load(builder);
        }

    }
}
