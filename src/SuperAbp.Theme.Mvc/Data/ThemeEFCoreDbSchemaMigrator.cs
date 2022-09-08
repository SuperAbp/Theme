using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace SuperAbp.Theme.Data;

public class ThemeEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public ThemeEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ThemeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ThemeDbContext>()
            .Database
            .MigrateAsync();
    }
}
