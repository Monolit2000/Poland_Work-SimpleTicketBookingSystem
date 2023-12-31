﻿using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Seat : ISeat
    {
        public int Row { get; set; }
        public int Number { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? icon { get; set; } 
        public string? ForegroundColor { get; set; }

    }
}
