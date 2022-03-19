using Core.Data.Json;
using TextQuest.Logging;

namespace TextQuest.Editor;

public partial class MainWindow : Form
{
    private SceneSettingsEditor _editor;
    private NodeRenderer _nodeRenderer;

    public MainWindow() => InitializeComponent();

    private void Loaded(object sender, EventArgs e)
    {
        _nodeRenderer = new(this);
        LoadSceneEditor(sender, e);
        Logger.Log("Window loaded");
    }

    private void LoadSceneEditor(object sender, EventArgs e)
    {
        Logger.Log("Editor loaded");
        var provider = new JsonSceneProvider(@"data.json");
        var root = provider.LoadRoot();

        _editor = new SceneSettingsEditor(provider, root);
        _nodeRenderer.Clicked += _editor.MoveTo;
        _editor.ViewChanged += _nodeRenderer.RenderView;

        _nodeRenderer.RenderView(root);
    }
}
