using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static partial class Helpers
{
    public static void ChoiceOne()
    {
        Console.Clear();
        Console.Title = "Converting HEX to ASCII";
        Console.Write("Paste your hex here: ");
        string hex = Console.ReadLine();
        Console.Clear();

        hex = Regex.Replace(hex, @"\s+", "");

        List<string> bytes = new List<string>();
        for (int i = 0; i < hex.Length; i += 2)
        {
            bytes.Add(" " + hex.Substring(i, 2));
        }

        foreach (string b in bytes)
        {
            Console.Write(Helpers.ToAscii(Regex.Replace(b, @"\s+", "")));
        }

        Console.ReadKey();
    }
}