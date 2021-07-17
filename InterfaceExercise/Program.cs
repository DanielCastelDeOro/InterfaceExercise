using System;

using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            
            var suv = new SUV();
            var trucks = new Truck();
            var cars = new Car();

            //SUV propertys
            var vehicleList = new List<IVehicle>();
            var companyList = new List<ICompany>();

            vehicleList.Add(suv);
            companyList.Add(suv);
            foreach (var Propertys in vehicleList)
            {
                Propertys.doors();
                Propertys.radio();
                Propertys.wheels();
                Propertys.wiperBlades();
                
            }
            foreach (var Propertys in companyList)
            {
                Propertys.logo();
                Propertys.lineUp();
            }
            Console.WriteLine("----------------------------");
            //Truck propertys
            var vehicleList2 = new List<IVehicle>();
            var companyList2 = new List<ICompany>();
            vehicleList2.Add(trucks);
            companyList2.Add(trucks);

            foreach (var Propertys in vehicleList2)
            {
                Propertys.doors();
                Propertys.radio();
                Propertys.wheels();
                Propertys.wiperBlades();
            }
            foreach (var Propertys in companyList2)
            {
                Propertys.lineUp();
                Propertys.logo();
            }
            Console.WriteLine("-----------------------------");
            //Car propertys
            var vehicleList3 = new List<IVehicle>();
            var companyList3 = new List<ICompany>();
            vehicleList3.Add(cars);
            companyList3.Add(cars);

            foreach (var Propertys in vehicleList3)
            {
                Propertys.doors();
                Propertys.radio();
                Propertys.wheels();
                Propertys.wiperBlades();
            }
            foreach (var Propertys in companyList3)
            {
                Propertys.lineUp();
                Propertys.logo();
            }
            Console.WriteLine("-----------------------------");
        }

    }
}
