using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHandBook.Models
{
    public class ChatModel
    {
        [Key]
        public int ID { get; set; }

        // the user who send the message
        [Required]
        public String toUserId { get; set; }

        // the user who send the message
        [Required]
        public String fromUserId { get; set; }

        [Required]
        public String message { get; set; }

        
    }
}
