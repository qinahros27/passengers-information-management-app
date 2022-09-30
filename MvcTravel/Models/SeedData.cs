using Microsoft.EntityFrameworkCore;
using MvcTravel.Data;

namespace MvcTravel.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcTravelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcTravelContext>>()))
            {
                // Look for any passengers.
                if (context.Passenger.Any())
                {
                    return;   // DB has been seeded
                }

                var passenger = new List<Passenger>
                {
                    new Passenger{FirstName= "Jisoo",LastName= "Kim",DateOfBirth= DateTime.Parse("1995-1-03")},
                    new Passenger{FirstName= "Jennie", LastName= "Kim",DateOfBirth= DateTime.Parse("1996-1-16")},
                    new Passenger{FirstName= "Roseanne", LastName= "Park", DateOfBirth= DateTime.Parse("1997-2-11")},
                    new Passenger{FirstName= "Lisa", LastName= "Manoban",DateOfBirth= DateTime.Parse("1997-3-27")}
                };
                passenger.ForEach(s => context.Passenger.Add(s));
                context.SaveChanges();


                // Look for any passports.
                if (context.Passport.Any())
                {
                    return;   // DB has been seeded
                }

                var passport = new List<Passport>
                {
                    new Passport{PassengerId=1,PassportNumber="A0311995",ValidDate=DateTime.Parse("2026-8-08")},
                    new Passport{PassengerId=2,PassportNumber="B1611996",ValidDate=DateTime.Parse("2026-8-16")},
                    new Passport{PassengerId=3,PassportNumber="C1121997",ValidDate=DateTime.Parse("2028-9-8")},
                    new Passport{PassengerId=4,PassportNumber="D2731997",ValidDate=DateTime.Parse("2027-10-6")},
                };
                passport.ForEach(s => context.Passport.Add(s));
                context.SaveChanges();


            }
        }
    }
}

