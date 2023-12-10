using Microsoft.EntityFrameworkCore;
using RunGroup.Data;
using RunGroup.Interfaces;
using RunGroup.Models;

namespace RunGroup.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly AppDbContext _context;

        public RaceRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Delete(Race model)
        {
            _context.Remove(model);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {
            return await _context.Races.ToListAsync();
        }

        public async Task<IEnumerable<Race>> GetByCity(string city)
        {
            return await _context.Races.Where(x => x.Address.City.Contains(city)).ToListAsync();
        }

        public Task<Race> GetById(int id)
        {
            return _context.Races
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Race model)
        {
            _context.Update(model);
            return Save();
        }
    }
}