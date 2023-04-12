using System;
using System.Collections.Generic;

public class InputExamples
{
    static public void Main()
    {
        //Single-Line Input
        string input = Console.ReadLine();
        Console.WriteLine("Single Line: {0}", input);

        //Multi-Line Input
        List<string> lines = new List<string>();
        string line;
        int ct = 0;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            lines.Add(line);
            ct += 1;
            if (ct == 4) break;
        }
        Console.WriteLine("Multi-Line:");
        int len = lines.Count;
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(lines[i]);
        }

        //File input
    }
}