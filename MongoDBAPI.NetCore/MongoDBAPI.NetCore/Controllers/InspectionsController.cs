using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBAPI.NetCore.Model;
using MongoDBAPI.NetCore.Repositories.IRepository;

namespace MongoDBAPI.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionsController : ControllerBase
    {

        public readonly IInspectionsRepository inspectionRepository;
        public InspectionsController(IInspectionsRepository inspectionRepository)
        {
            this.inspectionRepository = inspectionRepository;
        }

        //[HttpGet("GetAll")]
        //public ActionResult GetAllList()
        //{

        //    var data = inspectionRepository.GetAll();
        //    if (data == null)
        //    {
        //        return Ok(new {result="data is Not Found" });
        //    }
        //    else
        //    {
        //        return Ok(new { result = data });
        //    }

        //}
        [HttpGet("ById")]
        public ActionResult<Inspections> GetAllListById(string Id )
        {

           var res= inspectionRepository.GetByid(Id);
            return res;

        }

        [HttpGet("GetUser")]
        public async Task<ActionResult> GetAlluser()
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = dbClient.GetDatabase("admin");
            var cars = db.GetCollection<BsonDocument>("user");
            var documents = cars.Find(new BsonDocument()).ToList();
            var res = documents.ToString();
            return Ok(new {  documents });
        }

    }
}
