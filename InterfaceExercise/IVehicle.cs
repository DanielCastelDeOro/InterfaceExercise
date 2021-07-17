using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //public string wheels { get; set; }
        //public string doors { get; set; }
        //public string wiperBlades { get; set; }
        //public string radio { get; set; }

        public void wheels();
        public void doors();
        public void wiperBlades();
        public void radio();

    }
}
