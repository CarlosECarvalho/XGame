using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string Email { get; set; } //como o request é entrada de servico, é bom usar tipos primitivos
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}
