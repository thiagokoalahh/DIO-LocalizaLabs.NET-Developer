using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        List<string> joias = new List<string>();
        string line = "";

        do
        {
            line = Console.ReadLine();
            joias.Add(line);
        } while (!string.IsNullOrEmpty(line));

        Console.WriteLine(joias.SkipLast(1).Distinct().Count());
    }
}