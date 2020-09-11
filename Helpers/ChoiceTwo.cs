using System;
using System.Collections.Generic;

public static partial class Helpers
{
    public static void ChoiceTwo()
    {
        Console.Clear();
        Console.Title = "Converting ASCII to HEX";
        Console.Write("Paste your ascii here: ");
        string ascii = Console.ReadLine();
        Console.Clear();

        List<string> bytes = new List<string>();
        for (int i = 0; i < ascii.Length; i++)
        {
            bytes.Add(ascii.Substring(i, 1));
        }

        string output = "";
        foreach (string b in bytes)
        {
            output += Helpers.ToHex(b);
        }

        Console.WriteLine(output);

        Console.ReadKey();
    }
}