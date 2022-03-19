using Core.Data;
using Core.Scenes;
using TextQuest.Core.Scenes;
using TextQuest.Logging;

namespace TextQuest.Editor;

public class SceneSettingsEditor
{
    public event Action<Node> ViewChanged;

    private readonly ISceneProvider _provider;
    private readonly SceneHierarhyProvider _hierarhy;

    public SceneSettingsEditor(ISceneProvider provider, Node root)
    {
        _hierarhy = new(root, provider);
        _provider = provider;
    }

    public void MoveTo(string sceneId)
    {
        var data = _provider.Load(sceneId);
        if (data == null)
        {
            Logger.Log($"Tried to load scene [{sceneId}] that does not exists");
            return;
        }

        _hierarhy.SetCurrentNode(data, _hierarhy.Current.Data);
        ViewChanged?.Invoke(_hierarhy.Current);
    }

    public Node CreateNode()
    {
        throw new NotImplementedException();
    }

    public void SetHeader(string header)
    {
        if (string.IsNullOrEmpty(header))
            return;

        _hierarhy.Current.Data.Header = header;
        ViewChanged?.Invoke(_hierarhy.Current);
    }

    public void SetBody(string body)
    {
        if (string.IsNullOrEmpty(body))
            return;

        _hierarhy.Current.Data.Body = body;
        ViewChanged?.Invoke(_hierarhy.Current);
    }
}