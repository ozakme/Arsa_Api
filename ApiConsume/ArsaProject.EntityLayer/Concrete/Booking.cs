﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsaProject.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string SaleOrRent { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
