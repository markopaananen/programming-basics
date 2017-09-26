using System;

public class Example
{
    public static void Main()
    {
        String s = "aaaaabbbcccccccdd";
        Char charRange = 'c';
        int startIndex = s.IndexOf(charRange);
        int endIndex = s.LastIndexOf(charRange);
        int length = endIndex - startIndex + 1;
        Console.WriteLine("{0}.Substring({1}, {2}) = {3}",
                          s, startIndex, length,
                          s.Substring(startIndex, length));
        Console.ReadKey();
    }
}

