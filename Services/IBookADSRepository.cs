using SecondHandBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHandBook.Services
{
    public interface IBookADSRepository
    {
        IQueryable<BookADS> BookADs { get; }
    }
}
