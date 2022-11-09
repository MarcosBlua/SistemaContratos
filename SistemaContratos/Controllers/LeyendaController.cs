using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaContratos.Data;
using SistemaContratos.Models;

namespace SistemaContratos.Controllers
{
    public class LeyendaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeyendaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Leyenda
        public async Task<IActionResult> Index()
        {
              return View(await _context.leyenda.ToListAsync());
        }

        // GET: Leyenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.leyenda == null)
            {
                return NotFound();
            }

            var leyenda = await _context.leyenda
                .FirstOrDefaultAsync(m => m.id == id);
            if (leyenda == null)
            {
                return NotFound();
            }

            return View(leyenda);
        }

        // GET: Leyenda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leyenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descripcion,anio")] Leyenda leyenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leyenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leyenda);
        }

        // GET: Leyenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.leyenda == null)
            {
                return NotFound();
            }

            var leyenda = await _context.leyenda.FindAsync(id);
            if (leyenda == null)
            {
                return NotFound();
            }
            return View(leyenda);
        }

        // POST: Leyenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descripcion,anio")] Leyenda leyenda)
        {
            if (id != leyenda.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leyenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeyendaExists(leyenda.id))
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
            return View(leyenda);
        }

        // GET: Leyenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.leyenda == null)
            {
                return NotFound();
            }

            var leyenda = await _context.leyenda
                .FirstOrDefaultAsync(m => m.id == id);
            if (leyenda == null)
            {
                return NotFound();
            }

            return View(leyenda);
        }

        // POST: Leyenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.leyenda == null)
            {
                return Problem("Entity set 'ApplicationDbContext.leyenda'  is null.");
            }
            var leyenda = await _context.leyenda.FindAsync(id);
            if (leyenda != null)
            {
                _context.leyenda.Remove(leyenda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeyendaExists(int id)
        {
          return _context.leyenda.Any(e => e.id == id);
        }
    }
}
