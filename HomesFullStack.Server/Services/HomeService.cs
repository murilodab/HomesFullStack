using HomesFullStack.Server.Data;
using HomesFullStack.Server.Models;
using HomesFullStack.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

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

        public async Task DeleteHomeByIdAsync(int id)
        {
            try
            {
                var home = await _context.Homes.FirstOrDefaultAsync(h => h.Id == id);

                if (home != null)
                {
                    _context.Homes.Remove(home);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task EditHomeAsync(Home home)
        {
            try
            {
                Home oldHome = await _context.Homes.FirstOrDefaultAsync(h => h.Id == home.Id);

                if(oldHome != null)
                {
                    _context.Update(home);
                    await _context.SaveChangesAsync();
                }
               

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

        public async Task<Home> GetHomeByIdAsync(int id)
        {
            Home result = new Home();

            try
            {
                result = await _context.Homes.FirstOrDefaultAsync(h => h.Id == id);
                
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        Task<Home> IHomeService.EditHomeAsync(Home home)
        {
            throw new NotImplementedException();
        }
    }
}
