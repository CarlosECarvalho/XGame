using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Enums;
using XGame.Domain.Extensions;
using XGame.Domain.Resources;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }


        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_E_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("A senha", "6", "32"));
            AddNotifications(email);
        }

        public Jogador(Nome nome, Email email, string senha) : this (email, senha)
        {
            Nome = nome;
            Id = Guid.NewGuid();
            Status = EnumSituacaoJogador.Processando;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_E_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("A senha", "6", "32"));

            if (IsValid())
            {
                Senha = senha.ConvertToMD5();
            }
            AddNotifications(nome, email);
        }

        public void AlterarJogador(Nome nome, Email email, EnumSituacaoJogador status) {

            Nome = nome;
            Email = email;
            new AddNotifications<Jogador>(this).IfFalse(Status == EnumSituacaoJogador.Ativo, "Este jogaodr não está Ativo. Não é possível alterar.");
            AddNotifications(nome, email);
        }


        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.Sobrenome;
        }


    }
}
