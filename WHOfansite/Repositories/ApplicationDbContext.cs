using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace WHOfansite.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Story> Submissions { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Link> Links { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}
