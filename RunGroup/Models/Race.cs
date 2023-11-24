using RunGroup.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroup.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        
        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        public RaceCategoryEnum RaceCategory { get; set; }

        public string? AppUserID { get; set; }
        public AppUser? AppUser { get; set; }
    }
}