using System;

namespace BookingService
{
    public class Program
    {
        public static void addHotels()
        {
            using (var db = new BookingContext())
            {
                db.Hotels.Add(new Hotel() { Name = "Flash Hotel", Address = "18, Butterworth Penang" });
                db.Hotels.Add(new Hotel() { Name = "Pyramid Hotel", Address = "2056B, Kuala Lumpur" });
                db.Hotels.Add(new Hotel() { Name = "ABC Hotel", Address = "123, Langkawi" });
                db.Hotels.Add(new Hotel() { Name = "Dell Hotel", Address = "345, Zone2, Bayan Lepas" });

                db.SaveChanges();

                foreach(var hotel in db.Hotels)
                {
                    Console.WriteLine(hotel.Id + ". " + hotel.Name);
                }
            }
        }

        public static void addFlights()
        {
            using (var db = new BookingContext())
            {
                db.Flights.Add(new Flight() { Airline = "AirAsia", Return_flight = true });
                db.Flights.Add(new Flight() { Airline = "Jetstar", Return_flight = true });
                db.Flights.Add(new Flight() { Airline = "Scoot", Return_flight = false });
                db.Flights.Add(new Flight() { Airline = "Malaysia Airline", Return_flight = false });

                db.SaveChanges();

                foreach(var flight in db.Flights)
                {
                    Console.WriteLine(flight.Id + ". " + flight.Airline);
                }
            }
        }

        static void Main(string[] args)
        {
            //Add Hotels
            addHotels();

            //Add Flights
            addFlights();
        }
    }
}
