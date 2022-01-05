using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class ConsolidacionFamiliarModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<SolicitudAdopcionRepository>()
                .As<ISolicitudAdopcionRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));
            
            builder
                .RegisterType<NnaEstadoAdoptabilidadRepository>()
                .As<IExpedienteNnaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<ConsolidacionFamiliarService>().As<IConsolidacionFamiliarService>();
        }
    }
}