using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Weather
{
    public interface WeatherSubject
    {
        void AddObserver(WeatherObserver weatherObserver);
        void RemoveObserver(WeatherObserver weatherObserver);
        void Notify();
    }
}

