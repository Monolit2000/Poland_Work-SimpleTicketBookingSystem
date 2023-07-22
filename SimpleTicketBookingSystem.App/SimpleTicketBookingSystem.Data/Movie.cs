using SimpleTicketBookingSystem.Interfaces.Data;

namespace SimpleTicketBookingSystem.Data
{
    public class Movie : IMovie
    {
        public string? Title { get; set; }
        public string? Duration { get; set; }
        public int AgeRestriction { get; set; }
        public ISeats Seats { get; set; } = new Seats();

        public Movie(List<Seat> seats)
        {
            Seats.SeatsList.AddRange(seats);
        }
    }
}