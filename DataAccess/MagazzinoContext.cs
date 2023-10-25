using Esercizio2.Entities;
using Esercizio2.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Esercizio2.DataAccess
{
    public class MagazzinoContext : IMagazzinoContext
    {
       

       MagazzinoDatabaseSettings _settings;

        public MagazzinoContext(IOptions<MagazzinoDatabaseSettings> magazzinoDatabaseSettings)

        {

            var client = new MongoClient(magazzinoDatabaseSettings.Value.ConnectionString);

            var database = client.GetDatabase(magazzinoDatabaseSettings.Value.DatabaseName);

            Categoria = database.GetCollection<Categoria>(magazzinoDatabaseSettings.Value.CollectionName);

            //CatalogContextSeed.SeedData(Prodotti);



        }

        public IMongoCollection<Categoria> Categoria { get; }

       
    }
}

