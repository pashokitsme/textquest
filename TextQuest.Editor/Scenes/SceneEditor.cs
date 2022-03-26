using Core.Data;
using Core.Data.Json;
using Core.Scenes;
using TextQuest.Core.Scenes;
using TextQuest.Logging;

namespace TextQuest.Editor.Scenes;

public class SceneEditor : IDisposable
{
    public event Action<ISceneData> SceneCreated;
    public event Action<Node> ViewChanged;
    public event Action<bool> DirtyStateChanged;

    public bool IsDirty
    {
        get => _dirty;
        private set
        {
            if (_dirty != value)
                DirtyStateChanged?.Invoke(value);
            _dirty = value;
        }
    }

    private bool _dirty = false;

    private readonly ISceneProvider _provider;
    private readonly SceneHierarhyProvider _hierarhy;

    public SceneEditor(ISceneProvider provider, Node root)
    {
        _hierarhy = new(root, provider);
        _provider = provider;
    }

    public void MoveTo(string sceneId)
    {
        Logger.Log($"Moving to [{sceneId}]");
        IsDirty = true;
        var data = _provider.Load(sceneId);
        if (data == null)
        {
            Logger.Log($"Tried to load scene [{sceneId}] that does not exists", LogSeverity.Error);
            return;
        }

        _hierarhy.SetCurrentNode(data, _hierarhy.Current.Data);
        ViewChanged?.Invoke(_hierarhy.Current);
    }

    public void CreateNode()
    {
        Logger.Log($"Creating node with parent [{_hierarhy.Current.Data.Id}]");
        IsDirty = true;
        var data = _provider.Create("", "", new List<JsonAnswerData>());

        _hierarhy.Current.Data.Answers.Add(new JsonAnswerData()
        {
            Body = $"Scene -> {data.Id}",
            NextSceneId = data.Id
        });

        var node = _hierarhy.SetCurrentNode(data);
        ViewChanged?.Invoke(node);
        SceneCreated?.Invoke(data);
    }

    public void DeleteThis()
    {
        var temp = _hierarhy.Current;
        var data = _hierarhy.Current.Root;
        data.Answers.RemoveAll(match => match.NextSceneId == temp.Data.Id);
        var node = _provider.Create(data.Header, data.Body, data.Answers);
        _hierarhy.SetCurrentNode(node);
        Logger.Log($"Deleted {data.Id}");
    }

    public void SetId(string id)
    {
        if (string.IsNullOrEmpty(id))
            return;

        SetDirtyIfNotEquals(id, _hierarhy.Current.Data.Id);
        _hierarhy.Current.Data.Id = id;
    }

    public void SetHeader(string header)
    {
        if (string.IsNullOrEmpty(header))
            return;

        SetDirtyIfNotEquals(header, _hierarhy.Current.Data.Header);
        _hierarhy.Current.Data.Header = header;
    }

    public void SetBody(string body)
    {
        if (string.IsNullOrEmpty(body))
            return;

        SetDirtyIfNotEquals(body, _hierarhy.Current.Data.Body);
        _hierarhy.Current.Data.Body = body;
    }

    public void SaveThis()
    {
        _provider.TrySave(_hierarhy.Current.Data);
        IsDirty = false;
    }

    public void Dispose()
    {
        ViewChanged = null;
        DirtyStateChanged = null;
        GC.Collect();
    }

    private void SetDirtyIfNotEquals(string value1, string value2) => IsDirty = value1 != value2;
}