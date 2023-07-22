using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Seats : ISeats
    {
       public List<ISeat> SeatsList { get; set; } = new List<ISeat>();
    }
}
