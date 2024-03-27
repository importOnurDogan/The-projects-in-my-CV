using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_OnlineKursApp_ProjesiCozumu.Models.Context;
using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate;

namespace MVC_OnlineKursApp_ProjesiCozumu.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly OnlineKursDbContext _context;

        public OgrenciController(OnlineKursDbContext context)
        {
            _context = context;
        }

        // GET: Ogrenci
        public async Task<IActionResult> Index()
        {
              return _context.Ogrenciler != null ? 
                          View(await _context.Ogrenciler.ToListAsync()) :
                          Problem("Entity set 'OnlineKursDbContext.Ogrenciler'  is null.");
        }

        // GET: Ogrenci/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Ogrenciler == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        // GET: Ogrenci/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ogrenci/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ad,Soyad,TcKimlikNo,Email,Telefon,ID,CreateDate,CreateBy,ModifiedDate,ModifiedBy,AutoId")] Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                ogrenci.ID = Guid.NewGuid();
                _context.Add(ogrenci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ogrenci);
        }

        // GET: Ogrenci/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Ogrenciler == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler.FindAsync(id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        // POST: Ogrenci/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Ad,Soyad,TcKimlikNo,Email,Telefon,ID,CreateDate,CreateBy,ModifiedDate,ModifiedBy,AutoId")] Ogrenci ogrenci)
        {
            if (id != ogrenci.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ogrenci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OgrenciExists(ogrenci.ID))
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
            return View(ogrenci);
        }

        // GET: Ogrenci/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Ogrenciler == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        // POST: Ogrenci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Ogrenciler == null)
            {
                return Problem("Entity set 'OnlineKursDbContext.Ogrenciler'  is null.");
            }
            var ogrenci = await _context.Ogrenciler.FindAsync(id);
            if (ogrenci != null)
            {
                _context.Ogrenciler.Remove(ogrenci);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OgrenciExists(Guid id)
        {
          return (_context.Ogrenciler?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
