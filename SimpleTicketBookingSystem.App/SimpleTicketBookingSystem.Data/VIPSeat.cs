using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class VIPSeat :  ISeat
    {
        public string icon { get; set; } = "H";
        public int Row { get; set; }
        public int Number { get; set; }
        public bool IsAvailable { get; set; }
        public string ForegroundColor { get; set; }
    }
}
