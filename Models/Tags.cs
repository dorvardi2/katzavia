using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Katzavia.Models
{
    public class Tags
    {
        public int Id { get; set; }
        [Display(Name = "Tag Name")]
        public string Name { get; set; }
        [Display(Name = "Products")]
        public List<Product> myProducts { get; set; }
    }
}
