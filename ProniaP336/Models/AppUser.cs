using Microsoft.AspNetCore.Identity;

namespace ProniaP336.Models;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public bool IsActive { get; set; }
}
