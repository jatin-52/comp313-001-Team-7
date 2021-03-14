using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace SecondHandBook.Models
{
    public class UserProfileModel
    {
        [Key]
        public int ID { get; set; }
        [NotMappedAttribute]
        public IFormFile UserImage { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public long Mobile { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String Province { get; set; }

        [Required]
        public String Country { get; set;}

        [Required]
        public String PostalCode { get; set; }

                
    }
}
