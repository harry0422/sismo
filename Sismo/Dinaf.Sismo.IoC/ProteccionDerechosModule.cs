using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Adapters.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes.Repositories;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Repositories;
using Dinaf.Sismo.Infrastructure.ProteccionDerechos.Expedientes.Repositories;
using Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class ProteccionDerechosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ExpedienteRepository>()
                .As<IExpedienteRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<PersonaRepository>()
                .As<IPersonaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<DetallePersonaRepository>()
                .As<IDetallePersonaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));


            builder.RegisterType<ExpedienteService>().As<IExpedienteService>();
            builder.RegisterType<PersonaService>().As<IPersonaService>();
            builder.RegisterType<FotografiaService>().As<IFotografiaService>();
        }
    }
}