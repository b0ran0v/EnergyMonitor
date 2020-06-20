using EnergyMonitor.Response;

namespace EnergyMonitor.Weather
{
    class Windmills
    {
        internal static bool isRecommended()
        {
            var weathers = WeatherInformation.GetWeather();
            List[] list = weathers.List;
            bool[] recommend = new bool[4];
            for (int i = 0; i < 1; i++)
            {
                double temperature = list[i].Main.Temp - 273.15; //from Kelvin to Celsius
                recommend[0] = (temperature >= -40 && temperature <= 40) ? true : false; //temperature check
                recommend[1] = list[i].Main.SeaLevel < 1000 ? true : false; //sea level check
                recommend[2] = list[i].Wind.Speed < 30 ? true : false; //wind speed check
                recommend[3] = list[i].Main.Humidity < 70 ? true : false; //humidity check
            }

            int count = 0;
            foreach (bool r in recommend)
            {
                if (r) count++;
            }

            return count >= recommend.Length / 2;
        }
    }
}
