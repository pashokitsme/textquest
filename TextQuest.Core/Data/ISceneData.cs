using Core.Data.Json;

namespace Core.Data;

public interface ISceneData
{
    string Id { get; }
    string Header { get; }
    string Body { get; }
    List<JsonAnswerData> Answers { get; }
}
