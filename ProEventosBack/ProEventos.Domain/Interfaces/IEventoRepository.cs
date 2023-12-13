using ProEventos.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Interfaces
{
    public interface IEventoRepository
    {
        Task<IEnumerable<Evento>> GetAllAsync();
        Task<Evento> GetByIdAsync(long eventoId);
        Task<Evento> UpdateAsync(Evento evento, long eventoId);
        Task<Evento> AddAsync(Evento evento);
        Task DeleteAsync(long eventoId );
    }
}
