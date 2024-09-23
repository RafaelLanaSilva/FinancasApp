﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Settings
{
    /// <summary>
    /// Classe para mapear / configurar o caminho da conexão do banco de dados utilizado pelo EntityFramework
    /// </summary>
    public class SqlServerSettings
    {
        public static string ConnectionString => "Data Source=localhost,1433;User ID=sa;Password=Coti2024!;Encrypt=False";
    }
}
