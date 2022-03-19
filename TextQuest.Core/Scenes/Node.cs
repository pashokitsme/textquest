using Core.Data;

namespace Core.Scenes;

public class Node
{
    public List<Answer> Childs => _childs;
    public ISceneData Root => _root;
    public ISceneData Data => _data;

    private readonly ISceneData _data;
    private readonly ISceneData _root;
    private readonly List<Answer> _childs;

    public Node(ISceneData data, List<Answer> answers = null, ISceneData root = null)
    {
        _data = data;
        _childs = answers;
        _root = root;
    }

    public bool NextByAnswer(int index, out ISceneData data)
    {
        data = null;
        if (_childs == null || _childs.Count == 0)
            return false;
        if (index >= _childs.Count)
            return false;

        data = _childs[index].NextScene;
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
