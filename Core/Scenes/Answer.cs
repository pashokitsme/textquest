namespace Core.Scenes;

public class Answer
{
    public string Body { get; }
    public SceneNode NextScene { get; }

    public Answer(string body, SceneNode next)
    {
        Body = body;
        NextScene = next;
    }
}