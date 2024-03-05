using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace XtraBlog.Model
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(150)]
        [MaxLength(150)]
        public string? Image { get; set; }
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        [MaxLength(150)]
        public string? Slug { get; set; }
        [MaybeNull]
        public string? Description { get; set; }
        [StringLength(100)]
        public string Created_By { get; set; }
        public DateTime? Date { get; set; }= DateTime.Now;
        public List<TagPost>? TagPost { get; set; }
        public List<Comments>? Comments { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }
        [NotMapped]
        public List<int>? TagIds { get; set; }
    }
}
