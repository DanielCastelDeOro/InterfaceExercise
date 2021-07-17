using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string rearBed { get; set; }
        public string FWD { get; set; }

        public void wheels()
        {
            Console.WriteLine($"All Trucks have wheels as of {DateTime.Now}");
        }
        public void doors()
        {
            Console.WriteLine($"All Trucks have doors as of {DateTime.Now}");
        }
        public void wiperBlades()
        {
            Console.WriteLine($"All Trucks have wiper blades as of {DateTime.Now}");
        }
        public void radio()
        {
            Console.WriteLine($"All Trucks have a radio as of {DateTime.Now}");
        }
        public void logo()
        {
            Console.WriteLine($"All companys have a company logo as of {DateTime.Now}");
        }
        public void lineUp()
        {
            Console.WriteLine($"All vehicle companys have a vehicle line up as of {DateTime.Now}");
        }
    }
}
