using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Vulneraciones.Repositories;
using Dinaf.Sismo.Infrastructure.Vulneraciones.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class VulneracionesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<VulneracionRepository>()
                .As<IVulneracionRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<VulneracionService>().As<IVulneracionService>();
        }
    }
}