using Core.Scenes;
using Newtonsoft.Json;

namespace Core.Data.Json;

public class JsonSceneProvider : ISceneProvider
{
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
}