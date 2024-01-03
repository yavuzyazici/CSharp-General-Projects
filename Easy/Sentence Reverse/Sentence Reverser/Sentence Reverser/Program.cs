Console.WriteLine("Enter a sentence - Enter the sentence in the format specified in the example, Example: Hello I am Yavuz Selim");

string sentence = Console.ReadLine();

string[] words = sentence.Split(" ");
string[] reversedWords = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] letterSequence = words[i].ToCharArray();
    Array.Reverse(letterSequence);
    reversedWords[i] = new string(letterSequence);
}

Console.WriteLine("Inverted sentence:");
Console.WriteLine(string.Join(" ", reversedWords));