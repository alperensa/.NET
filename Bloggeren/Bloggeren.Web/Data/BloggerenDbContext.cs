using Bloggeren.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggeren.Web.Data
{
    public class BloggerenDbContext : DbContext
    {
        public BloggerenDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts  { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
