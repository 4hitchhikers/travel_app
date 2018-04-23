using Microsoft.EntityFrameworkCore;

namespace travel_app.Models
{
    public class TravelContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Picture> pictures { get; set; }
    }
}