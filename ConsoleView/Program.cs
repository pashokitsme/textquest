using Core.Data.Json;

namespace ConsoleView;

public static class Program
{
    public static void Main()
    {
        var provider = new JsonSceneProvider(@"data.json");
        new App(provider).Start();
    }
}