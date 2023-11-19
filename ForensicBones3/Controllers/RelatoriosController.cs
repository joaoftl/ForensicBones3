﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones3.Models;

namespace ForensicBones3.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly AppDbContext _context;

        public RelatoriosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Relatorios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Relatorios.Include(r => r.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Relatorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Relatorios == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.RelatorioId == id);
            if (relatorio == null)
            {
                return NotFound();
            }

            return View(relatorio);
        }

        // GET: Relatorios/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Relatorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RelatorioId,Codigo,UsuarioId,Data,Observacoes")] Relatorio relatorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relatorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", relatorio.UsuarioId);
            return View(relatorio);
        }

        // GET: Relatorios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Relatorios == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorios.FindAsync(id);
            if (relatorio == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", relatorio.UsuarioId);
            return View(relatorio);
        }

        // POST: Relatorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RelatorioId,Codigo,UsuarioId,Data,Observacoes")] Relatorio relatorio)
        {
            if (id != relatorio.RelatorioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioExists(relatorio.RelatorioId))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", relatorio.UsuarioId);
            return View(relatorio);
        }

        // GET: Relatorios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Relatorios == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.RelatorioId == id);
            if (relatorio == null)
            {
                return NotFound();
            }

            return View(relatorio);
        }

        // POST: Relatorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Relatorios == null)
            {
                return Problem("Entity set 'AppDbContext.Relatorios'  is null.");
            }
            var relatorio = await _context.Relatorios.FindAsync(id);
            if (relatorio != null)
            {
                _context.Relatorios.Remove(relatorio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Documento (int? id)
        {
            if (id == null)
                return NotFound();

            var inventario = await _context.InventariosEsqueletos.FindAsync(id);

            if(inventario == null) 
                return NotFound();
            
            var cranio = await _context.InventariosCranio
                .Where(c => c.InventarioCranioId == id)
                .ToListAsync();

            var descricoes = await _context.DescricoesCranios.ToListAsync();

            ViewBag.Inventario = inventario;
            ViewBag.Cranio = cranio;

            return View(descricoes);
        }

        private bool RelatorioExists(int id)
        {
          return _context.Relatorios.Any(e => e.RelatorioId == id);
        }
    }
}
