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
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
        public bool IsAtivo { get; set; } = true;

        public Evento() { }

        public void UpdatEvento(Evento e)
        {
            Local = e.Local;
            DataEvento = e.DataEvento;
            Tema = e.Tema;
            Quantidade = e.Quantidade;
            Email = e.Email;
            Telefone = e.Telefone;
            ImageUrl = e.ImageUrl;
        }
    }
}
