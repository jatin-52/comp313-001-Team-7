using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondHandBook.Models;

namespace SecondHandBook
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookADSAPIController : ControllerBase
    {
        private readonly BooksContext _context;

        public BookADSAPIController(BooksContext context)
        {
            _context = context;
        }

        // GET: api/BookADSAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookADS>>> GetbookADs()
        {
            return await _context.bookADs.ToListAsync();
        }

        // GET: api/BookADSAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookADS>> GetBookADS(int id)
        {
            var bookADS = await _context.bookADs.FindAsync(id);

            if (bookADS == null)
            {
                return NotFound();
            }

            return bookADS;
        }

        // PUT: api/BookADSAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookADS(int id, BookADS bookADS)
        {
            if (id != bookADS.ID)
            {
                return BadRequest();
            }

            _context.Entry(bookADS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookADSExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookADSAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BookADS>> PostBookADS(BookADS bookADS)
        {
            var image = bookADS.ImagePath;
            if (image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", imageName);
                var imageString = Regex.Replace(image, @"^data:image\/[a-zA-Z]+;base64,", string.Empty);
                byte[] imageBytes = Convert.FromBase64String(imageString);
                System.IO.File.WriteAllBytes(SavePath, imageBytes);
                bookADS.ImagePath = imageName;
            }
            _context.bookADs.Add(bookADS);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBookADS", new { id = bookADS.ID }, bookADS);
        }

        // DELETE: api/BookADSAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BookADS>> DeleteBookADS(int id)
        {
            var bookADS = await _context.bookADs.FindAsync(id);
            if (bookADS == null)
            {
                return NotFound();
            }

            _context.bookADs.Remove(bookADS);
            await _context.SaveChangesAsync();

            return bookADS;
        }

        private bool BookADSExists(int id)
        {
            return _context.bookADs.Any(e => e.ID == id);
        }
    }
}
