using Core.Data;
using Core.Data.Json;
using TextQuest.Editor.ViewBehaviour;
using TextQuest.Logging;

namespace TextQuest.Editor.Scenes;

public class AllScenesWindow
{
    public event Action<string> Clicked;

    private readonly GroupBox _box;
    private readonly HashSet<string> _datas = new();

    private int _offsetX = 20;
    private int _offsetY = 10;

    public AllScenesWindow(GroupBox box)
    {
        _box = box;
    }

    public void Init(List<JsonSceneData> datas)
    {
        foreach (var data in datas)
            AddScene(data);
    }

    public void AddScene(ISceneData data)
    {
        var id = data.Id;
        if (_datas.Contains(id))
        {
            Logger.Log("Can't add existing scene to all-scenes list", LogSeverity.Error);
            return;
        }

        _datas.Add(id);

        var label = new Label()
        {
            Text = $"{data.Body}\n[{data.Id}]",
            TextAlign = ContentAlignment.MiddleLeft,
            Location = new Point(_offsetY, _offsetX),
            AutoSize = true
        };

        SidebarButton.AddEffects(label);
        label.MouseClick += (_, _) => Clicked?.Invoke(id);
        _box.Controls.Add(label);
        _offsetX += 40;
    }
}
