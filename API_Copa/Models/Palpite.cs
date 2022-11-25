using System;

namespace API_Copa.Models
{
    public class Palpite
    {
        public Palpite() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }

        public Selecao SelecaoA { get; set; }
        public Selecao SelecaoB { get; set; }
        public Jogo Jogo { get; set; }

        public int PlacarA { get; set; }
        public int PlacarB { get; set; }
    }

}
