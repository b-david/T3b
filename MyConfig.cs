using Newtonsoft.Json;

// pokracovani https://www.newtonsoft.com/json/help/html/DeserializeCustomCreationConverter.htm

namespace T3
{
  

  public class Inputs
  {
    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("AnglePosition")]
    public int AnglePosition { get; set; }

    [JsonProperty("Type")]
    public string Type { get; set; }
  }

  public class MyConfig
  {
    [JsonProperty("Inputs")]
    public Inputs[] Inputs { get; set; }

    [JsonProperty("Outputs")]
    public string[] Outputs { get; set; }

    [JsonProperty("LocalAddress")]
    public string LocalAddress { get; set; }

    [JsonProperty("LocalPort")]
    public int LocalPort { get; set; }

    [JsonProperty("ModuleNumber")]
    public int ModuleNumber { get; set; }

    [JsonProperty("ServerAddress")]
    public string ServerAddress { get; set; }

    [JsonProperty("ServerPort")]
    public int ServerPort { get; set; }

    [JsonProperty("RailAngleSize")]
    public int RailAngleSize { get; set; }
  }
}
