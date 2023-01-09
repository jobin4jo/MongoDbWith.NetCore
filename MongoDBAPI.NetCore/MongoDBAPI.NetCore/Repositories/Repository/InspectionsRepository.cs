using MongoDB.Driver;
using MongoDBAPI.NetCore.Model;
using MongoDBAPI.NetCore.Repositories.IRepository;

namespace MongoDBAPI.NetCore.Repositories.Repository
{
    public class InspectionsRepository : IInspectionsRepository
    {
        private readonly IMongoCollection<Inspections> _inspections;
        public InspectionsRepository(IEducationalStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _inspections = database.GetCollection<Inspections>(settings.EducationalCollectionName);

        }
        public Task<Inspections> CreateInspection(Inspections inspection)
        {
            throw new NotImplementedException();
        }

        //public  List<Inspections> GetAll()
        //{
        //    return _inspections.Find().ToList();
        //}

        public Inspections GetByid(string id)
        {
            return _inspections.Find(s => s.Id == id).FirstOrDefault();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(string id, Inspections inspections)
        {
            throw new NotImplementedException();
        }
    }
}
