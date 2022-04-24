using System;
using System.Collections.Generic;
using XGame.Domain.Entities;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);

        Jogador AdicionarJogador(Jogador jogador);

        IEnumerable<Jogador> ListarJogador();

        Jogador ObterJogadorPorId( Guid Id);

        void AlterarJogador(Jogador jogador);
    }
}
