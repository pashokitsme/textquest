using Core.Data;
using Core.Scenes;
using System.Text;

namespace TextQuest.Editor;

public class SceneDiagramDrawer
{
    private readonly SceneNode _parent;
    private readonly GroupBox _box;
    private readonly ISceneProvider _provider;
    private readonly LineDrawer _lineDrawer;

    private readonly int _marginX = 20;

    private readonly Dictionary<string, SceneDiagramNode> _createdDiagrams = new();


    public SceneDiagramDrawer(ISceneProvider provider, SceneNode parent, GroupBox box)
    {
        _parent = parent;
        _box = box;
        _provider = provider;
        _lineDrawer = new LineDrawer(_box, new Pen(Color.Red, 3f));

        //var p1 = new Point(box.Location.X, box.Location.Y);
        //var p2 = new Point(box.Location.Y, (box.Height - box.Location.X) / 2);
        //_lineDrawer.Add(new Line(p1, p2));
        //Console.WriteLine(p1);
        //Console.WriteLine(p2);
    }

    public void DrawRecursively(SceneNode node, SceneDiagramNode diagram)
    {
        diagram.Box.Location = new Point(_marginX, 1);
        DrawAll(node, diagram);
        _lineDrawer.ScheduleDraw();
    }

    private void DrawAll(SceneNode node, SceneDiagramNode diagram, SceneDiagramNode parent = null, int offsetX = 0, int offsetY = 0, int marginMultiplier = 1)
    {
        if (_box.Controls.ContainsKey(node.Data.Id))
                return;

        _box.Controls.Add(diagram.Box);
        //diagram.Box.Location = new Point(_marginX * marginMultiplier + offsetX, offsetY);

        Console.WriteLine( $"{node.Data.Id} ({diagram.Box.Location.X}; {diagram.Box.Location.Y})");

        offsetX += diagram.Box.Width;
        marginMultiplier++;
        for (int i = 0; i < node.Answers.Count; i++)
        {
            var answer = node.Answers[i];
            var nextNode = answer.NextScene;
            var nextDiagramNode = CreateDiagramNode(nextNode.Data);
            nextDiagramNode.Box.Location = new Point(_marginX * marginMultiplier + offsetX, offsetY);
            offsetY += diagram.Box.Height * i;

            DrawAll(nextNode, nextDiagramNode, diagram, offsetX, offsetY, marginMultiplier: marginMultiplier);
            _lineDrawer.Add(new Line(diagram.Box.Location, nextDiagramNode.Box.Location));
        }
    }

    public SceneDiagramNode CreateDiagramNode(ISceneData node, int offset = 0)
    {
        if (_createdDiagrams.ContainsKey(node.Id))
            return _createdDiagrams[node.Id];

        var builder = new StringBuilder(node.Body);
        builder.AppendLine();

        for (var i = 0; i < node.Answers.Count; i++)
            builder.AppendLine($"{i + 1}) {node.Answers[i].Body}");

        var label = new Label()
        {
            Dock = DockStyle.Fill,
            Size = new Size(196, 82),
            TabIndex = 0,
            Name = $"label_{node.Id}",
            Text = builder.ToString(),
            TextAlign = ContentAlignment.MiddleCenter,

        };

        var box = new GroupBox()
        {
            AutoSize = true,
            Name = node.Id,
            Size = new Size(200, 150),
            TabIndex = 0,
            TabStop = false,
            Text = node.Id
        };

        box.Controls.Add(label);

        var diagram = new SceneDiagramNode(box, label);
        _createdDiagrams.Add(node.Id, diagram);
        return diagram;
    }
}

public record SceneDiagramNode(GroupBox Box, Label Label);