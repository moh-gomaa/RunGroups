using RunGroup.Models;

namespace RunGroup.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetById(int id);
        Task<IEnumerable<Club>> GetByCity(string city);
        bool Update(Club model);
        bool Delete(Club model);
        bool Save();
    }
}