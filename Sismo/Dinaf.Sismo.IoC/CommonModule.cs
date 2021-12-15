using Autofac;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Infrastructure.Common;
using NHibernate;
using System;

namespace Dinaf.Sismo.IoC
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            string connectionString = Environment.GetEnvironmentVariable("SISMO_DB", EnvironmentVariableTarget.User);

            builder.RegisterType<TransactionInterceptor>().SingleInstance();
            //builder.RegisterType<LogInterceptor>().SingleInstance();

            builder.RegisterInstance(NhSessionFactory.Create(connectionString))
                .As<ISessionFactory>()
                .SingleInstance();

            builder.RegisterType<NhUnitOfWork>().As<IUnitOfWork>();

            //builder.RegisterType<NLogLogProvider>().As<ILogProvider>();
            //builder.RegisterType<GuidIdentifierGenerator>().As<IIdentifierGenerator>();
            //builder.RegisterType<PBKDF2EncryptionProvider>().As<IEncryptionProvider>();
        }
    }
}