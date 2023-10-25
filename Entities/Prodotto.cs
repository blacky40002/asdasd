using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Esercizio2.Entities
{
    public class Prodotto
    {
        //Bson annotations
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? ProductId { get; set; }
        [BsonElement("ProductName")]
        public string? ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
        public int Giacenza { get; set; }
        

    }
}
