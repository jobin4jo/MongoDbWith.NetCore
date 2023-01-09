namespace MongoDBAPI.NetCore.Model
{
    public class EducationalStoreDatabaseSettings : IEducationalStoreDatabaseSettings
    {
        public string EducationalCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
