using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObject
{
    public class Nome : Notifiable
    {

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = segundoNome;

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("O primeiro nome", "3", "5")).IfNullOrInvalidLength(x => x.Sobrenome, 3, 50, Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("O primeiro nome", "3", "5"));
        }
    }
}
