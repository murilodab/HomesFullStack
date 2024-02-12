using HomesFullStack.Server.Data;
using HomesFullStack.Server.Models;
using HomesFullStack.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HomesFullStack.Server.Services
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext _context;

        public HomeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddNewHomeAsync(Home home)
        {
            try
            {
                _context.Add(home);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Home>> GetAllHomesAsync()
        {
            List<Home> result = new List<Home>();

            try
            {

                result = await _context.Homes.ToListAsync();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
