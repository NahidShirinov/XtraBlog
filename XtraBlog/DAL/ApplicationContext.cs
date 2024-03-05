
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XtraBlog.Configuration;
using XtraBlog.Model;

namespace XtraBlog.DAL
{
    public class ApplicationContext:IdentityDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) {}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tags>Tag { get; set; }
        public DbSet<TagPost> TagPosts { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AppUser> Appusers { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.ApplyConfiguration(new PostConfiguration());
        //    modelBuilder.ApplyConfiguration(new TagPostConfiguration());
        //    modelBuilder.ApplyConfiguration(new TagConfiguration());
        //    modelBuilder.ApplyConfiguration(new CommentsConfiguration());

        //}



    }
}
