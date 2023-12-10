using RunGroup.Models;

namespace RunGroup.Interfaces
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<Race> GetById(int id);
        Task<IEnumerable<Race>> GetByCity(string city);
        bool Update(Race model);
        bool Delete(Race model);
        bool Save();
    }
}