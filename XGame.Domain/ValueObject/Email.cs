using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObject
{
    public class Email : Notifiable
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, Message.X0_INVALIDO.ToFormat("E-mail"));
        }
    }
}
