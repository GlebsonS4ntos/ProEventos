using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entitys;
using ProEventos.Domain.Interfaces;
using ProEventos.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Infraestructure.Repositorys
{
    public class EventoRepository : IEventoRepository
    {
        private readonly DataContext _context;
        public EventoRepository(DataContext context) 
        { 
            _context = context;
        }
        public async Task<Evento> AddAsync(Evento evento)
        {
            _context.Eventos.Add(evento);
            await _context.SaveChangesAsync();
            return evento;
        }

        public async Task DeleteAsync(long eventoId)
        {
            Evento e = await GetByIdAsync(eventoId);
            e.IsAtivo = false;
            _context.Eventos.Update(e);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Evento>> GetAllAsync()
        {
            return await _context.Eventos.Where(e => e.IsAtivo == true).ToListAsync();
        }

        public async Task<Evento> GetByIdAsync(long eventoId)
        {
            Evento e = await _context.Eventos.FindAsync(eventoId);
            return e;
        }

        public async Task<Evento> UpdateAsync(Evento evento, long eventoId)
        {
            Evento e = await GetByIdAsync(eventoId);
            e.UpdatEvento(evento);
            _context.Eventos.Update(e);
            await _context.SaveChangesAsync();
            return e;
        }
    }
}
