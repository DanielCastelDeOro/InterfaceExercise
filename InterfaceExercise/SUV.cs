using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string cargoLiner { get; set; }
        public string badFuelEfficiency { get; set; }

        public void wheels()
        {
            Console.WriteLine($"All SUVs have wheels as of {DateTime.Now}");
        }
        public void doors()
        {
            Console.WriteLine($"All SUVs have doors as of {DateTime.Now}");
        }
        public void wiperBlades()
        {
            Console.WriteLine($"All SUVs have wiper blades as of {DateTime.Now}");
        }
        public void radio()
        {
            Console.WriteLine($"All SUVs have a radio as of {DateTime.Now}");
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
