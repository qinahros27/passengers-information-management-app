using System.Net;
namespace MvcTravel.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Passport? Passport { get; set; }

    }
}
