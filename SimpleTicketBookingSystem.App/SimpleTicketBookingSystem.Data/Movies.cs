using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Movies : IMovies
    {
       public List<IMovie> MoviesList { get; set; } = new List<IMovie>();
    }
}
