using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;
namespace WebAppLab
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess,DataAccess>();

            services.AddTransient<IMarcaVehiculoService, MarcaVehiculoService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddTransient<ICatalogoProvinciaService, CatalogoProvinciaService>();
            services.AddTransient<ICatalogoCantonService, CatalogoCantonService>();
            services.AddTransient<ICatalogoDistritoService, CatalogoDistritoService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();
            services.AddTransient<IAlquilerService, AlquilerService>();

            return services;
        }
    }
}
