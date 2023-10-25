using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Esercizio2.Entities
{ 
public class Categoria

{

    //Bson annotations

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public String? CategoryId { get; set; }

    [BsonElement("CategoryName")]
    public string CategoryName { get; set; }

   public List<Prodotto> prodotti { get; set; }



    }
} 