using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Data.Screen;
using SimpleTicketBookingSystem.Enums;
using SimpleTicketBookingSystem.Interfaces.Data;
using SimpleTicketBookingSystem.UI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.UI
{
    public class SelectSeatsScreen : ScreenForCinemaHoll
    {

        public List<ScreenLineEntry> list = new List<ScreenLineEntry>();

        public override void AdditionalSection()
         {

           // Console.WriteLine();

            ShowCinemaHoll();
         }

        public override void AdditionalSectionForCinemaHoll()
        {
          // ScreenRender(list);
        }

        public override void Show(IMovie movie)
        {
            while (true)
            {
                twoDimensionalList.Clear();

                var list = new List<ScreenLineEntry>
               {
                new ScreenLineEntry{Text = $"{movie.Title}" },
                new ScreenLineEntry { Text = "0. Exit" },
                new ScreenLineEntry { Text = "1. Enter" },
                new ScreenLineEntry { Text = "2. Create a new settings" },
               };


                 RowCount = 10;
                 ColomCount = 10;

                // ShowCinemaHoll();


                if (twoDimensionalList.Count == 0)
                {
                    CinemaHallHandler(movie.Seats.SeatsList);
                }
 
                ScreenRender(list);

                SwitchHandlerForCinemaHoll();

                SwitchHandler();

                Switch = false;

                return;
            }
        }

        public override void EnterScreen()
        {
            try
            {
                SelectSeatsScreenChoices choice = (SelectSeatsScreenChoices)currentField;
                switch (choice)
                {
                    case SelectSeatsScreenChoices.Exit:
                        break;

                    case SelectSeatsScreenChoices.Enter:
                        break;

                }
            }
             
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }


    }
}
