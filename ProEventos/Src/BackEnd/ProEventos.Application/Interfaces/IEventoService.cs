using ProEventos.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Interfaces
{
    public interface IEventoService
    {
        Task<EventoDto> AddEventosAsync(EventoDto model);
        Task<EventoDto> UpdateEventoAsync(long eventoId, EventoDto model);
        Task DeleteEventoAsync(long eventoId);
        Task<IEnumerable<EventoDto>> GetAllEventosAsync();
        Task<EventoDto> GetEventoByIdAsync(long eventoId);
    }
}
