using HomesFullStack.Server.Models;

namespace HomesFullStack.Server.Services.Interfaces
{
    public interface IHomeService
    {

        public Task<List<Home>> GetAllHomesAsync();
        public Task AddNewHomeAsync (Home home);
        

    }
}
