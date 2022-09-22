using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_MVC.Models;

public class AppUser
{
    public int? Pace { get; set; }
    public int? Mileage { get; set; }
    public Address Address { get; set; }
    public ICollection<Club> Clubs { get; set; }
    public ICollection<Race> Races { get; set; }
    
}