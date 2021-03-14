using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecondHandBook.Models;

namespace SecondHandBook
{
    public class UserProfileController : Controller
    {
        private readonly BooksContext _context;

        public UserProfileController(BooksContext context)
        {
            _context = context;
        }

        // GET: UserProfile
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserProfileModel.ToListAsync());
        }

        // GET: UserProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfileModel = await _context.UserProfileModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userProfileModel == null)
            {
                return NotFound();
            }

            return View(userProfileModel);
        }

        // GET: UserProfile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfile/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,DateOfBirth,Mobile,Address,City,Province,Country,PostalCode")] UserProfileModel userProfileModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userProfileModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userProfileModel);
        }

        // GET: UserProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfileModel = await _context.UserProfileModel.FindAsync(id);
            if (userProfileModel == null)
            {
                return NotFound();
            }
            return View(userProfileModel);
        }

        // POST: UserProfile/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,DateOfBirth,Mobile,Address,City,Province,Country,PostalCode")] UserProfileModel userProfileModel)
        {
            if (id != userProfileModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userProfileModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileModelExists(userProfileModel.ID))
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
            return View(userProfileModel);
        }

        // GET: UserProfile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfileModel = await _context.UserProfileModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userProfileModel == null)
            {
                return NotFound();
            }

            return View(userProfileModel);
        }

        // POST: UserProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userProfileModel = await _context.UserProfileModel.FindAsync(id);
            _context.UserProfileModel.Remove(userProfileModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserProfileModelExists(int id)
        {
            return _context.UserProfileModel.Any(e => e.ID == id);
        }
    }
}
