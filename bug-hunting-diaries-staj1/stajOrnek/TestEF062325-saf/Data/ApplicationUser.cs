using Microsoft.AspNetCore.Identity;

namespace TestEF062325.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? AdditionalDescription { get; set; }
        public string? CustomerCode { get; set; }

    }

}
