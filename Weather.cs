﻿using System.Text.Json.Serialization;

namespace JsonPaerser
{
    public class Weather
    {
        public string City { get; set; } = string.Empty;

        public double Temperature { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        public int Humidity { get; set; }

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        public string Condition { get; set; } = string.Empty;

        [JsonIgnore]
        public DateTime LastUpdated { get; set; }
    }
}
