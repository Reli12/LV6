using Observer.Weather;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWeatherDemo();
        }

        private static void RunWeatherDemo()
        {
            WeatherSubject subject = new WeatherStation(16);
            WeatherObserver observer = new HomeThermostat();
            subject.AddObserver(observer);
            (subject as WeatherStation).SetTemperature(14);
            (subject as WeatherStation).SetTemperature(17);
            (subject as WeatherStation).SetTemperature(25);

        }
    }
}
