using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecondHandBook.Models;

namespace SecondHandBook.Controllers
{
    public class BookADSController : Controller
    {
        private readonly BooksContext _context;

        public BookADSController(BooksContext context)
        {
            _context = context;
        }

        // GET: BookADS
        public async Task<IActionResult> Index()
        {
            return View(await _context.bookADs.ToListAsync());
        }

        // GET: BookADS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookADS = await _context.bookADs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bookADS == null)
            {
                return NotFound();
            }

            return View(bookADS);
        }

        // GET: BookADS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookADS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookADS bookADS)
        {
            var image = bookADS.ImageFile;

            if (image != null) {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

                //Get url To Save
                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", ImageName);

                using (var stream = new FileStream(SavePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                bookADS.ImagePath = ImageName;
            }
            bookADS.ImageFile = null;

            if (ModelState.IsValid)
            {
                _context.Add(bookADS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookADS);
        }

        // GET: BookADS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookADS = await _context.bookADs.FindAsync(id);
            if (bookADS == null)
            {
                return NotFound();
            }
            return View(bookADS);
        }

        // POST: BookADS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Description,Author,ISBN,College,Rate,ImagePath")] BookADS bookADS)
        {
            if (id != bookADS.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookADS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookADSExists(bookADS.ID))
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
            return View(bookADS);
        }

        // GET: BookADS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookADS = await _context.bookADs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bookADS == null)
            {
                return NotFound();
            }

            return View(bookADS);
        }

        // POST: BookADS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookADS = await _context.bookADs.FindAsync(id);
            _context.bookADs.Remove(bookADS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookADSExists(int id)
        {
            return _context.bookADs.Any(e => e.ID == id);
        }
    }
}
