using ProEventos.Domain.Entitys;

namespace ProEventos.Application.Dtos
{
    public class EventoDto : BaseDto
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
    }
}
