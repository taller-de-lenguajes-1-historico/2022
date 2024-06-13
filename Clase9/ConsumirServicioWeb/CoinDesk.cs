using System.Text.Json.Serialization;
public class Bpi
    {
        [JsonPropertyName("USD")]
        public Currecy USD { get; set; }

        [JsonPropertyName("GBP")]
        public Currecy GBP { get; set; }

        [JsonPropertyName("EUR")]
        public Currecy EUR { get; set; }
    }

    public class Currecy
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rate_float")]
        public double RateFloat { get; set; }
    }

    

    public class CoinDesk
    {
        [JsonPropertyName("time")]
        public Time Time { get; set; }

        [JsonPropertyName("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonPropertyName("chartName")]
        public string ChartName { get; set; }

        [JsonPropertyName("bpi")]
        public Bpi Bpi { get; set; }
    }

    public class Time
    {
        [JsonPropertyName("updated")]
        public string Updated { get; set; }

        [JsonPropertyName("updatedISO")]
        public DateTime UpdatedISO { get; set; }

        [JsonPropertyName("updateduk")]
        public string Updateduk { get; set; }
    }

  

