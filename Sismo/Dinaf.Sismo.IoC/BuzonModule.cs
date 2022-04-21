using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.Buzon;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Buzon.Repositories;
using Dinaf.Sismo.Infrastructure.Buzon.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class BuzonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
               .RegisterType<CasoRepository>()
               .As<ICasoRepository>()
               .EnableInterfaceInterceptors()
               .InterceptedBy(typeof(TransactionInterceptor));

            builder
               .RegisterType<MensajeRepository>()
               .As<IMensajeRepository>()
               .EnableInterfaceInterceptors()
               .InterceptedBy(typeof(TransactionInterceptor));

            builder
               .RegisterType<TipoGestionRepository>()
               .As<ITipoGestionRepository>()
               .EnableInterfaceInterceptors()
               .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<CasoService>().As<ICasoService>();
            builder.RegisterType<MensajeService>().As<IMensajeService>();
            builder.RegisterType<TipoGestionService>().As<ITipoGestionService>();
        }
    }
}