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
            //string connectionString = Environment.GetEnvironmentVariable("FIRMAS_DB", EnvironmentVariableTarget.User);
            string connectionString = "Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=Honduras2021;";

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