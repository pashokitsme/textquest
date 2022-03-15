using Core.Data;
using Core.Scenes;

namespace TextQuest.Core.Scenes;

public class SceneHierarhyProvider
{
    public Node Current => _current;
    public Node Previous => _previous;

    private Node _current;
    private Node _previous;
    private readonly Node _root;
    private readonly ISceneProvider _provider;

    public SceneHierarhyProvider(Node root, ISceneProvider provider)
    {
        _root = root;
        _provider = provider;
        _current = _root;
    }

    public bool Next(int answer)
    {
        if (_current.NextByAnswer(answer, out var data) == false)
            return false;

        var answers = new List<Answer>(data.Answers.Count);
        foreach (var ans in data.Answers)
        {            
            var next = ans.NextSceneId == "!parent" ? _current.Data : _provider.Load(ans.NextSceneId);
            answers.Add(new Answer(ans.Body, next));
        }

        var node = new Node(data, answers, new List<ISceneData>() { _current.Data });
        _previous = _current;
        _current = node;

        return true;
    }

    public void Reset()
    {
        _current = _root;
    }
}
