using Microsoft.AspNet.Identity.EntityFramework;

namespace B2TomaszZawadzkiZadDom6.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}