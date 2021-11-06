using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Katzavia.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Insert Event Type")]
        public string EventType { get; set; }

        [Required(ErrorMessage = "Enter your date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                           ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }


        public string Desc { get; set; }
    }
}