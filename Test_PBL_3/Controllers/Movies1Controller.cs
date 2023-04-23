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
    public class Movies1Controller : Controller
    {
        private readonly AppDBContext _context;

        public Movies1Controller(AppDBContext context)
        {
            _context = context;
        }

        // GET: Movies1
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.Movies.Include(m => m.Cinema).Include(m => m.Producer);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Movies1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Cinema)
                .Include(m => m.Producer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies1/Create
        public IActionResult Create()
        {
            ViewData["CinemaID"] = new SelectList(_context.Cinemas, "ID", "ID");
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "ID");
            return View();
        }

        // POST: Movies1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,name,description,price,imgUrl,StartDate,EndDate,Movie_Category,CinemaID,ProducerID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinemaID"] = new SelectList(_context.Cinemas, "ID", "ID", movie.CinemaID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "ID", movie.ProducerID);
            return View(movie);
        }

        // GET: Movies1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewData["CinemaID"] = new SelectList(_context.Cinemas, "ID", "ID", movie.CinemaID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "ID", movie.ProducerID);
            return View(movie);
        }

        // POST: Movies1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name,description,price,imgUrl,StartDate,EndDate,Movie_Category,CinemaID,ProducerID")] Movie movie)
        {
            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinemaID"] = new SelectList(_context.Cinemas, "ID", "ID", movie.CinemaID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "ID", movie.ProducerID);
            return View(movie);
        }

        // GET: Movies1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Cinema)
                .Include(m => m.Producer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'AppDBContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
          return (_context.Movies?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
