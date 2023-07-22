using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Reservation
    {

        //⦁	Створіть клас Reservation з властивостями: Screening, Seat, CustomerName.

        public Screening Screening { get; set; }
        public Seat? Seat { get; set; }
        public int CustomerName { get; set; }

        public Reservation(IMovie movie)
        {
            Screening = new Screening(movie);
        }


        public Reservation(ISeat seat)
        {
            Seat = (Seat?)seat;
            Seat.IsAvailable = false;
        }
    }
}
