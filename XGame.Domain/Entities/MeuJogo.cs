using System;

namespace XGame.Domain.Entities
{
    public class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public DateTime DataDesejo { get; set; }
        public bool Troca { get; set; }
        public bool Venda { get; set; }

    }
}
