using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingService
{
    public class BookingContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=W10JLB1HH2;" +
                "Database=bookingservice_db;" +
                "User Id=dastanong94;" +
                "Password = Octd48688620;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
