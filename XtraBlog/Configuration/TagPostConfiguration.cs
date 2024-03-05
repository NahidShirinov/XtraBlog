using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XtraBlog.Model;

namespace XtraBlog.Configuration
{
    public class TagPostConfiguration : IEntityTypeConfiguration<TagPost>
    {
        public void Configure(EntityTypeBuilder<TagPost> builder)
        {
            builder.HasData(new TagPost

            {
                Id = 1,
                PostID = 1,
                TagsID = 1,
            },
                new TagPost
                {
                    Id = 2,
                    PostID = 2,
                    TagsID = 2,
                },
                new TagPost
                {
                    Id = 3,
                    PostID = 2,
                    TagsID = 4,
                },
                new TagPost
                {
                    Id = 4,
                    PostID = 2,
                    TagsID = 3,
                }



                );
            
        }
    }
}
