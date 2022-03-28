using prmToolkit.NotificationPattern;
using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program : Notifiable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando....");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do serviço...");
            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            var response = service.AutenticarJogador(request);

            Console.WriteLine("Serviço Validado: " +service.IsValid());

            service.Notifications.ToList().ForEach(X => { Console.WriteLine(X.Message); });
            Console.ReadKey();
        }
    }
}
