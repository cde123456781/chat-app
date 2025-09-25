using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace chat_app.Models
{
    [PrimaryKey(nameof(User1Id), nameof(User2Id))]
    public class Friend
    {
        [ForeignKey("User")]
        [Column(Order = 0)]
        public int User1Id { get; set; }
        [ForeignKey("User")]
        [Column(Order = 1)]
        public int User2Id { get; set; }
        public bool Accepted { get; set; }



    }
}
