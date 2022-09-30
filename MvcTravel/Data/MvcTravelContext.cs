using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTravel.Models;

namespace MvcTravel.Data
{
    public class MvcTravelContext : DbContext
    {
        public MvcTravelContext (DbContextOptions<MvcTravelContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTravel.Models.Passenger> Passenger { get; set; } = default!;

        public DbSet<MvcTravel.Models.Passport> Passport { get; set; }
    }
}
