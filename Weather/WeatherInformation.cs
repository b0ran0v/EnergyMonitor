using System;
using System.IO;
using System.Net;
using EnergyMonitor.Geolocation;
using EnergyMonitor.Response;
using Newtonsoft.Json;


namespace EnergyMonitor.Weather
{
    class WeatherInformation
    {
        static string myToken = "SOME_TOKEN";
        internal static string PrintWeather()
        {
            var weathers = GetWeather();
            List[] list = weathers.List;
            string info = string.Empty;
            for (int i = 0; i < list.Length; i++)
            {
                string date = list[i].DtTxt.ToString();
                string description = list[i].Weather[0].Description;
                string temperature = Convert.ToDecimal(list[i].Main.Temp - 273.15).ToString();
                string seaLevel = list[i].Main.SeaLevel.ToString();
                string windSpeed = list[i].Wind.Speed.ToString();
                string humidity = list[i].Main.Humidity.ToString();
                string inf = $"{date} - {description} - {temperature}°C - {seaLevel} m - {windSpeed} m/s - {humidity} %\n";
                if (i == 1)
                    MainForm.currentWeather = inf;
                info += inf;
            }
            return info;
        }

        internal static WeatherResponse GetWeather()
        {
            string city_name = GeolocationInformation.GetCity();
            string url = $"http://api.openweathermap.org/data/2.5/forecast?q={city_name}&appid={myToken}";
            WebRequest request = WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JsonTextReader reader = new JsonTextReader(new StringReader(responseString));
            return new JsonSerializer().Deserialize<WeatherResponse>(reader);
        }
    }
}
