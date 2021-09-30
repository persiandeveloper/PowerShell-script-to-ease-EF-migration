using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MyApp.DataBase
{
    public static class DependencyRegistration
    {
        public static void RegisterDbContext(this IServiceCollection services, DbConfiguration configuration)
        {
            services.AddDbContext<MyDBContext>(
                    options => _ = configuration.ProviderType switch
                    {
                        ProviderType.SQLite => options.UseSqlite(
                            configuration.SQLiteConnection,
                            x => x.MigrationsAssembly("MyApp.DataBase.SQLite")),

                        ProviderType.SQLServer => options.UseSqlServer(
                            configuration.SQLServerConnection,
                            x => x.MigrationsAssembly("MyApp.DataBase.SQLServer")),

                        _ => throw new Exception($"Unsupported provider: {configuration.ProviderType}")
                    });
        }
    }
}
