using System.ComponentModel.DataAnnotations;

namespace XtraBlog.VM
{
    public class LoginVm
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
