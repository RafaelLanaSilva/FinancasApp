using FinancasApp.Infra.Logs.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Logs.Contexts
{
    /// <summary>
    /// Classe de contexto para conexão com o banco de dados do MongoDB
    /// </summary>
    public class MongoDbContext
    {
        //atributo para conexão com o banco de dados do MongoDb
        private IMongoDatabase? _mongoDatabase;

        //método construtor
        public MongoDbContext()
        {
            //acessando o servidor do banco de dados
            var settings = MongoClientSettings.FromUrl(new MongoUrl(MongoDBSettings.Uri));
            var client = new MongoClient(settings);

            //abringo conexão com o banco de dados
            _mongoDatabase = client.GetDatabase(MongoDBSettings.Database);
        }
    }
}
