using System;

namespace LatihanTaxi{
    class TaxiClass{
        public string DriverName{get; set;}
        public string onDuty{ get; set; }
        public int numPassenger{get; set;}

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver: {0}", DriverName );
            Console.WriteLine("Sedang Bekerja {0}", onDuty);
            Console.WriteLine("Jumlah Penumpang: {0}", numPassenger);
        }

        public void pickUpPassengers()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void dropOffPassengers()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }

    }
}