using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharecterService
{
    public class ChareterService : ICharecterService
    {
         private static List<Charecter> charecters = new List<Charecter> {
        new Charecter(),
        new Charecter{Name = "sam" }
    
       };
        public async Task<ServiceResponse <List<Charecter>>> AddCharecter(Charecter newCharecter)
        {
            var  ServiceResponse = new ServiceResponse<List<Charecter>>();
             charecters.Add(newCharecter);
             return ServiceResponse;      
  }

        public async Task<ServiceResponse<List<Charecter>>> GetAllCharecter()
        {
            var  ServiceResponse = new ServiceResponse<List<Charecter>>();
            ServiceResponse.Data = charecters;
                   return ServiceResponse;

        }

        public async Task<ServiceResponse<Charecter>> GetCharecterById(int id)
        {
                        var  ServiceResponse = new ServiceResponse<Charecter>();

           var charecter =  charecters.FirstOrDefault(c => c.Id == id)!;
            // null forgiving charecter used
            ServiceResponse.Data = charecter;
            return ServiceResponse;
        }
    }
}