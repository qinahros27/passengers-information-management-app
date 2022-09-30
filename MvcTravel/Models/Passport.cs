using static MvcTravel.Models.Passenger;
namespace MvcTravel.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime ValidDate { get; set; }
        public Passenger? Passenger { get; set; }

    }
}
