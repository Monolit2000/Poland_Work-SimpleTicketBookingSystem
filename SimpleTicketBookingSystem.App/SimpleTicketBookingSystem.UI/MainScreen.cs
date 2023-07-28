using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Data.Screen;
using SimpleTicketBookingSystem.Enums;
using SimpleTicketBookingSystem.Interfaces;
using SimpleTicketBookingSystem.Interfaces.Data;
using SimpleTicketBookingSystem.UI.Abstract;

namespace SimpleTicketBookingSystem.UI
{
    public class MainScreen : Screen
    {

        public SelectSeatsScreen _selectSeatsScreen;

        public MainScreen(SelectSeatsScreen selectSeatsScreen)
        {
            _selectSeatsScreen = selectSeatsScreen; 
        }

        public override void Show()
        {
            while (true)
            {

                var list = new List<ScreenLineEntry>
                {
                    new ScreenLineEntry { Text = "0. Exit" },
                    new ScreenLineEntry { Text = "1. Select seats" },
                    new ScreenLineEntry { Text = "2. Create a new settings" },
                };
              
                ScreenRender(list);



                SwitchHandler();

            }
        }

        //public override void AdditionalSection()
        //{
        //    var CinemaHoll = new CinemaHoll(10, 10);

        //    CinemaHoll.ShowCinemaHoll();
        //}

        public override void EnterScreen()
        {
            try
            {
                MainScreenChoices choice = (MainScreenChoices)currentField;
                switch (choice)
                {
                    case MainScreenChoices.addSiets:
                         _selectSeatsScreen.Show();
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