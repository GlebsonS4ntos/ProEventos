using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Dtos
{
    public class EventoDto : BaseDto
    {
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public string ImageUrl { get; set; }
    }
}
