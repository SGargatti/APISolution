using System;

namespace APISolution
{
    public class WeatherForecast
    {
        //Adding Comment to check if this is fetched from VS
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
