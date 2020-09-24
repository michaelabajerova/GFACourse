using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations
{
    public class Reservation : IReserve
    {
        public string ReservationCode {get; set;}
        public string DOW { get; set; }
        public void Resevations()
        {
            ReservationCode = GetCodeBooking();
            DOW = GetDowBooking();

        }

        public string GetCodeBooking()
        {
            throw new NotImplementedException();
        }

        public string GetDowBooking()
        {
            throw new NotFiniteNumberException();
        }

        
    }
}
