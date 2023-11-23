﻿using RunGroup.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroup.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }
        public ClubCategoryEnum ClubCategory { get; set; }

        [ForeignKey("AppUser")]
        public int AppUserId { get; set; } 
        public AppUser AppUser { get; set; }
    }
}