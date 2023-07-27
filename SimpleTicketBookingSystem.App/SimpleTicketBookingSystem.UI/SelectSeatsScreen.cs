using SimpleTicketBookingSystem.Data.Screen;
using SimpleTicketBookingSystem.Enums;
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

        public override void AdditionalSection()
         {
            ShowCinemaHoll();
         }

        public override void Show() 
        {
            while (true)
            {

                var list = new List<ScreenLineEntry>
               {
                new ScreenLineEntry { Text = "0. Exit" },
                new ScreenLineEntry { Text = "1. Enter" },
                new ScreenLineEntry { Text = "2. Create a new settings" },
               };


                RowCount = 10;
                ColomCount = 10;

                ShowCinemaHoll();

               // ScreenRender(list);



                SwitchHandlerForCinemaHoll();
                return;
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
