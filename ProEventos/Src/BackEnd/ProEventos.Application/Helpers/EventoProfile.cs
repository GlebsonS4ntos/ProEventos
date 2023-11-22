using AutoMapper;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Helpers
{
    public class EventoProfile : Profile
    {
        public EventoProfile() 
        {
            CreateMap<IEventoService, EventoService>().ReverseMap();
        }
    }
}
