using Core.Data;

namespace Core.Scenes;

public class Node
{
    public List<Answer> Childs => _childs;
    public List<ISceneData> Roots => _roots;
    public ISceneData Data => _data;

    private readonly ISceneData _data;
    private readonly List<ISceneData> _roots;
    private readonly List<Answer> _childs;

    public Node(ISceneData data, List<Answer> answers = null, List<ISceneData> roots = null)
    {
        _data = data;
        _childs = answers;
        _roots = roots;
    }

    public bool NextByAnswer(int answer, out ISceneData data)
    {
        data = null;
        if (_childs == null || _childs.Count == 0)
            return false;
        if (answer >= _childs.Count)
            return false;

        data = _childs[answer].NextScene;
        return data != null;
    }
}

public class Answer
{
    public ISceneData NextScene { get; }
    public string Body { get; }

    public Answer(string body, ISceneData next)
    {
        NextScene = next;
        Body = body;
    }
}
