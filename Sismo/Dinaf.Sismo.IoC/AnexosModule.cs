using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.Anexos;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Anexos.Repositories;
using Dinaf.Sismo.Infrastructure.Anexos.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class AnexosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<AnexoRepository>()
                .As<IAnexosRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<AnexoService>().As<IAnexoService>();
        }
    }
}