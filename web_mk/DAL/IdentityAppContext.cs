using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web_mk.Models.Users;

namespace web_mk.DAL
{
    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, int>// <- tu na koncu kursor alt enter i mamy konstruktor
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {
        }
    }
}
