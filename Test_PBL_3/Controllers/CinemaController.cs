using Microsoft.AspNetCore.Mvc;
using Test_PBL_3.Data;

namespace Test_PBL_3.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDBContext _context;

        public CinemaController(AppDBContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            var all_cinema = _context.Cinemas.ToList(); 
            return View(all_cinema);
        }
    }
}
