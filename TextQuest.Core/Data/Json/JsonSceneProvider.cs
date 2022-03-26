using Core.Scenes;
using Newtonsoft.Json;
using TextQuest.Logging;

namespace Core.Data.Json;

public class JsonSceneProvider : ISceneProvider
{
    public List<JsonSceneData> All => Data;

    private readonly string _path;
    private List<JsonSceneData> Data => _data ??= LoadJson();
    private List<JsonSceneData> _data;

    public JsonSceneProvider(string path) => _path = path;

    public Node LoadRoot()
    {
        var data = Data.FirstOrDefault(scene => scene.Id == "initial");
        if (data == null)
            throw new ArgumentNullException("No initial scene");

        var answers = new List<Answer>();
        foreach (var ans in data.Answers)
            answers.Add(new Answer(ans.Body, Load(ans.NextSceneId)));
        
        return new Node(data, answers);
    }

    public ISceneData Load(string sceneId) => Data.FirstOrDefault(scene => scene.Id == sceneId);

    private List<JsonSceneData> LoadJson()
    {
        var json = File.ReadAllText(_path);
        var data = JsonConvert.DeserializeObject<JsonData>(json);
        if (data == null)
            throw new ArgumentException(null, nameof(_path));
        return data.Data;
    }

    public ISceneData Create(string header, string body, List<JsonAnswerData> answers) => 
        new JsonSceneData()
        {
            Id = Guid.NewGuid().ToString(),
            Header = header,
            Body = body,
            Answers = answers
        };

    public bool TrySave(ISceneData data)
    {
        if (data is not JsonSceneData jsonData)
        {
            Logger.Log($"Tried to save scene [{data.Id}] but data is not JsonSceneData", LogSeverity.Error);
            return false;
        }

        var json = new JsonData()
        {
            Data = Data
        };

        var existing = Data.FirstOrDefault(scene => scene.Id == data.Id);
        if (existing != null)
        {
            Logger.Log($"Scene [{data.Id}] exists: overriding");
            existing = (JsonSceneData)data;
            File.WriteAllText(_path, JsonConvert.SerializeObject(json, Formatting.Indented));
            return true;
        }

        Logger.Log($"Saving scene [{data.Id}]");
        Data.Add(jsonData);
        File.WriteAllText(_path, JsonConvert.SerializeObject(json, Formatting.Indented));
        return true;
    }
}