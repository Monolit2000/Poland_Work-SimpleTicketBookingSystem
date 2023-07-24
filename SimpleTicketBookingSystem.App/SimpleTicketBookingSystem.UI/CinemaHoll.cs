using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTicketBookingSystem.Data;
using SimpleTicketBookingSystem.UI.Abstract;

namespace SimpleTicketBookingSystem.UI
{
    public class CinemaHoll : ScreenForCinemaHoll
    {

        #region cotr
        public CinemaHoll(int rowCount, int colomCount) 
        {
            RowCount = rowCount;
            ColomCount = colomCount;
        }
        #endregion

    }
}
