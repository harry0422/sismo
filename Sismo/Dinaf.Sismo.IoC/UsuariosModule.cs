using Autofac;
using Autofac.Extras.DynamicProxy;
using Dinaf.Sismo.Application.Usuarios;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Domain.Usuarios.Repositories;
using Dinaf.Sismo.Infrastructure.Usuarios.Repositories;

namespace Dinaf.Sismo.IoC
{
    public class UsuariosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<UsuarioRepository>()
                .As<IUsuarioRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder
                .RegisterType<UnidadRepository>()
                .As<IUnidadRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            builder.RegisterType<UnidadService>().As<IUnidadService>();
        }
    }
}