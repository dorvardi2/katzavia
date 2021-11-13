using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Katzavia.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string fullname { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public string Commant { get; set; }

    }
}
