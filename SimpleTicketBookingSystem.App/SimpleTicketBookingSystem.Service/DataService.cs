using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Interfaces;
using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Service
{
    public class DataService : IDataService
    {
        public IMovies Movies { get; set ; }

        public DataService()
        {
            Movies = new Movies();
        }

        public void AddList()
        {

        }
    }
}
