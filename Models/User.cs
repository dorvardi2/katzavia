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
        public string Username { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserType Type { get; set; } = UserType.Client;
        public UserInfo UserInfo { get; set; }

    }
}