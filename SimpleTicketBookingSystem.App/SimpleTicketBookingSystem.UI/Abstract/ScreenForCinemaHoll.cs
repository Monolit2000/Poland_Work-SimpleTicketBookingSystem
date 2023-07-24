using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.Data.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.UI.Abstract
{
    public abstract class ScreenForCinemaHoll : Screen
    {

        #region piblic field 

        public List<List<Seat>> twoDimensionalList = new List<List<Seat>>();
        public int currentField = 0;

        public int currentHorizontalFieald = 0;
        public int RowCount { get; set; }
        public int ColomCount { get; set; }

        #endregion



        //public override void ScreenRender(List<ScreenLineEntry> Lines, string ColorOfScreen = null)
        //{
        //    ShowCinemaHoll();
        //}




            public void ShowCinemaHoll()
        {
            var ListOfSeats = SeatsListAdd(RowCount, ColomCount);

            CinemaHallHandler(ListOfSeats);

            CinemaHallReander(twoDimensionalList);


            var Movie = new Movie(ListOfSeats);

            var Reservation = new Reservation(Movie);
        }




        public override void CursorHandler(List<ScreenLineEntry> ListOfLines, string ColorOfCursor)
        {
            for (int Row = 1; Row < twoDimensionalList.Count; Row++)
            {
                for (int Colom = 1; Colom < ColomCount; Colom++)
                {
                    if (Row != currentField && Colom != currentHorizontalFieald)
                    {
                        twoDimensionalList[Row][Colom].ForegroundColor = ScreenColorHandlerRender();
                    }

                    twoDimensionalList[Row][Colom].ForegroundColor = ColorOfCursor;
                }
            }
        }



        public void CursorHandlerForCinemaScreen(List<List<Seat>> twoDimensionalList, string ColorOfCursor)
        {
            for (int Row = 1; Row < twoDimensionalList.Count; Row++)
            {
                for (int Colom = 1; Colom < 15; Colom++)
                {
                    if (Row != currentField && Colom != currentHorizontalFieald)
                    {
                        twoDimensionalList[Row][Colom].ForegroundColor = ScreenColorHandlerRender();
                    }

                    twoDimensionalList[Row][Colom].ForegroundColor = ColorOfCursor;
                }
            }

        }



        #region CinemaHoll
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RowCount"></param>
        /// <param name="ColomCount"></param>
        public List<Seat> SeatsListAdd(int RowCount, int ColomCount)
        {
            List<Seat> Seats = new List<Seat>();

            for (int Row = 1; Row < RowCount; Row++)
            {
                for (int Colom = 1; Colom < ColomCount; Colom++)
                {
                    Seats.Add(new Seat { Row = Row, Number = Colom, IsAvailable = true, icon = "h" });
                }
            }

            return Seats;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="seats"></param>
        public void CinemaHallHandler(List<Seat> seats)
        {
            foreach (var seat in seats)
            {
                int rowIndex = seat.Row - 1;

                while (rowIndex >= twoDimensionalList.Count)
                {
                    twoDimensionalList.Add(new List<Seat>());
                }
                twoDimensionalList[rowIndex].Add(seat);
                // Console.WriteLine($" Row - {seat.Row}     Number - {seat.Number}");
            }
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="twoDimensionalList"></param>
        public void CinemaHallReander(List<List<Seat>> twoDimensionalList)
        {
            foreach (List<Seat> innerList in twoDimensionalList)
            {
                Console.WriteLine();
                Console.WriteLine();
                foreach (var seat in innerList)
                {
                    if (Enum.TryParse(seat.ForegroundColor, out ConsoleColor color))
                    {
                        Console.ForegroundColor = color;
                    }
                    Console.Write($"{seat.icon}  ");
                    Console.ResetColor();
                }

            }
        }

        #endregion



        public override void EnterScreen()
        {
            base.EnterScreen();
        }


    }
}
