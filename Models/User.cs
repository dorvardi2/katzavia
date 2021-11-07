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
        [Required]
        [RegularExpression("^[a-zA-Z0-9._]*$", ErrorMessage = "Invalid name")]
        public string Username { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserType Type { get; set; } = UserType.Client;
        public UserInfo UserInfo { get; set; }

    }
}