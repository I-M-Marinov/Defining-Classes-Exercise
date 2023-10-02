using System;
using System.Threading.Channels;

namespace DateModifier;

public static class StartUp
{
    static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int differenceInDays = DateModifier.GetDifferenceInDays(start, end);

        Console.WriteLine(Math.Abs(differenceInDays));
    }
}

