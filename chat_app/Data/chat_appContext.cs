using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using chat_app.Models;

namespace chat_app.Data
{
    public class chat_appContext : DbContext
    {
        public chat_appContext (DbContextOptions<chat_appContext> options)
            : base(options)
        {
        }

        public DbSet<chat_app.Models.User> User { get; set; } = default!;
        public DbSet<chat_app.Models.Group> Group { get; set; } = default!;
        public DbSet<chat_app.Models.GroupMessage> GroupMessage { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



        }
        public DbSet<chat_app.Models.Friend> Friend { get; set; } = default!;
    }
}
