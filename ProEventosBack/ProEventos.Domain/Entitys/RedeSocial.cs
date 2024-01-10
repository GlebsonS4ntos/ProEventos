using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Entitys
{
    public class RedeSocial : Base
    {
        public string Nome { get; set; }
        public string Url { get; set; }
        public long? EventoId { get; set; }
        public Evento Evento { get; set; }
        public long? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }

        public RedeSocial() { }
        public void Update(RedeSocial entity)
        {
            Nome = entity.Nome;
            Url = entity.Url;
            EventoId = entity.EventoId;
            PalestranteId = entity.PalestranteId;
        }
    }
}
