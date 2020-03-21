using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class taxi
    {
        public string DriverName { get; set; }

        public bool OnDuty { get; set; }

        public int NumPassenger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }


        public void PickUpPassenger()

        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }


        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}