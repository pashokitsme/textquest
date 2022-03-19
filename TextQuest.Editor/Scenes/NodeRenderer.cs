using Core.Scenes;
using TextQuest.Editor.ViewBehaviour;
using TextQuest.Logging;

namespace TextQuest.Editor;

public class NodeRenderer
{
    public event Action<string> Clicked;

    private readonly MainWindow _window;

    public NodeRenderer(MainWindow window)
    {
        _window = window;
        Clicked += id => Logger.Log($"Clicked sidebar, sceneId: {id}");
        AddEffects(_window.PreviousScene);
        _window.PreviousScene.Click += (_, _) =>
        {
            var text = _window.PreviousScene.Text.Remove(0, 10);
            if (text == "Null")
                return;

            Clicked?.Invoke(text);
        };
    }

    public void RenderView(Node node)
    {
        Logger.Log($"Render for id: {node.Data.Id}");
        var data = node.Data;
        _window.SceneBodyEditor.Text = data.Body;
        _window.SceneIdEditor.Text = data.Id;
        _window.SceneHeaderEditor.Text = data.Header;

        _window.PreviousScene.Text = $"Previous: {(node.Root == null ? "Null" : node.Root.Id)}";
        
        if (node.Childs != null)
            RenderSidebar(node.Childs.Select(x => x.NextScene.Id), _window.ChildsBox);
    }

    private void RenderSidebar(IEnumerable<string> items, GroupBox box)
    {
        box.Controls.Clear();
        var offset = 0;
        var y = 10;
        foreach (var item in items)
        {
            offset += 20;

            var label = new Label()
            {
                Text = item,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(y, offset)
            };

            AddEffects(label);
            label.MouseClick += (_, _) => Clicked?.Invoke(label.Text);
            box.Controls.Add(label);
        }
    }

    private static void AddEffects(Label label)
    {
        label.MouseEnter += (_, _) => SidebarButton.OnMouseEnter(label);
        label.MouseLeave += (_, _) => SidebarButton.OnMouseLeave(label);
    }
}