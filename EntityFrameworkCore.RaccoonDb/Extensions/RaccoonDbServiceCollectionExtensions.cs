using Ardalis.GuardClauses;
using EntityFrameworkCore.RaccoonDb.Diagnostics.Internal;
using EntityFrameworkCore.RaccoonDb.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkCore.RaccoonDb.Extensions
{
    public static class RaccoonDbServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityFrameworkRaccoonDb(this IServiceCollection serviceCollection)
        {
            Guard.Against.Null(serviceCollection, nameof(serviceCollection));

            var builder = new EntityFrameworkRelationalServicesBuilder(serviceCollection)
                .TryAdd<LoggingDefinitions, RaccoonDbLoggingDefinitions>()
                .TryAdd<IDatabaseProvider, DatabaseProvider<RaccoonDbOptionsExtension>>()
                //.TryAdd<IRelationalTypeMappingSource
                // https://github.com/dotnet/efcore/blob/ac2bb48b10ecf1289b568a94b7a35e8075c6d787/src/EFCore.Sqlite.Core/Extensions/SqliteServiceCollectionExtensions.cs
                // TODO: add things here
                ;

            return serviceCollection;
        }
    }
}