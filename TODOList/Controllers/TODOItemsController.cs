using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TODOList.Data;
using TODOList.Models;
using PagedList;

namespace TODOList.Controllers
{
    public class TODOItemsController : Controller
    {
        private readonly TODOListContext _context;

        public TODOItemsController(TODOListContext context)
        {
            _context = context;
        }

        // GET: TODOItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.TODOItem.ToListAsync());
        }

        // GET: TODOItems/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tODOItem = await _context.TODOItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tODOItem == null)
            {
                return NotFound();
            }

            return View(tODOItem);
        }

        // GET: TODOItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TODOItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Descricao,Concluido,DataHoraInsercao,DataHoraVencimento,DataHoraFinalizacao,DataHoraAtualizacao")] TODOItem tODOItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tODOItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tODOItem);
        }

        // GET: TODOItems/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tODOItem = await _context.TODOItem.FindAsync(id);
            if (tODOItem == null)
            {
                return NotFound();
            }
            return View(tODOItem);
        }

        // POST: TODOItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Descricao,Concluido,DataHoraInsercao,DataHoraVencimento,DataHoraFinalizacao,DataHoraAtualizacao")] TODOItem tODOItem)
        {
            if (id != tODOItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tODOItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TODOItemExists(tODOItem.Id))
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
            return View(tODOItem);
        }

        // GET: TODOItems/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tODOItem = await _context.TODOItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tODOItem == null)
            {
                return NotFound();
            }

            return View(tODOItem);
        }

        // POST: TODOItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tODOItem = await _context.TODOItem.FindAsync(id);
            _context.TODOItem.Remove(tODOItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TODOItemExists(long id)
        {
            return _context.TODOItem.Any(e => e.Id == id);
        }
    }
}
