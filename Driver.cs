using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Driver
    {
        public string Name { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleType { get; set; } // EV, Hybrid, or Petrol-Fueled


        public Driver(string name, string vehicleModel, string vehicleType)
        {
            Name = name;
            VehicleModel = vehicleModel;
            VehicleType = vehicleType;
        }
        public Driver()
        {
            Name = "Steven Smith";
            VehicleModel = "2019 Toyota Corolla";
            VehicleType = "Hybrid";
        }
    }
}