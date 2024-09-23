using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Security.Settings
{
    /// <summary>
    /// Classe para configurar os parâmetros do token JWT
    /// </summary>
    public class JwtTokenSettings
    {
        //chave secreta utilizada para criptografar e assinar o token
        public static string SecretKey => "1E92AE30-F833-4923-9101-37183BCB9833";

        //tempo de expiração do token em horas
        public static int ExpirationInHours => 1;
    }
}
