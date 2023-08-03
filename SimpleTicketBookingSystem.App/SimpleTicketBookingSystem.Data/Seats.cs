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
       public List<ISeat> SeatsList { get; set; }


        public Seats()
        {
            SeatsList = SeatsListAdd(10, 10);
        }

        private List<ISeat> SeatsListAdd(int RowCount, int ColomCount)
        {
            List<ISeat> Seats = new List<ISeat>();

            for (int Row = 1; Row < RowCount; Row++)
            {
                for (int Colom = 1; Colom < ColomCount; Colom++)
                {
                    if (Row == RowCount - 1)
                    {
                        Seats.Add(new VIPSeat { Row = Row, Number = Colom, IsAvailable = true, icon = "H" });
                    }

                    else
                    {
                        Seats.Add(new Seat { Row = Row, Number = Colom, IsAvailable = true, icon = "h" });
                    }
                }
            }

            return Seats;
        }



    }
}
