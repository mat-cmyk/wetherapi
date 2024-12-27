using System;
using System.Collections.Generic;

using System.Globalization;




namespace WhetherApp.Models
{
    

    public partial class WeatherForecast
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double GenerationtimeMs { get; set; }

        public long UtcOffsetSeconds { get; set; }

        public string Timezone { get; set; }

        public string TimezoneAbbreviation { get; set; }

        public long Elevation { get; set; }

        public DailyUnits DailyUnits { get; set; }

        public Daily Daily { get; set; }
    }

    public partial class Daily
    {
        public DateTimeOffset[] Time { get; set; }

        public double[] Temperature2MMax { get; set; }
    }

    public partial class DailyUnits
    {
        public string Time { get; set; }

        public string Temperature2MMax { get; set; }
    }
/* 
    public partial class C
    {
        public static C FromJson(string json) => JsonConvert.DeserializeObject<C>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this C self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    } */
}
