using SecondHandBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHandBook.Services
{
    public class EFBookADSRepository : IBookADSRepository
    {
        BooksContext _context;
        public EFBookADSRepository(BooksContext context)
        {
            _context = context;
        }
        public IQueryable<BookADS> BookADs => _context.bookADs;
    }
}
