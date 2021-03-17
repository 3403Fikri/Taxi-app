using System;

namespace LatihanTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiClass taxi = new TaxiClass();

            taxi.DriverName = "Fikri";
            taxi.onDuty = "Ya";
            taxi.numPassenger = 5;

            taxi.TaxiInfo();
            taxi.pickUpPassengers();
            taxi.dropOffPassengers();
            
        }
    }
}
