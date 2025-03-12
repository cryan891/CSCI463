using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace MauiApp1
{
    public static class DriverData
    {
        // ObservableCollection automatically changes in UI
        public static ObservableCollection<Driver> Drivers { get; set; } = new ObservableCollection<Driver>();
    }
}