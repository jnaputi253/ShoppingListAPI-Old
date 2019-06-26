using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingListAPI.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement(nameof(Name))]
        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; }
    }
}
