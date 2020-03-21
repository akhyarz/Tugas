using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi
            taxi taxi = new taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Ahyar";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}