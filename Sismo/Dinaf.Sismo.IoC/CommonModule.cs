﻿using Autofac;
using Dinaf.Sismo.Adapters.Common;
using Dinaf.Sismo.Application.Common;
using Dinaf.Sismo.CrossCutting.Transactions;
using Dinaf.Sismo.Infrastructure.Common;
using NHibernate;

namespace Dinaf.Sismo.IoC
{
    public class CommonModule : Module
    {
        private readonly string _connectionString;

        public CommonModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {           
            builder.RegisterType<TransactionInterceptor>().SingleInstance();
            //builder.RegisterType<LogInterceptor>().SingleInstance();

            builder.RegisterInstance(NhSessionFactory.Create(_connectionString))
                .As<ISessionFactory>()
                .SingleInstance();

            builder.RegisterType<NhUnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<CifradoService>().As<ICifradoService>();

            //builder.RegisterType<NLogLogProvider>().As<ILogProvider>();
            //builder.RegisterType<GuidIdentifierGenerator>().As<IIdentifierGenerator>();
            //builder.RegisterType<PBKDF2EncryptionProvider>().As<IEncryptionProvider>();
        }
    }
}