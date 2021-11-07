using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Katzavia.Models
{
    public enum UserType
    {
        Client,
        Admin
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$",
                   ErrorMessage = "Entered username format not valid.")]
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
                   ErrorMessage = "Entered Email format not valid.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
           ErrorMessage = "Entered password format not valid,Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserType Type { get; set; } = UserType.Client;
        public UserInfo UserInfo { get; set; }

    }
}