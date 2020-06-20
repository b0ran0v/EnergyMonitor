using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace EnergyMonitor.Geolocation
{
    class GeolocationInformation
    {
        static string myToken = "SOME_TOKEN";
        internal static string GetCity()
        {
            string url = $"http://ipinfo.io?token={myToken}";
            WebRequest request = WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JsonTextReader reader = new JsonTextReader(new StringReader(responseString));
            GeolocationResponse deserialized = new JsonSerializer().Deserialize<GeolocationResponse>(reader);
            return deserialized.City;
        }
    }
}
