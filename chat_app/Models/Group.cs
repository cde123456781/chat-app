using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chat_app.Models
{
    public class Group
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string? Name { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        [ForeignKey(nameof(User))]
        public int? OwnerId { get; init; }

        
        public List<User> Users { get; } = [];


    }
}
