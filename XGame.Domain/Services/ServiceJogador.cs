using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;
            jogador.Senha = request.Senha;
            jogador.Status = Enums.EnumSituacaoJogador.Processando;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação Realizada com sucesso." };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            { AddNotification("AutenticarJogadorRequest", Message.X0_É_OBRIGATÓRIO.ToFormat("AutenticarJogadorRequest")); }

            var email = new Email("Cadu");
            var jogador = new Jogador(email, "123");

            AddNotifications(jogador);
            if (jogador.IsInvalid())
            { return null; }

            var response = _repositoryJogador.AutenticarJogador(request);
            return response;
        }
    }
}
