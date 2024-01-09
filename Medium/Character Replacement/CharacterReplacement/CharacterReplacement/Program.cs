using System;
using System.Linq;

Console.WriteLine("Enter a sentence - Enter the sentence in the format specified in the example, Example: Hello I am Yavuz Selim");

string input = Console.ReadLine();

string[] words = input.Split(" ");
string[] wordsResults = new string[words.Length];

for (int i = 0; i < words.Count(); i++)
{
    try
    {
        string word = words[i];

        char fl = word.First();
        char ll = word.Last();

        if (word.Length == 1)
        {
            wordsResults[i] = word;
            continue;
        }

        string swappedString = ll + word.Substring(1, word.Length - 2) + fl;

        wordsResults[i] = swappedString;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wrong Input");
        return;
    }
    
}

Console.WriteLine("Sentence:");
Console.WriteLine(string.Join(" ", wordsResults));