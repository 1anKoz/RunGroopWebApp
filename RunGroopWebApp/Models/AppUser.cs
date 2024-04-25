using Microsoft.AspNetCore.Identity;

namespace RunGroopWebApp.Models
{
    public class AppUser
    {
        public int? Pace {  get; set; }
        public int Mileage { get; set; }
        public Adress? Adress { get; set; }

    }
}
