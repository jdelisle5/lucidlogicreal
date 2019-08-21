using Microsoft.EntityFrameworkCore;

namespace LucidLogic.Models {
    public class BlogContext : DbContext {
        public BlogContext (DbContextOptions<BlogContext> options) : base (options) { }
        public DbSet<LucidLogic.Models.Blog> Blog { get; set; }
    }
}