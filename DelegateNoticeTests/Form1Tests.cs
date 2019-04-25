using NUnit.Framework;
using DelegateNotice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNotice.Tests
{
    [TestFixture()]
    public class Form1Tests
    {
        [Test()]
        public void DelegateTest()
        {
            // 使用Delegate完成Observer pattern
            Console.WriteLine("Delegate Demo");
            DesktopApp desktopApp = new DesktopApp();
            MobileApp mobileApp = new MobileApp();

            TemperatureMonitorUsingDelegate temperatureMonitorUsingDelegate = new TemperatureMonitorUsingDelegate();

            temperatureMonitorUsingDelegate.OnTemperatureChanged += desktopApp.OnTemperatureChanged;
            temperatureMonitorUsingDelegate.OnTemperatureChanged += mobileApp.OnTemperatureChanged;

            Console.WriteLine("溫度變化了，現在是30.5度");
            temperatureMonitorUsingDelegate.Temperature = 30.5;

            Console.WriteLine("溫度沒變化，現在依然是30.5度");
            temperatureMonitorUsingDelegate.Temperature = 30.5;

            Console.WriteLine("溫度變化了，現在是28.6度");
            temperatureMonitorUsingDelegate.Temperature = 28.6;

            Console.WriteLine("mobileApp不再想觀察了");
            temperatureMonitorUsingDelegate.OnTemperatureChanged -= mobileApp.OnTemperatureChanged;

            Console.WriteLine("溫度變化了，現在是27.6度");
            temperatureMonitorUsingDelegate.Temperature = 27.6;
            Console.WriteLine();

            Assert.True(true);
        }
    }
}