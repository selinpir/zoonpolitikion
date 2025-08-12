using Microsoft.AspNetCore.Identity;

namespace TestEF062325.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        { }
        public ApplicationRole(string role) {
            this.Name = role;
        }
    }
}
