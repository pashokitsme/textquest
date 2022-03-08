using Core.Data;
using Core.Scenes;

namespace ConsoleView;

public class ConsoleView : IView
{
    public void Draw(ISceneData data)
    {
        Console.Clear();

        if (data == null)
            return;

        Console.WriteLine(data.Header);
        Console.WriteLine();
        Console.WriteLine(data.Body);
        Console.WriteLine();

        for (var i = 0; i < data.Answers.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {data.Answers[i].Body}");
        }

        Console.WriteLine();
        Console.WriteLine("0) Выход");
    }
}