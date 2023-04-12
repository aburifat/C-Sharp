using System;
using System.Collections.Generic;
public class InputSingleLine
{
    static public void Main()
    {
        string line = Console.ReadLine();
        string[] vars = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int len = vars.Length;

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Single Line: {0}", vars[i]);
        }
    }
}