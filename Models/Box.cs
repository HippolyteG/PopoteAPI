using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POPOST.Models
{
    [PrimaryKey(nameof(Date))]
    public class Box
    {
        [Required]
        public DateTimeOffset Date { get; set; }
        [Required]
        public float Weight { get; set; }
    }

    public class BoxDbContext : DbContext
    {
        public BoxDbContext(DbContextOptions<BoxDbContext> options)
        : base(options)
        {
        }

        public DbSet<Box> Box { get; set; }
    }
}
