using System;
using Microsoft.EntityFrameworkCore;

namespace TempleTourScheduler.Models
{
    public class TempleTourDbContext : DbContext
    {
        public TempleTourDbContext(DbContextOptions<TempleTourDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TimeBlock> TimeBlocks { get; set; }
    }
}
