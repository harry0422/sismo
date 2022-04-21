using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.MedidasProteccion;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.MedidasProteccion.Repositories;
using Dinaf.Sismo.Infrastructure.MedidasProteccion.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class SeguimientosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<MedidaProteccionRepository>()
                .As<IMedidaProteccionRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<MedidaProteccionService>().As<IMedidaProteccionService>();
        }
    }
}