using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookingService
{
    [Table("flights")]
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("airline")]
        public string Airline { get; set; }

        [Column("return_flight")]
        public bool Return_flight { get; set; }

    }
}
