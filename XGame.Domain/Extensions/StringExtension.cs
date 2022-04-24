using System.Text;

namespace XGame.Domain.Extensions
{
    public static class StringExtension //criptografa a senha
    {
        public static string ConvertToMD5(this string passWord) //o comando this referencia o proprio conteudo da variavel, tornando essa classe uma extensão do metodo string
        {
            if (string.IsNullOrEmpty(passWord))
                return "";
            var password = (passWord += "|2d331cca-f6c0-40c0-bb43--6e32989c2881"); //insere a criptografia na string
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var subString = new StringBuilder();
            foreach (var t in data)
            { subString.Append(t.ToString("x2")); }

            return subString.ToString();
        }
    }
}
