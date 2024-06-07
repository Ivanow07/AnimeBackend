using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AnimeBackend.Models;
using AnimeBackend.Services;

namespace AnimeBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimesController : ControllerBase
    {
        private readonly AnimeService _animeService;

        public AnimesController(AnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        public IEnumerable<Anime> Get()
        {
            return _animeService.GetAllAnimes();
        }
    }
}
