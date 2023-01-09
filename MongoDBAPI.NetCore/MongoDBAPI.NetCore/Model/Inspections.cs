using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoDBAPI.NetCore.Model
{
    [BsonIgnoreExtraElements]
    public class Inspections
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string Id { get; set; }
        [BsonElement("id")]  
        public string ID { get; set; }
        [BsonElement("certificate_number")]
        public int CertificationNumber { get; set; }
        [BsonElement("business_name")]
        public string BusinessName { get; set; }
        [BsonElement("date")]
        public string Date { get; set; }
        [BsonElement("result")]
        public string Results { get; set; }
        [BsonElement("sector")]
        public string sector { get; set; }
        [BsonElement("address")]
        public string[]? Address { get; set; }  
    }
}
