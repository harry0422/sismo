using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.CondicionesMedicas.Repositories;
using Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Repositories;
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
                .RegisterType<ExpedienteNnaRepository>()
                .As<IExpedienteNnaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<EmparejamientoRepository>()
                .As<IEmparejamientoRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<CondicionMedicaRepository>()
                .As<ICondicionMedicaRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<SolicitudAdopcionService>().As<ISolicitudAdopcionService>();
            builder.RegisterType<ExpedienteNnaService>().As<IExpedienteNnaService>();
            builder.RegisterType<CondicionMedicaService>().As<ICondicionMedicaService>();
            builder.RegisterType<EmparejamientoService>().As<IEmparejamientoService>();
        }
    }
}