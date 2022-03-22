using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.MedidasProteccion;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Seguimientos.Repositories;
using Dinaf.Sismo.Infrastructure.Seguimientos.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class SeguimientosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<SeguimientoRepository>()
                .As<IMedidaProteccionRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<MedidaProteccionService>().As<IMedidaProteccionService>();
        }
    }
}