using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQueenDreams.Entity;

namespace WebQueenDreams.Controllers
{
    [ApiController]
    [Route("api/city")]
    public class CityController: ControllerBase
    {
        
        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return new List<City>()
            {
                new City(){Id = 2, NameCity = "Buga"},
                new City(){Id = 5, NameCity = "Ibagué"}
            };
        }
        
    }
}
