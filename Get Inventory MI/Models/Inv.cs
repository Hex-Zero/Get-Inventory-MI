using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Get_Inventory_MI.Models
{
    public class Inv
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Sku")]
        public string Sku { get; set; }

        [BsonElement("Inventory")]
        public string Inventory { get; set; }

    }
}