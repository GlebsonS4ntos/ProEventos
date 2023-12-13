using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Entitys
{
    public class Evento : Base
    {
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAtivo { get; set; } = true;

        public Evento() { }

        public void UpdatEvento(Evento e)
        {
            Local = e.Local;
            DataEvento = e.DataEvento;
            Tema = e.Tema;
            Quantidade = e.Quantidade;
            Lote = e.Lote;
            ImageUrl = e.ImageUrl;
        }
    }
}
