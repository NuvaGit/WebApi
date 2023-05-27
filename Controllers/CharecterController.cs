using dotnet_rpg.Models;
using dotnet_rpg.Services.CharecterService;
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

        public ICharecterService _CharecterService { get; }

        public CharecterController(ICharecterService charecterService)
       {
            _CharecterService = charecterService;
        }

[HttpGet("GetAll")]
       public async Task<ActionResult<ServiceResponse<Charecter>>> Get() {
        return Ok(await _CharecterService.GetAllCharecter());
       }
       [HttpGet("{id}")]

       public async Task<ActionResult<ServiceResponse<Charecter>>> GetSingle(int id) {
        return Ok(await _CharecterService.GetCharecterById(id));
       }

[HttpPost]
       public async Task<ActionResult<ServiceResponse<List<Charecter>>>> AddCharecter(Charecter newCharecter) {

return Ok(await _CharecterService.AddCharecter(newCharecter));

       }
    }
// since we have two get methods we have to add routing to tell api which one to add first
   
    }
    
