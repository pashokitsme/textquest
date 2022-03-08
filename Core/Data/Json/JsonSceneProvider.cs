using Core.Scenes;
using Newtonsoft.Json;

namespace Core.Data.Json;

public class JsonSceneProvider : ISceneProvider
{
    private readonly string _path;
    private List<JsonSceneData> Data => _data ??= LoadJson();
    private List<JsonSceneData> _data;

    public JsonSceneProvider(string path) => _path = path;

    public SceneNode LoadRecusively()
    {
        var sceneData = Data.FirstOrDefault(scene => scene.Id == "initial");
        if (sceneData == null)
            throw new ArgumentNullException("No initial scene");

        return new SceneNode(sceneData, this);
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