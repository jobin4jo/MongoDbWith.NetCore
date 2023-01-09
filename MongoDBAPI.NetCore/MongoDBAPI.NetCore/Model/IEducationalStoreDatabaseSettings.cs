namespace MongoDBAPI.NetCore.Model
{
    public interface IEducationalStoreDatabaseSettings
    {
        string EducationalCollectionName { get;set;}
        string ConnectionString { get; set; }   
        string DatabaseName { get; set; }
    }
}
