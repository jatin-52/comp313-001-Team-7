using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHandBook.Models
{
    public class BookADS
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        public String College { get; set; }
        [Required]
        public int Rate { get; set; }

        public String ImagePath { get; set; }
        // public IFormFile ImageFile { get; set; }
    }
}
