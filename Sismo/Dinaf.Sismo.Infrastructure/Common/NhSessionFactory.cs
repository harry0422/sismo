﻿using Dinaf.Sismo.Infrastructure.Personas.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace Dinaf.Sismo.Infrastructure.Common
{
    public static class NhSessionFactory
    {
        public static ISessionFactory Create(string connectionString)
        {
            try
            {
                return Fluently.Configure()
                    .Database(PostgreSQLConfiguration.PostgreSQL82
                    .ConnectionString(connectionString))
                    .Mappings(c => c.FluentMappings.AddFromAssemblyOf<PersonaMap>())
                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}