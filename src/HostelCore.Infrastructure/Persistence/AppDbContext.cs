using Microsoft.EntityFrameworkCore;
using HostelCore.Domain.Entities;

namespace HostelCore.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Guest> Guests => Set<Guest>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Booking> Bookings => Set<Booking>();
    }
}