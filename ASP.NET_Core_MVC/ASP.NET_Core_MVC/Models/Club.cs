using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASP.NET_Core_MVC.Data.Enum;

namespace ASP.NET_Core_MVC.Models;

public class Club
{
    [Key] public  int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    [ForeignKey("Address")] public int AddressId { get; set; }
    public Address Address { get; set; }
    public ClubCategory ClubCatrgory { get; set; }
    [ForeignKey("AppUser")] public string? AddUserId { get; set; }
    public AppUser? AppUser { get; set; }
}