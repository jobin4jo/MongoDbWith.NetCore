using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBAPI.NetCore.Model
{
    public class user
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("id")]
        public string  id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }




    }
}
