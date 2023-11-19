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
    public class DescricoesCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public DescricoesCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DescricoesCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.DescricoesCranios.Include(d => d.InventarioCranio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: DescricoesCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DescricoesCranios == null)
            {
                return NotFound();
            }

            var descricaoCranio = await _context.DescricoesCranios
                .Include(d => d.InventarioCranio)
                .FirstOrDefaultAsync(m => m.DescricaoCranioId == id);
            if (descricaoCranio == null)
            {
                return NotFound();
            }

            return View(descricaoCranio);
        }

        // GET: DescricoesCranios/Create
        public IActionResult Create()
        {
            ViewData["DescricaoCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId");
            return View();
        }

        // POST: DescricoesCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DescricaoCranioId,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula")] DescricaoCranio descricaoCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(descricaoCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DescricaoCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", descricaoCranio.DescricaoCranioId);
            return View(descricaoCranio);
        }

        // GET: DescricoesCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DescricoesCranios == null)
            {
                return NotFound();
            }

            var descricaoCranio = await _context.DescricoesCranios.FindAsync(id);
            if (descricaoCranio == null)
            {
                return NotFound();
            }
            ViewData["DescricaoCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", descricaoCranio.DescricaoCranioId);
            return View(descricaoCranio);
        }

        // POST: DescricoesCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DescricaoCranioId,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula")] DescricaoCranio descricaoCranio)
        {
            if (id != descricaoCranio.DescricaoCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(descricaoCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DescricaoCranioExists(descricaoCranio.DescricaoCranioId))
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
            ViewData["DescricaoCranioId"] = new SelectList(_context.InventariosCranio, "InventarioCranioId", "InventarioCranioId", descricaoCranio.DescricaoCranioId);
            return View(descricaoCranio);
        }

        // GET: DescricoesCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DescricoesCranios == null)
            {
                return NotFound();
            }

            var descricaoCranio = await _context.DescricoesCranios
                .Include(d => d.InventarioCranio)
                .FirstOrDefaultAsync(m => m.DescricaoCranioId == id);
            if (descricaoCranio == null)
            {
                return NotFound();
            }

            return View(descricaoCranio);
        }

        // POST: DescricoesCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DescricoesCranios == null)
            {
                return Problem("Entity set 'AppDbContext.DescricoesCranios'  is null.");
            }
            var descricaoCranio = await _context.DescricoesCranios.FindAsync(id);
            if (descricaoCranio != null)
            {
                _context.DescricoesCranios.Remove(descricaoCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DescricaoCranioExists(int id)
        {
          return _context.DescricoesCranios.Any(e => e.DescricaoCranioId == id);
        }
    }
}
