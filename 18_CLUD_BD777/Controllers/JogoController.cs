using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _18_CLUD_BD.Context;
using _18_CLUD_BD.Models;

namespace _18_CLUD_BD.Controllers
{
    public class JogoController : Controller
    {
        private readonly AppDbContext _context;

        public JogoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Jogo
        public async Task<IActionResult> Index()
        {
              return _context.jogos != null ? 
                          View(await _context.jogos.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.jogos'  is null.");
        }

        // GET: Jogo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.jogos == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogos
                .FirstOrDefaultAsync(m => m.jogoId == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // GET: Jogo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("jogoId,Nome,Descricao,Imafem,Ativo")] Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogo);
        }

        // GET: Jogo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.jogos == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogos.FindAsync(id);
            if (jogo == null)
            {
                return NotFound();
            }
            return View(jogo);
        }

        // POST: Jogo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("jogoId,Nome,Descricao,Imagem,Ativo")] Jogo jogo)
        {
            if (id != jogo.jogoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogoExists(jogo.jogoId))
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
            return View(jogo);
        }

        // GET: Jogo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.jogos == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogos
                .FirstOrDefaultAsync(m => m.jogoId == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // POST: Jogo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.jogos == null)
            {
                return Problem("Entity set 'AppDbContext.jogos'  is null.");
            }
            var jogo = await _context.jogos.FindAsync(id);
            if (jogo != null)
            {
                _context.jogos.Remove(jogo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JogoExists(int id)
        {
          return (_context.jogos?.Any(e => e.jogoId == id)).GetValueOrDefault();
        }
    }
}
