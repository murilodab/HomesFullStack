using HomesFullStack.Server.Models;

namespace HomesFullStack.Server.Services.Interfaces
{
    public interface IHomeService
    {

        public Task<List<Home>> GetAllHomesAsync();
        public Task AddNewHomeAsync (Home home);
        public Task<Home> GetHomeByIdAsync (int id);
        public Task DeleteHomeByIdAsync (int id);
        public Task<Home> EditHomeAsync (Home home);


        

    }
}
