using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Interfaces;
using SimpleTicketBookingSystem.Interfaces.Data;

namespace SimpleTicketBookingSystem.UI
{
    public class MainScreen : ScreenForCinemaHoll
    {

       // List<List<Seat>> twoDimensionalList = new List<List<Seat>>();

        public int RowCount = 7;

        public int ColomCount = 11;


        public override void Show()
        {

            var ListOfSeats = SeatsListAdd(RowCount, ColomCount);

            CinemaHallHandler(ListOfSeats);

            CinemaHallReander(twoDimensionalList);


            var Movie = new Movie(ListOfSeats);

            var Reservation = new Reservation(new Movie(SeatsListAdd(10, 15)));

            


                //Reservation.Screening.DisplayAvailableSeats();




                Console.WriteLine();
               
               // ScreenRender(list);

               // SwitchHandler();

            //}
        }

        //public override void EnterScreen()
        //{
        //    try
        //    {
        //        MainScreenChoices choice = (MainScreenChoices)currentField;
        //        switch (choice)
        //        {
        //            case MainScreenChoices.Animals:
        //                _animalsScreen.Show();
        //                break;

        //            case MainScreenChoices.Settings:
        //                _creatSettingsScreen.Show();
        //                break;

        //            case MainScreenChoices.Exit:
        //                Console.WriteLine("Goodbye.");
        //                return;
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Invalid choice. Try again.");
        //    }
        //}
    }
}