using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SongList.Models;


namespace SongList.Controllers
{
    public class HomeController : Controller
    {
        private SongContext context { get; set; }

        public HomeController(SongContext ctx)
        {
            context = ctx;
        }
       
        public IActionResult Index()
        {
            var songs = context.Songs.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(songs);
        }

    }
}