using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XtraBlog.Model;

namespace XtraBlog.Configuration
{
    public class CommentsConfiguration : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasData(
                new Comments
            {
                    Id = 1,
                    Name = "Nahid",
                    Comment="Heri seni",
                    PostID = 1,

            },
                 new Comments
                 {
                     Id = 2,
                     Name = "Revan",
                     Comment = "reyiz",
                     PostID = 1,

                 },
                  new Comments
                  {
                      Id = 3,
                      Name = "Revan",
                      Comment = "Pak",
                      PostID = 2,

                  }
                );
        }
    }
}
