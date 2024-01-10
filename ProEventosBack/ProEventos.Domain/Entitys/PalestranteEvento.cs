using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Entitys
{
    public class PalestranteEvento 
    {
        public long PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
        public long EventoId { get; set; }
        public Evento Evento { get; set; }

        public PalestranteEvento() { }
    }
}
