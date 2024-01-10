using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Domain.Entitys
{
    public class Lote : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime InicioVendas { get; set; }
        public DateTime FimVendas { get; set; }
        public int QuantidadeIngrecos { get; set; }
        public long EventoId { get; set; }
        public Evento Evento { get; set; }
        public bool IsAtivo { get; set; } = true;

        public Lote() { }
        public void Update(Lote lote)
        {
            Nome = lote.Nome;
            Valor = lote.Valor;
            InicioVendas = lote.InicioVendas;
            FimVendas = lote.FimVendas;
            QuantidadeIngrecos = lote.QuantidadeIngrecos;
            EventoId = lote.EventoId;
        }
    }
}
