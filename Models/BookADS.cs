using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid? UserId { get; set; }

        [DisplayName("Book Image")]
        public String ImagePath { get; set; }

        [NotMappedAttribute]
        public IFormFile ImageFile { get; set; }
    }
}
