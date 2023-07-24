using SimpleTicketBookingSystem.Data.Screen;
using SimpleTicketBookingSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.UI
{
    public class SelectSeatsScreen : Screen
    {



       



        public override void Show()
        {
            while (true)
            {

                var CinemaHoll = new CinemaHoll(10, 10);

                CinemaHoll.ShowCinemaHoll();


                var list = new List<ScreenLineEntry>
               {
                new ScreenLineEntry { Text = "0. Exit" },
                new ScreenLineEntry { Text = "1. Enter" },
                new ScreenLineEntry { Text = "2. Create a new settings" },
               };

                ScreenRender(list);

                SwitchHandler();
            }
        }

        public override void EnterScreen()
        {
            try
            {
                MainScreenChoices choice = (MainScreenChoices)currentField;
                switch (choice)
                {
                    case MainScreenChoices.Exit:
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
