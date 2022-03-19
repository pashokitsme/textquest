using System.Runtime.InteropServices;

namespace TextQuest.Logging;

public enum LogSeverity
{
    Info,
    Warning,
    Error
}

public static class Logger
{
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    static Logger() => AllocConsole();

    public static void Log(string message, LogSeverity severity = LogSeverity.Info)
    {
        Console.ForegroundColor = severity switch
        {
            LogSeverity.Warning => ConsoleColor.Yellow,
            LogSeverity.Error => ConsoleColor.Red,
            _ => Console.ForegroundColor
        };

        Console.WriteLine($"{DateTime.Now:HH:mm:ss} : {message}");
        Console.ResetColor();
    }
}