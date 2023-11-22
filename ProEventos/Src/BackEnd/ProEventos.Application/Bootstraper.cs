using Microsoft.Extensions.DependencyInjection;
using ProEventos.Application.Helpers;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application
{
    public static class Bootstraper
    {
        public static void AddApplication(this IServiceCollection s)
        {
            AddServices(s);
            AddMapper(s);
        }

        private static void AddServices(IServiceCollection service)
        {
            service.AddScoped<IEventoService, EventoService>();
        }
        private static void AddMapper(IServiceCollection service)
        {
            service.AddScoped(provider => new AutoMapper.MapperConfiguration(x =>
            {
                x.AddProfile<EventoProfile>();
            }).CreateMapper());
        }
    }
}
