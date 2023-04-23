using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_PBL_3.Data;
using Test_PBL_3.Models;

namespace Test_PBL_3.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _context;

        public MoviesController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var all_Movies =await _context.Movies.ToListAsync();
            return View(all_Movies);
        }
    }
}
