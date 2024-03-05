using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace XtraBlog.Model
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Subject { get; set; }
        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }
        [MaybeNull]
        [StringLength(500)]
        public string? Text { get; set; }
        public bool? IsRead { get; set; } = false;
    }
}
