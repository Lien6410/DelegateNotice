using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNotice
{
    public class TemperatureMonitorUsingDelegate
    {
        public delegate void TemperatureChangedHandler(double tempature);

        public TemperatureChangedHandler OnTemperatureChanged;

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                var oldTemperature = temperature;
                if (oldTemperature != value)
                {
                    temperature = value;
                    OnTemperatureChanged.Invoke(value);
                }
            }
        }

        public TemperatureMonitorUsingDelegate()
        {
            // 使用delegate必須給定一個初始的委派方法
            OnTemperatureChanged = temperatureChanged;
        }

        private void temperatureChanged(double tempature)
        {
            Console.WriteLine($"溫度發生變化了...{tempature}");
        }
    }
}
