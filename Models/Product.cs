using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//new include
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Katzavia.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Insert Image.")]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Enter your Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Enter Description")]
        [Display(Name = "Description")]
        public string Desc { get; set; }

        public List<Tags> myTags { get; set; }
        public Category Category { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Display(Name = "Tags")]
        
        public User User { get; set; }
    }
}
