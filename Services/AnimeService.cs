using System.Collections.Generic;
using System.Linq;
using AnimeBackend.Models;

namespace AnimeBackend.Services
{
    public class AnimeService
    {
        private readonly AppDbContext _context;

        public AnimeService(AppDbContext context)
        {
            _context = context;
        }

        public List<Anime> GetAllAnimes()
        {
            return _context.Animes.ToList();
        }
    }
}
