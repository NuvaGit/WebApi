using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharecterService
{
    public interface ICharecterService
    {
                Task <ServiceResponse<List<Charecter>>> GetAllCharecter();
                 Task<ServiceResponse< Charecter>> GetCharecterById(int id);

                 Task<ServiceResponse <List<Charecter>>> AddCharecter(Charecter  newCharecter);

    }
}