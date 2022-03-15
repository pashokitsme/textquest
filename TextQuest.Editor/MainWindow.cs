using Core.Data.Json;
using Core.Scenes;
using System.Runtime.InteropServices;

namespace TextQuest.Editor;

public partial class MainWindow : Form
{

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    private SceneDiagramDrawer _drawer;
    private SceneNode _baseNode;

    public MainWindow() => InitializeComponent();

    private void Loaded(object sender, EventArgs e)
    {
        AllocConsole();

        var provider = new JsonSceneProvider(@"data.json");
        _baseNode = provider.LoadRecusively();

        _drawer = new SceneDiagramDrawer(provider, _baseNode, ScenesBox);
        var node = _drawer.CreateDiagramNode(_baseNode.Data);
        _drawer.DrawRecursively(_baseNode, node);

    }

    private void LoadDiagramData(object sender, EventArgs e)
    {

    }
}
