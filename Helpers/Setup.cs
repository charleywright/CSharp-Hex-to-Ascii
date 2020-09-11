using System;

public static partial class Helpers
{
    public static char Setup()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Would you like to [1] convert hex to ascii or [2] convert ascii to hex?");
        return Console.ReadKey().KeyChar;
    }
}