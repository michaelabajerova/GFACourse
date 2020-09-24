using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations
{
    interface IReserve
    {
        string GetDowBooking();
        string GetCodeBooking();
    }
}
