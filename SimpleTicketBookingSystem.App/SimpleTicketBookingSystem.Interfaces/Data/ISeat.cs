﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Interfaces.Data
{
    public interface ISeat
    {
        string icon { get; set; }
        int Row { get; set; }
        int Number { get; set; }
        bool IsAvailable { get; set; }
        string ForegroundColor { get; set; }
    }
}
