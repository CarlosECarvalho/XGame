using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Services
{
    public interface IServiceJogador
    {
        string AutenticarJogador(string email, string senha);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
