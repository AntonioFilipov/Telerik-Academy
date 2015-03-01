using System;

class Index
{
    static void Main(string[] args)
    {
        int[] letters = new int[26];
        for (char i = 'A'; i <= 'Z'; i++) letters[i - 65] = i;

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        foreach (char t in word)
        {
            Console.WriteLine("Letter '{0}' -> index: {1} / ASCII Index: {2}",
                t, Array.IndexOf(letters, char.ToUpperInvariant(t)), (int)t);
        }
    }
}

