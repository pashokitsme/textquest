using Core.Data;
using Core.Scenes;
using TextQuest.Core.Scenes;

namespace ConsoleView;

public class App
{
    private readonly ISceneProvider _scenes;
    private SceneHierarhyProvider _hierarhy;
    private readonly IView _view = new ConsoleView();

    public App(ISceneProvider provider) => _scenes = provider;

    public void Start()
    {
        _hierarhy = new SceneHierarhyProvider(_scenes.LoadRoot(), _scenes);
        _view.Draw(_hierarhy.Current.Data);

        var input = 1;
        while (input != 0)
        {
            input = Input();

            if (input == 9)
            {
                _hierarhy.Reset();
                _view.Draw(_hierarhy.Current.Data);
                continue;
            }

            if (input < 1 || input > _hierarhy.Current.Childs.Count)
                continue;


            if (_hierarhy.Next(input - 1) == true)            
                _view.Draw(_hierarhy.Current.Data);            
            else
                break;
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
