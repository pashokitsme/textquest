using Core.Data.Json;
using TextQuest.Editor.Scenes;
using TextQuest.Logging;

namespace TextQuest.Editor;

public partial class MainWindow : Form
{
    private SceneEditor _editor;
    private WindowView _nodeRenderer;
    private AllScenesWindow _allScenesWindow;

    private const string TITLE = "TextQuest Editor";
    private const string DIRTY_TITLE = "TextQuest Editor (***)";

    public MainWindow() => InitializeComponent();

    private void Loaded(object sender, EventArgs e)
    {
        _nodeRenderer = new(this);
        _allScenesWindow = new(AllScenesBox);
        LoadSceneEditor(sender, e);
        Logger.Log("Window loaded");
    }

    private void LoadSceneEditor(object sender, EventArgs e)
    {
        if (_editor != null) 
            _editor.Dispose();

        if (_nodeRenderer != null)
            _nodeRenderer.Dispose();

        Logger.Log("Editor loaded");
        var provider = new JsonSceneProvider(@"D:\Projects\TextQuest\TextQuest.Core\data.json");
        var root = provider.LoadRoot();
        _editor = new SceneEditor(provider, root);

        _allScenesWindow.Init(provider.All);
        _allScenesWindow.Clicked += _editor.MoveTo;

        _nodeRenderer.Clicked += _editor.MoveTo;
        _nodeRenderer.Created += _editor.CreateNode;

        _editor.ViewChanged += node =>
        {
            if (_editor.IsDirty)
                _nodeRenderer.RenderView(node);
        };
        _editor.DirtyStateChanged += (dirty) => Text = dirty ? DIRTY_TITLE : TITLE;
        _editor.SceneCreated += _allScenesWindow.AddScene;

        DeleteButton.Click += (_, _) => _editor.DeleteThis();
        SaveButton.Click += (_, _) => _editor.SaveThis();
        SceneIdEditor.TextChanged += (sender, _) => _editor.SetId((sender as TextBox).Text);
        SceneHeaderEditor.TextChanged += (sender, _) => _editor.SetHeader((sender as TextBox).Text);
        SceneBodyEditor.TextChanged += (sender, _) => _editor.SetBody((sender as RichTextBox).Text);

        _nodeRenderer.RenderView(root);
    }
}
