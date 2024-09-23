using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Logs.Settings
{
    /// <summary>
    /// Classe para mapearmos os parâmetros de conexão com o MongoDB
    /// </summary>
    public class MongoDBSettings
    {
        //Endereço do servidor para conexão com o banco de dados
        public static string Uri => "mongodb://localhost:27017/";

        //Nome do banco de dados que iremos acessar
        public static string Database => "BDAuditoria";
    }
}
