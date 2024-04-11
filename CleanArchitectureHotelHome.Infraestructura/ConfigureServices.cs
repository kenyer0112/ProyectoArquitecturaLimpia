using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureHotelHome.Infraestructura
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelHomeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("cadena") ?? throw new InvalidOperationException("connection string 'HotelHomeDbContext not found' ")));
            services.AddTransient<ICategoriaRepositorio, CategoriaRepository>();
            services.AddTransient<IPisoRepositorio, PisoRepository>();
            services.AddTransient<IClienteRepositorio, ClienteRepository>();
            services.AddTransient<RoomRepository>();
            services.AddTransient<RoolRepository>();
            services.AddTransient<UserRopository>();
            return services;
        }
    }
}
