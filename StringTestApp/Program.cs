using System;
using StringExtensionsLibrary;

class Program
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "world";

        Console.WriteLine($"'{word1}' starts with uppercase? {word1.StartsWithUpper()}");
        Console.WriteLine($"'{word2}' starts with uppercase? {word2.StartsWithUpper()}");
    }
}
