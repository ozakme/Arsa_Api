using System;

namespace ArsaProject.WebUI.Dtos.BookingDto
{
    public class CreateBookingDto
    {  
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
