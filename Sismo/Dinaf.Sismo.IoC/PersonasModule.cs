using Autofac;
using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Implementation.Personas;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Personas.Repositories;
using Dinaf.Sismo.Infrastructure.Personas.Repositories;
using Autofac.Extras.DynamicProxy;

namespace Dinaf.Sismo.IoC
{
    public class PersonasModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<PersonaRepository>()
                .As<IPersonaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<ExpedienteRepository>()
                .As<IExpedienteRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<PersonaService>().As<IPersonaService>();
        }
    }
}