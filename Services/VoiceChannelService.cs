using System.Collections.Generic;
using System.Linq;
using AnimeBackend.Models;

namespace AnimeBackend.Services
{
    public class VoiceChannelService
    {
        private readonly AppDbContext _context;

        public VoiceChannelService(AppDbContext context)
        {
            _context = context;
        }

        public List<VoiceChannel> GetAllVoiceChannels()
        {
            return _context.VoiceChannels.ToList();
        }
    }
}
