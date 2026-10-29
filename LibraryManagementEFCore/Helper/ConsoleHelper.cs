namespace LibraryEFCore.Helper;

public static class ConsoleHelper
{
    public static void PrintHeader(string title)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(new string('=', 40));
        Console.WriteLine($"   {title.ToUpper()}");
        Console.WriteLine(new string('=', 40));
        Console.ResetColor();
    }

    public static string ReadInput(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    public static void ShowSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n[SUCCESS] {message}");
        Console.ResetColor();
        Pause();
    }

    public static void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n[ERROR] {message}");
        Console.ResetColor();
        Pause();
    }

    public static void Pause()
    {
        Console.WriteLine("\nPress Any Key to Continue...");
        Console.ReadKey();
    }
}