using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chat_app.Models
{
    public class GroupMessage
    {

        public int Id { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 1)]
        public string? Message { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; init; }
    }
}
