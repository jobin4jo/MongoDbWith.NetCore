using MongoDBAPI.NetCore.Model;

namespace MongoDBAPI.NetCore.Repositories.IRepository
{
    public interface IInspectionsRepository
    {
        //List<Inspections> GetAll();
        Inspections GetByid(string id);
        Task<Inspections> CreateInspection(Inspections inspection);
        Task<bool> Remove(string id);
        Task<bool>Update(string id,Inspections inspections);
        Task<user> getUser();
    }
}
