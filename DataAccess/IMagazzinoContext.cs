using Esercizio2.Entities;
using MongoDB.Driver;

namespace Esercizio2.DataAccess
{
    public interface IMagazzinoContext
    {
        IMongoCollection<Categoria> Categoria { get; }
    }
}
