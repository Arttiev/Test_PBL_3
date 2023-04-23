using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_PBL_3.Data;
using Test_PBL_3.Models;

namespace Test_PBL_3.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _context;

        public ProducersController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Producers
        public async Task<IActionResult> Index()
        {
            var all_Producers = await _context.Producers.ToListAsync();
            return View(all_Producers);
        }
    }
}
