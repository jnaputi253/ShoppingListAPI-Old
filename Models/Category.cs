﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ShoppingListAPI.Models.Database;

namespace ShoppingListAPI.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement(CategorySchema.Name)]
        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; }
    }
}
