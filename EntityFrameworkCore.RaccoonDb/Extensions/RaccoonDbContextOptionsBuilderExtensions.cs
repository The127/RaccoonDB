using System;
using System.Data.Common;
using Ardalis.GuardClauses;
using EntityFrameworkCore.RaccoonDb.Infrastructure;
using EntityFrameworkCore.RaccoonDb.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EntityFrameworkCore.RaccoonDb.Extensions
{
    public static class RaccoonDbContextOptionsBuilderExtensions
    {
        public static DbContextOptionsBuilder UseRaccoonDb(
            this DbContextOptionsBuilder optionsBuilder,
            Action<RaccoonDbContextOptionsBuilder>? raccoonDbOptionsAction = null)
        {
            Guard.Against.Null(optionsBuilder, nameof(optionsBuilder));

            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(
                GetOrCreateExtension(optionsBuilder));

            ConfigureWarnings(optionsBuilder);

            raccoonDbOptionsAction?.Invoke(new RaccoonDbContextOptionsBuilder(optionsBuilder));

            return optionsBuilder;
        }

        public static DbContextOptionsBuilder UseRaccoonDb(
            this DbContextOptionsBuilder optionsBuilder,
            string connectionString,
            Action<RaccoonDbContextOptionsBuilder>? raccoonDbOptionsAction = null)
        {
            Guard.Against.Null(optionsBuilder, nameof(optionsBuilder));
            Guard.Against.Null(connectionString, nameof(connectionString));

            var extension =
                (RaccoonDbOptionsExtension) GetOrCreateExtension(optionsBuilder).WithConnectionString(connectionString);
            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(extension);
            
            ConfigureWarnings(optionsBuilder);
            
            raccoonDbOptionsAction?.Invoke(new RaccoonDbContextOptionsBuilder(optionsBuilder));

            return optionsBuilder;
        }

        public static DbContextOptionsBuilder UseRaccoonDb(
            this DbContextOptionsBuilder optionsBuilder,
            DbConnection dbConnection,
            Action<RaccoonDbContextOptionsBuilder>? raccoonDbOptionsAction = null)
        {
            Guard.Against.Null(optionsBuilder, nameof(optionsBuilder));
            Guard.Against.Null(dbConnection, nameof(dbConnection));
            
            var extension =
                (RaccoonDbOptionsExtension) GetOrCreateExtension(optionsBuilder).WithConnection(dbConnection);
            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(extension);
            
            ConfigureWarnings(optionsBuilder);
            
            raccoonDbOptionsAction?.Invoke(new RaccoonDbContextOptionsBuilder(optionsBuilder));

            return optionsBuilder;
        }

        public static DbContextOptionsBuilder<TContext> UseRaccoonDb<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder,
            Action<RaccoonDbContextOptionsBuilder>? sqliteOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>) UseRaccoonDb(
                (DbContextOptionsBuilder) optionsBuilder, sqliteOptionsAction);

        public static DbContextOptionsBuilder<TContext> UseRaccoonDb<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder,
            string connectionString,
            Action<RaccoonDbContextOptionsBuilder>? sqliteOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>) UseRaccoonDb(
                (DbContextOptionsBuilder) optionsBuilder, connectionString, sqliteOptionsAction);

        public static DbContextOptionsBuilder<TContext> UseRaccoonDb<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder,
            DbConnection connection,
            Action<RaccoonDbContextOptionsBuilder>? sqliteOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>) UseRaccoonDb(
                (DbContextOptionsBuilder) optionsBuilder, connection, sqliteOptionsAction);

        private static RaccoonDbOptionsExtension GetOrCreateExtension(DbContextOptionsBuilder options) =>
            options.Options.FindExtension<RaccoonDbOptionsExtension>()
            ?? new RaccoonDbOptionsExtension();

        private static void ConfigureWarnings(DbContextOptionsBuilder optionsBuilder)
        {
            var coreOptionsExtension
                = optionsBuilder.Options.FindExtension<CoreOptionsExtension>()
                  ?? new CoreOptionsExtension();

            coreOptionsExtension = RelationalOptionsExtension.WithDefaultWarningConfiguration(coreOptionsExtension);

            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(coreOptionsExtension);
        }
    }
}