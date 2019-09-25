using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookingService
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Hotel")]
        public int Hotel_id { get; set; }
        public Hotel Hotel { get; set; }

        [ForeignKey("Flight")]
        public int Flight_id { get; set; }
        public Flight Flight { get; set; }
    }
}
