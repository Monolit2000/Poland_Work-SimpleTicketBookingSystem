using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Screening
    {
        public Movie? Movie { get; set; }
        public DateTime Time { get; set; }

        public void DisplayAvailableSeats()
        {
           // ⦁	Метод DisplayAvailableSeats у класі Screening повинен переглядати список місць і відображати тільки ті, що доступні.

            foreach (var seat in Movie.Seats.SeatsList)
            {
                if (seat.IsAvailable == true)
                {
                    Console.WriteLine($" Row - {seat.Row}    Number - {seat.Number}");
                }
            }

        }

        public Screening(IMovie movie )
        {
            Movie = (Movie?)movie;
        }
    }
}
