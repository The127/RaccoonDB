using Microsoft.EntityFrameworkCore.Storage;

namespace EntityFrameworkCore.RaccoonDb.Storage.Internal
{
    public class RaccoonDbTypeMappingSource : RelationalTypeMappingSource
    {
        // https://github.com/dotnet/efcore/blob/f6b109b48c5f98988e3fd1da08f6dde0a9c1f533/src/EFCore.Sqlite.Core/Storage/Internal/SqliteTypeMappingSource.cs
        
        public RaccoonDbTypeMappingSource(TypeMappingSourceDependencies dependencies, RelationalTypeMappingSourceDependencies relationalDependencies) : base(dependencies, relationalDependencies)
        {
        }
    }
}