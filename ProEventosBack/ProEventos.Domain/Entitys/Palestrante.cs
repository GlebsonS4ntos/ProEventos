using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Entitys
{
    public class Palestrante : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
        public bool IsAtivo { get; set; } = true;

        public Palestrante() { }

        public void UpdatePalestrante(Palestrante palestrante)
        {
            Nome = palestrante.Nome;
            Descricao = palestrante.Descricao;
            ImagemUrl = palestrante.ImagemUrl;
            Telefone = palestrante.Telefone;
            Email = palestrante.Email;
            RedesSociais = palestrante.RedesSociais;
            PalestrantesEventos = palestrante.PalestrantesEventos;
        }
    }
}
