using SimpleTicketBookingSystem.Interfaces.Data;

namespace SimpleTicketBookingSystem.Data
{
    public class Movie : IMovie
    {
        public string? Title { get; set; }
        public int Duration { get; set; }
        public string? AgeRestriction { get; set; }
        public ISeats Seats { get; set; } 

        public Movie()
        {
            Seats = new Seats(); 
        }
    }
}