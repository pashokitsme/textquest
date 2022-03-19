using Core.Data.Json;

namespace Core.Data;

public interface ISceneData
{
    string Id { get; set; }
    string Header { get; set; }
    string Body { get; set; }
    List<JsonAnswerData> Answers { get; set; }
}
