using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Ingredients data
    /// </summary>
    public class Ingredients
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("ingredient")]
        public string Ingredient { get; set; }

    }
    /// <summary>
    /// Cocktails data
    /// </summary>
    public class Cocktails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("glass")]
        public string Glass { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("ingredients")]
        public Ingredients[] Ingredients { get; set; }

        [JsonProperty("preparation")]
        public string Preparation { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("filteredOn")]
        public string FilteredOn { get; set; }

        [JsonProperty("cocktails")]
        public Cocktails[] Cocktails { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
