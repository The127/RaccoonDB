using System.Collections.Generic;
using EntityFrameworkCore.RaccoonDb.Extensions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkCore.RaccoonDb.Infrastructure.Internal
{
    public class RaccoonDbOptionsExtension : RelationalOptionsExtension
    {
        private DbContextOptionsExtensionInfo? _info;

        public RaccoonDbOptionsExtension()
        {
        }

        protected RaccoonDbOptionsExtension(RaccoonDbOptionsExtension copyFrom)
            : base(copyFrom)
        {
        }

        protected override RelationalOptionsExtension Clone() =>
            new RaccoonDbOptionsExtension(this);

        public override void ApplyServices(IServiceCollection services) =>
            services.AddEntityFrameworkRaccoonDb();

        public override DbContextOptionsExtensionInfo Info 
            => _info ??= new ExtensionInfo(this);

        private sealed class ExtensionInfo : RelationalExtensionInfo
        {
            public ExtensionInfo(IDbContextOptionsExtension extension) 
                : base(extension)
            {
            }

            private new RaccoonDbOptionsExtension Extension
                => (RaccoonDbOptionsExtension) base.Extension;

            public override void PopulateDebugInfo(IDictionary<string, string> debugInfo) =>
                debugInfo["RaccoonDb"] = "1";
        }
    }
}