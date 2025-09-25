using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chat_app.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string? Username { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        public List<Group> Groups { get; } = [];


    }

}
