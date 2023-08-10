using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Data.Screen;
using SimpleTicketBookingSystem.Enums;
using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.UI
{
    public class SelectSeatsScreen : Screen 
    {
        
        public IMovie _movie { get; set; }

        public List<ScreenLineEntry> list = new List<ScreenLineEntry>();

        public override void AdditionalSection()
         {

            // Console.WriteLine();

         }

        public override void Show(IMovie movie)
        {

            _movie = movie;

            while (true)
            {
                var list = new List<ScreenLineEntry>();
               //{
               // new ScreenLineEntry { Text = "0. Exit" },
               // new ScreenLineEntry { Text = "1. Enter" },
               // new ScreenLineEntry { Text = "2. Create a new settings" },
               //};

                foreach (var seat in movie.Seats.SeatsList)
                {
                    list.Add(new ScreenLineEntry { Text = $"Row: {seat.Row} --- Number: {seat.Number} --- IsAvailable: {seat.IsAvailable}"});
                }


              


         

                ScreenRender(list);

            

                SwitchHandler();

                return;

            }
        }

        public override void EnterScreen()
        {
            try
            {


                var resrvatuion = new Reservation(_movie, _movie.Seats.SeatsList[currentField]);

                switch (currentField)
                {

                }


                //SelectSeatsScreenChoices choice = (SelectSeatsScreenChoices)currentField;
                //switch (choice)
                //{
                //    case SelectSeatsScreenChoices.Exit:
                //        break;

                //    case SelectSeatsScreenChoices.Enter:
                //        break;

                //   case SelectSeatsScreenChoices.Exit:
                //     break;

                //}
            }
             
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }


    }
}
