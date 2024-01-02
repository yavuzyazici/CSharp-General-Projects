using Algorithm_Homework;

Start:

int number; string text;
Console.WriteLine("Please enter a word and letter in the form 'word,letter' (Teststring,3)");
string input = Console.ReadLine();

string[] values = input.Split(",");

if (values.Length > 2)
{
    Console.WriteLine("Wrong Input");
    Thread.Sleep(700);
    Console.Clear();
    goto Start;
}
try
{
    number = Convert.ToInt32(values[1]);
    text = values[0];
}
catch (Exception)
{
    Console.WriteLine("Wrong Input");
    Thread.Sleep(700);
    Console.Clear();
    goto Start;
}

if (text.Length < number+1)
{
    Console.WriteLine(text);
}
else
{
    Controller controller = new Controller();

    controller.Cutter(text, number);
}