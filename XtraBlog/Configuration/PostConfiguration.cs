using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XtraBlog.Model;

namespace XtraBlog.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
           builder.HasData(new Post
           {
               Id = 1,
               Title = "You can also have an image",
               Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
               Slug = Guid.NewGuid().ToString(),
               Image = "img-01.jpg",
               Created_By = "Nahid Shirinov",
               Date= DateTime.Now,
              

           },


                  new Post
                  {
                      Id = 2,
                      Title = "He qaqa, ele mi olufff",
                      Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                      Date = DateTime.Now.AddDays(10),
                      Created_By = "Nahid Sirinov",
                      Slug = Guid.NewGuid().ToString(),
                      Image = "img-02.jpg",


                  }
                  );
        }
    }
}
