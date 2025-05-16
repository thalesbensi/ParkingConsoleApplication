using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApplication.Models
{
    public class Parking
    {

        public decimal TotalToPay(decimal initialPrice, decimal pricePerHour, decimal parkedTime)
        {
            return (pricePerHour * parkedTime) + initialPrice;
        }
    }
}