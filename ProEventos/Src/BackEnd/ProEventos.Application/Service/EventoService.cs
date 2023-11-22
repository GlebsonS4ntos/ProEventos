using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Application.Interfaces;
using ProEventos.Domain.Entitys;
using ProEventos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Service
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _repository;
        private readonly IMapper _mapper;

        public EventoService(IEventoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EventoDto> AddEventosAsync(EventoDto model)
        {
            Evento e = _mapper.Map<Evento>(model);
            Evento eventoCriado = await _repository.AddAsync(e);
            return _mapper.Map<EventoDto>(eventoCriado);
        }

        public async Task DeleteEventoAsync(long eventoId)
        {
            await _repository.DeleteAsync(eventoId);
        }

        public async Task<IEnumerable<EventoDto>> GetAllEventosAsync()
        {
            IEnumerable<Evento> eventos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<EventoDto>>(eventos);
        }

        public async Task<EventoDto> GetEventoByIdAsync(long eventoId)
        {
            Evento e = await _repository.GetByIdAsync(eventoId);
            return _mapper.Map<EventoDto>(e);
        }

        public async Task<EventoDto> UpdateEventoAsync(long eventoId, EventoDto model)
        {
            Evento evento = _mapper.Map<Evento>(model);
            Evento eventoUpdate = await _repository.UpdateAsync(evento, eventoId);
            return _mapper.Map<EventoDto>(eventoUpdate);
        }
    }
}
