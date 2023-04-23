using Microsoft.AspNetCore.Mvc;
using Test_PBL_3.Data;

namespace Test_PBL_3.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDBContext _context;
        public ActorController(AppDBContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {   
            //
            var data = _context.Actors.ToList();

            return View(data);
        }
    }
}
