using System;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador entidade)
        {
            return new JogadorResponse() {
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                SegundoNome = entidade.Nome.Sobrenome,
                Email = entidade.Email.Endereco,
                NomeCompleto = entidade.ToString(),
                //Status = entidade.Status.ToString()

            };
        }
    }
}
