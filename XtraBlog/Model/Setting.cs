using System.ComponentModel.DataAnnotations;

namespace XtraBlog.Model
{
    public class Setting
    {
        public int Id { get; set; }
        [Required, StringLength(100), MaxLength(100), EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20), MaxLength(20)]
        public string Phone { get; set; }
        [StringLength(100), MaxLength(100)]
        public string? Facebook { get; set; } = string.Empty;
        [StringLength(100), MaxLength(100)]
        public string? Instagram { get; set; } = string.Empty;
        [StringLength(100), MaxLength(100)] 
        public string? Linkedin { get; set; } = string.Empty;
        [StringLength(100), MaxLength(100)]
        public string? Twitter { get; set; } = string.Empty;
    }
}
