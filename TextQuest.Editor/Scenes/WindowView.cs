using Core.Scenes;
using TextQuest.Editor.ViewBehaviour;
using TextQuest.Logging;

namespace TextQuest.Editor;

public class WindowView : IDisposable
{
    public event Action<string> Clicked;
    public event Action Created;

    private readonly MainWindow _window;

    public WindowView(MainWindow window)
    {
        _window = window;
        Clicked += id => Logger.Log($"Clicked sidebar, sceneId: {id}");

        SidebarButton.AddEffects(_window.PreviousScene);
        _window.PreviousScene.Click += (_, _) =>
        {
            var text = _window.PreviousScene.Text.Remove(0, 7);
            if (text == "Null")
                return;

            Clicked?.Invoke(text);
        };

        SidebarButton.AddEffects(_window.CreateScene);
        _window.CreateScene.Click += (_, _) => Created?.Invoke();
    }

    public void RenderView(Node node)
    {
        Logger.Log($"Render for id: {node.Data.Id}");
        var data = node.Data;
        _window.SceneBodyEditor.Text = data.Body;
        _window.SceneIdEditor.Text = data.Id;
        _window.SceneHeaderEditor.Text = data.Header;

        _window.PreviousScene.Text = $"Назад: {(node.Root == null ? "Null" : node.Root.Id)}";
        
        if (node.Childs != null)
            RenderSidebar(node.Childs.Select(x => x.NextScene.Id), _window.ChildsBox);
    }

    public void Dispose()
    {
        Clicked = null;
        Created = null;
    }

    private void RenderSidebar(IEnumerable<string> items, GroupBox box)
    {
        var temp = box.Controls[0];
        box.Controls.Clear();
        box.Controls.Add(temp);
        var offset = 20;
        var y = 10;
        foreach (var item in items)
        {
            offset += 20;

            var label = new Label()
            {
                Text = item,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(y, offset),
                AutoSize = true
            };

            SidebarButton.AddEffects(label);
            label.MouseClick += (_, _) => Clicked?.Invoke(label.Text);
            box.Controls.Add(label);
        }
    }


}