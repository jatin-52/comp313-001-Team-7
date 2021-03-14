using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHandBook.Models;

namespace SecondHandBook.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options) { }

        public DbSet<BookADS> bookADs { get; set; }

        public DbSet<SecondHandBook.Models.UserProfileModel> UserProfileModel { get; set; }
    }
}
