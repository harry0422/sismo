using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.Expedientes;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Expedientes.Repositories;
using Dinaf.Sismo.Infrastructure.Expedientes.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class ExpedientesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ExpedienteRepository>()
                .As<IExpedienteRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<ExpedienteService>().As<IExpedienteService>();
        }
    }
}