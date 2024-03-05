using Microsoft.AspNetCore.Identity;

namespace XtraBlog.Model
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
