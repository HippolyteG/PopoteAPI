using Microsoft.EntityFrameworkCore;

namespace POPOST.Models
{
    [PrimaryKey(nameof(Id))]
    public class Bike
    {
        public int Id { get; set; }
        public bool isLocked { get; set; }
        public bool isUsed { get; set; }

        public int useCount { get; set; }
    }
}
