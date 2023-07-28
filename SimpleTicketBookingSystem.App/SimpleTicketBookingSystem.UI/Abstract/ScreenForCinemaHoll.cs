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

        public int currentVerticalFieald = 0;

        public int currentHorizontalFieald = 0;
        public int RowCount { get; set; }
        public int ColomCount { get; set; }

        public bool Switch { get; set; } = false;

        #endregion


        public virtual void AdditionalSectionForCinemaHoll()
        {

        }


        #region Main fanction
        public void ShowCinemaHoll()
        {

            Console.Clear();

            if (twoDimensionalList.Count == 0)
            {
                var ListOfSeats = SeatsListAdd(RowCount, ColomCount);

                CinemaHallHandler(ListOfSeats);
            }

            CinemaHallReander(twoDimensionalList);

            AdditionalSectionForCinemaHoll();

           // var Movie = new Movie(ListOfSeats);

            // var Reservation = new Reservation(Movie);
        }

        #endregion


        #region Cursor Hander 
        public void CursorHandlerForCinemaScreen(List<List<Seat>> twoDimensionalList, string ColorOfCursor)
        {
         
            
            for (int Row = 0; Row < twoDimensionalList.Count; Row++)
            {
                for (int Colom = 0; Colom < ColomCount - 1; Colom++)
                {
                    if (Row != currentField || Colom != currentHorizontalFieald)
                    {
                        twoDimensionalList[Row][Colom].ForegroundColor = null ;
                    }
                }
            }
            twoDimensionalList[currentVerticalFieald][currentHorizontalFieald].ForegroundColor = ColorOfCursor;

        }

        #endregion


        #region CinemaHoll
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="seats"></param>
        public void CinemaHallHandler(List<Seat> seats)
        {
            foreach (var seat in seats)
            {
                int rowIndex = seat.Row - 1 ;

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

            CursorHandlerForCinemaScreen(twoDimensionalList, "Red");

            foreach (List<Seat> innerList in twoDimensionalList)
            {
                Console.WriteLine();
                Console.WriteLine();

                foreach (var seat in innerList)
                {
                    if (seat.IsAvailable == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Cyan;     
                        
                    }

                    if (Enum.TryParse(seat.ForegroundColor, out ConsoleColor color))
                    {

                        Console.BackgroundColor = color;

                    }
                    Console.Write($"{seat.icon}"); Console.Write(" ");
                    Console.ResetColor();
                }
                //Console.ResetColor();
            }
        }

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

        #endregion




       



        #region Navigation 

 
        public void SwitchHandlerForCinemaHoll()
        {

            while (true)
            {
                //ShowCinemaHoll();
                ScreenRender(screenLines);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp();
                        break;

                    case ConsoleKey.DownArrow:
                        MoveDown();

                        if (Switch == true)
                        {
                            return;
                        }

                        break;

                    case ConsoleKey.LeftArrow:
                        MoveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        MoveRight();
                        break;


                    case ConsoleKey.Enter:
                        //HistoryHandler();
                        EnterScreenForCinemaHoll();
                        //twoDimensionalList.Clear();
                        break;
                }

                Console.WriteLine(twoDimensionalList[currentVerticalFieald][currentHorizontalFieald].IsAvailable);

            }

        }


        #region Move
        public void MoveUp()
        {
            if (currentVerticalFieald > 0)
            {
                currentVerticalFieald--;

                //ShowCinemaHoll();

                Console.WriteLine($"You have moved to the screen: VerticalFieald = {currentVerticalFieald} -- HorizontalFieald = {currentHorizontalFieald}");
            }
        }

        public void MoveDown()
        {
            if (currentVerticalFieald == twoDimensionalList.Count - 1)
            {
                Switch = true;
            }

            if (currentVerticalFieald < twoDimensionalList.Count - 1)
            {
                currentVerticalFieald++;

                
                //ShowCinemaHoll();

                Console.WriteLine($"You have moved to the screen: VerticalFieald = {currentVerticalFieald} -- HorizontalFieald = {currentHorizontalFieald}");
            }
        }

        public void MoveLeft()
        {
            if (currentHorizontalFieald > 0)
            {
                currentHorizontalFieald--;

               // ShowCinemaHoll();

                Console.WriteLine($"You have moved to the screen: VerticalFieald = {currentVerticalFieald} -- HorizontalFieald = {currentHorizontalFieald}");
            }

           
        }
        public void MoveRight()
        {
            if (currentHorizontalFieald < ColomCount - 2)
            {
                currentHorizontalFieald++;

                //ShowCinemaHoll();

                Console.WriteLine($"You have moved to the screen: VerticalFieald = {currentVerticalFieald} -- HorizontalFieald = {currentHorizontalFieald}");
            }
        }

        #endregion

        #region Enter 
        public void EnterScreenForCinemaHoll()
        {
            try
            {

                if (twoDimensionalList[currentVerticalFieald][currentHorizontalFieald].IsAvailable == true)
                {
                    twoDimensionalList[currentVerticalFieald][currentHorizontalFieald].IsAvailable = false;
                }
                else
                {
                    twoDimensionalList[currentVerticalFieald][currentHorizontalFieald].IsAvailable = true;
                }

                ShowCinemaHoll();

                Console.WriteLine($"You have moved to the screen: VerticalFieald = {currentVerticalFieald} -- HorizontalFieald = {currentHorizontalFieald} :::: ENTER");
            }
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
        #endregion





        public override void EnterScreen()
        {
            base.EnterScreen();
        }




       

        #endregion
    }
}
