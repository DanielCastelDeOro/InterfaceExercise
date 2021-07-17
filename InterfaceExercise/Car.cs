using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string trunck { get; set; }
        public string smallInSize { get; set; }

        public void wheels()
        {
            Console.WriteLine($"All Cars have wheels as of {DateTime.Now}");
        }
        public void doors()
        {
            Console.WriteLine($"All Cars have doors as of {DateTime.Now}");
        }
        public void wiperBlades()
        {
            Console.WriteLine($"All Cars have wiper blades as of {DateTime.Now}");
        }
        public void radio()
        {
            Console.WriteLine($"All Cars have a radio as of {DateTime.Now}");
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
