using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
