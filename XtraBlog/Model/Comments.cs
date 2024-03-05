using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace XtraBlog.Model
{
    public class Comments
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }
        [MaybeNull]
        [StringLength(1000)]
        public string? Comment { get; set; }
        public bool? IsVerified { get; set; } = false;
        public DateTime? Craeateat { get; set; } = DateTime.Now;
        public int? PostID { get; set; }
        public Post? Post { get; set; }
    }
}
