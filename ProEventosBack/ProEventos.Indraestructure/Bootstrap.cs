using Microsoft.Extensions.DependencyInjection;
using ProEventos.Domain.Interfaces;
using ProEventos.Infraestructure.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Infraestructure
{
    public static class Bootstrap
    {
        public static void AddInfraEstructure(this IServiceCollection service)
        {
            AddRepositorys(service);
        }

        private static void AddRepositorys(IServiceCollection service)
        {
            service.AddScoped<IEventoRepository, EventoRepository>();
        }
    }
}
