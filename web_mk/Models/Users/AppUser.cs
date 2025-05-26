using Microsoft.AspNetCore.Identity;

namespace web_mk.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
