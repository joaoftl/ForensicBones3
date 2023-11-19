using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones3.Models;

namespace ForensicBones3.Controllers
{
    public class MarcadoresCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public MarcadoresCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MarcadoresCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.MarcadoresCranios.Include(m => m.InventarioCranio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MarcadoresCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MarcadoresCranios == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
                .Include(m => m.InventarioCranio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Create
        public IActionResult Create()
        {
            ViewData["MarcadoresCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId");
            return View();
        }

        // POST: MarcadoresCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarcadoresCranioId,InventarioCranioId,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula")] MarcadoresCranio marcadoresCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcadoresCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcadoresCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", marcadoresCranio.MarcadoresCranioId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MarcadoresCranios == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }
            ViewData["MarcadoresCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", marcadoresCranio.MarcadoresCranioId);
            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarcadoresCranioId,InventarioCranioId,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula")] MarcadoresCranio marcadoresCranio)
        {
            if (id != marcadoresCranio.MarcadoresCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcadoresCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcadoresCranioExists(marcadoresCranio.MarcadoresCranioId))
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
            ViewData["MarcadoresCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", marcadoresCranio.MarcadoresCranioId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MarcadoresCranios == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
                .Include(m => m.InventarioCranio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MarcadoresCranios == null)
            {
                return Problem("Entity set 'AppDbContext.MarcadoresCranios'  is null.");
            }
            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio != null)
            {
                _context.MarcadoresCranios.Remove(marcadoresCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcadoresCranioExists(int id)
        {
          return _context.MarcadoresCranios.Any(e => e.MarcadoresCranioId == id);
        }
    }
}
