using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNotice
{
    public class MobileApp : ITemperatureMonitorObserver
    {
        public void OnTemperatureChanged(double tempature)
        {
            Console.WriteLine($"Mobile App被通知溫度變化了: {tempature}");
        }
    }
}
