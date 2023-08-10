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
        public Screening Screening { get; set; }
        public Seat? Seat { get; set; }
        public int CustomerName { get; set; }

        public Reservation(IMovie movie, ISeat seat)
        {
            Screening = new Screening(movie);


            // movie.Seats.SeatsList.FirstOrDefault(s => s == seat).IsAvailable = false;

            Seat = (Seat?)seat;
            Seat.IsAvailable = false;
        }


      
    }
}
