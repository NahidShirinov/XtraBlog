using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XtraBlog.Model;

namespace XtraBlog.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.HasData(
                new Tags
                
               {

                   Id = 1,
                   Name = "Siyaset"
                   


               },
               new Tags
               {

                   Id = 2,
                   Name = "Idman"


               },
               new Tags
               {

                   Id = 3,
                   Name = "Blog"


               },
               new Tags
               {

                   Id = 4,
                   Name = "Hava"


               }
               );
        
        }
    }
}
