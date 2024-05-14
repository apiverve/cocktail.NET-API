using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class ingredients
{
    [JsonProperty("unit")]
    public string unit { get; set; }

    [JsonProperty("amount")]
    public int amount { get; set; }

    [JsonProperty("ingredient")]
    public string ingredient { get; set; }

}

public class cocktails
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("glass")]
    public string glass { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("ingredients")]
    public ingredients[] ingredients { get; set; }

    [JsonProperty("garnish")]
    public string garnish { get; set; }

    [JsonProperty("preparation")]
    public string preparation { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string filteredOn { get; set; }

    [JsonProperty("cocktails")]
    public cocktails[] cocktails { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
