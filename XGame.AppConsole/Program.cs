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
            AutenticarJogadorRequest AutenticarRequest = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            AutenticarRequest.Email = "carlos@carlos.com.br";
            AutenticarRequest.Senha = "1234567";

            var AdicionarRequest = new AdicionarJogadorRequest() { //populando a request
                Email = "carlosed@carlos.com.br",
                PrimeiroNome = "Carlos Eduardo",
                Sobrenome = "Ferreira Carvalho",
                Senha = "123456"

            };
            var responseAutenticado = service.AutenticarJogador(AutenticarRequest);
            var responseAdicionado = service.AdicionarJogador(AdicionarRequest);

        
        Console.WriteLine("Serviço Validado: " +service.IsValid());

            service.Notifications.ToList().ForEach(X => { Console.WriteLine(X.Message); });
            Console.ReadKey();
        }
    }
}
