using Core.Data;
using Newtonsoft.Json;

namespace Core.Data.Json;

public class JsonData
{
    [JsonProperty("data"), JsonRequired] public List<JsonSceneData> Data { get; set; }
}

public class JsonAnswerData : IAnswerData
{
    [JsonProperty("body"), JsonRequired] public string Body { get; set; }
    [JsonProperty("next_id"), JsonRequired] public string NextSceneId { get; set; }
}

public class JsonSceneData : ISceneData
{
    [JsonProperty("id"), JsonRequired] public string Id { get; set; }
    [JsonProperty("header"), JsonRequired] public string Header { get; set; }
    [JsonProperty("body"), JsonRequired] public string Body { get; set; }
    [JsonProperty("answers"), JsonRequired] public List<JsonAnswerData> Answers { get; set; }
}
