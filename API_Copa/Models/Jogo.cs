using System;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {

        }
        public int Id { get; set; }
        public Selecao SelecaoA { get; set; }

        public Selecao SelecaoB { get; set; }
        public DateTime CriadoEm { get; set; }
        public int PlacarA { get; set; }
        public int PlacarB { get; set; }
    }
}
