using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharecterController : ControllerBase
    {
       private static List<Charecter> charecters = new List<Charecter> {
        new Charecter(),
        new Charecter{Name = "sam" }
    
       };

[HttpGet("GetAll")]
       public ActionResult<Charecter> Get() {
        return Ok(charecters);
       }
       [HttpGet("{id}")]
       public ActionResult<Charecter> GetSingle(int id) {
        return Ok(charecters.FirstOrDefault(c => c.Id == id));
       }

[HttpPost]
       public ActionResult<List<Charecter>> AddCharecter(Charecter newCharecter) {

charecters.Add(newCharecter);
return Ok(charecters);

       }
    }
// since we have two get methods we have to add routing to tell api which one to add first
   
    }
    
