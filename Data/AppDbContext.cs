using Microsoft.EntityFrameworkCore;
using AnimeBackend.Models;

namespace AnimeBackend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<VoiceChannel> VoiceChannels { get; set; }
    }
}
