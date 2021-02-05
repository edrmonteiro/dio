using api.Data.Collections;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectedController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infected> _infectadosCollection;

        public InfectedController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infected>(typeof(Infected).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SaveInfected([FromBody] InfectedDto dto)
        {
            var infectado = new Infected(dto.Birthday, dto.Gender, dto.Latitude, dto.Longitude);

            _infectadosCollection.InsertOne(infectado);
            
            return StatusCode(201, "Infected added successful");
        }

        [HttpGet]
        public ActionResult GetInfected()
        {
            var infected = _infectadosCollection.Find(Builders<Infected>.Filter.Empty).ToList();
            
            return Ok(infected);
        }

        [HttpPut]
        public ActionResult ChangeInfected([FromBody] InfectedDto dto)
        {
            _infectadosCollection.UpdateOne(Builders<Infected>.Filter.Where(x => x.Birthday == dto.Birthday), Builders<Infected>.Update.Set( "Gender",  dto.Gender ));
            
            return Ok("Changed");
        }    

        [HttpDelete]
        public ActionResult DeleteInfected([FromBody] InfectedDto dto)
        {
            _infectadosCollection.DeleteOne(Builders<Infected>.Filter.Where(x => x.Birthday == dto.Birthday));
            
            return Ok("Deleted");
        }          
    }
}
