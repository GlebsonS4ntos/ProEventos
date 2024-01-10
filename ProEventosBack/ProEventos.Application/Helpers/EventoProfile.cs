using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Service;
using ProEventos.Domain.Entitys;
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
            CreateMap<Evento, EventoDto>().ReverseMap()
                .ForMember(e => e.Id, dto => dto.MapFrom(x => x.Id))
                .ForMember(e => e.ImageUrl, dto => dto.MapFrom(x => x.ImageUrl))
                .ForMember(e => e.Local, dto => dto.MapFrom(x => x.Local))
                .ForMember(e => e.Quantidade, dto => dto.MapFrom(x => x.Quantidade))
                .ForMember(e => e.Tema, dto => dto.MapFrom(x => x.Tema))
                .ForMember(e => e.DataEvento, dto => dto.MapFrom(x => x.DataEvento));
        }
    }
}
