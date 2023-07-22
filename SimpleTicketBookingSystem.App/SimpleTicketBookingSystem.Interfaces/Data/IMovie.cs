using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Interfaces.Data
{
    public interface IMovie
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public int AgeRestriction { get; set; }
        public ISeats Seats { get; set; }

    }
}
