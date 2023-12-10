using Microsoft.EntityFrameworkCore;
using RunGroup.Data;
using RunGroup.Interfaces;
using RunGroup.Models;

namespace RunGroup.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly AppDbContext _context;

        public ClubRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Delete(Club model)
        {
            _context.Remove(model);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs.ToListAsync();
        }

        public async Task<IEnumerable<Club>> GetByCity(string city)
        {
            return await _context.Clubs.Where(x => x.Address.City.Contains(city)).ToListAsync();
        }

        public Task<Club> GetById(int id)
        {
            return _context.Clubs
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Club model)
        {
            _context.Update(model);
            return Save();
        }
    }
}