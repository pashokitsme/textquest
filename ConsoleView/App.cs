using Core.Data;
using Core.Scenes;

namespace ConsoleView;

public class App
{
    private readonly ISceneProvider _provider;
    private readonly IView _view = new ConsoleView();

    private SceneNode _current;

    public App(ISceneProvider provider) => _provider = provider;

    public void Start()
    {
        _current = _provider.LoadRecusively();
        _view.Draw(_current.Data);

        var input = 1;
        while (input != 0)
        {
            input = Input();
            if (input < 1 || input > _current.Answers.Count)
                continue;

            _current = _current.Answer(_current.Answers[input - 1]);
            _view.Draw(_current.Data);
        }

        Console.Clear();
        Console.WriteLine("Конец");
    }

    private static int Input()
    {
        var key = Console.ReadKey(true);
        return (int) char.GetNumericValue(key.KeyChar);
    }
}
