using Microsoft.EntityFrameworkCore;
using Multishop.Comment.Entities;

namespace Multishop.Comment.Context
{
    public class CommentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442;initial catalog=MultishopCommentDb;User=sa;Password=123456aA*;TrustServerCertificate=true");
        }

        public DbSet<UserComment> UserComments { get; set; }
    }
}
    