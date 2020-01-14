using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoeSelling.Models;

namespace ShoeSelling.Controllers
{
    public class ShoesSizesController : Controller
    {
        private readonly ShoesContext _context;

        public ShoesSizesController(ShoesContext context)
        {
            _context = context;
        }

        // GET: ShoesSizes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShoesSize.ToListAsync());
        }

        // GET: ShoesSizes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoesSize = await _context.ShoesSize
                .FirstOrDefaultAsync(m => m.SizeId == id);
            if (shoesSize == null)
            {
                return NotFound();
            }

            return View(shoesSize);
        }

        // GET: ShoesSizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoesSizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SizeId,EuNumber,UkNumber,UsNumber")] ShoesSize shoesSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoesSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoesSize);
        }

        // GET: ShoesSizes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoesSize = await _context.ShoesSize.FindAsync(id);
            if (shoesSize == null)
            {
                return NotFound();
            }
            return View(shoesSize);
        }

        // POST: ShoesSizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SizeId,EuNumber,UkNumber,UsNumber")] ShoesSize shoesSize)
        {
            if (id != shoesSize.SizeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoesSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoesSizeExists(shoesSize.SizeId))
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
            return View(shoesSize);
        }

        // GET: ShoesSizes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoesSize = await _context.ShoesSize
                .FirstOrDefaultAsync(m => m.SizeId == id);
            if (shoesSize == null)
            {
                return NotFound();
            }

            return View(shoesSize);
        }

        // POST: ShoesSizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoesSize = await _context.ShoesSize.FindAsync(id);
            _context.ShoesSize.Remove(shoesSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoesSizeExists(int id)
        {
            return _context.ShoesSize.Any(e => e.SizeId == id);
        }
    }
}
