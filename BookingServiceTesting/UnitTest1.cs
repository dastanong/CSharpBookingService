using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingService;
using System;

namespace BookingServiceTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListHotelTest()
        {
            using (var db = new BookingContext())
            {
                foreach(var hotel in db.Hotels)
                {
                    Console.WriteLine(hotel.Id + ". " + hotel.Name + " - " + hotel.Address);
                }
            }
        }

        [TestMethod]
        public void ListFlightTest()
        {
            using (var db = new BookingContext())
            {
                foreach (var flight in db.Flights)
                {
                    Console.WriteLine(flight.Id + ". " + flight.Airline + " - " + flight.Return_flight);
                }
            }
        }

        [TestMethod]
        public void BookingTest()
        {
            using (var db = new BookingContext())
            {
                var myHotel = "Flash Hotel";
                var myAirline = "AirAsia";

                var hotelId = 0;
                var hotelName = "";
                var flightId = 0;
                var flightName = "";
                var returnFlight = "";

                foreach (var hotel in db.Hotels)
                {

                    if (hotel.Name.Equals(myHotel))
                    {
                        hotelId = hotel.Id;
                        hotelName = hotel.Name;
                    }
                }

                foreach (var flight in db.Flights)
                {
                    
                    if (flight.Airline.Equals(myAirline))
                    {
                        flightId = flight.Id;
                        flightName = flight.Airline;
                        returnFlight = flight.Return_flight.ToString();
                    }
                }

                if(flightId != 0 && hotelId != 0)
                {
                    db.Bookings.Add(new Booking() { Hotel_id = hotelId, Flight_id = flightId });
                    db.SaveChanges();

                    foreach(var booking in db.Bookings)
                    {
                        Console.WriteLine("Booking Id : " + booking.Id);
                        Console.WriteLine("Hotel : " + hotelName);
                        Console.WriteLine("Flight : " + flightName);
                        Console.WriteLine("Return Flight : " + returnFlight);
                    }
                } else
                {
                    Console.WriteLine("Hotel or Flight name incorrect!");
                }
                
            }
        }
    }
}
