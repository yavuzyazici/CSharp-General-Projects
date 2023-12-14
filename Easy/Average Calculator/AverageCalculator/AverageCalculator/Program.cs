bool validInput = false;
while (!validInput)
{
    Console.WriteLine("Write how many elements you will average");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input) || !IsDigit(input) || Convert.ToInt32(input) < 0)
    {
        Console.WriteLine("Wrong input. Please enter a valid non-negative number.");
    }
    else
    {
        validInput = true;
        int[] array = LoadFibbonacci(input);
        Console.WriteLine($"Average of these {array.Length} numbers: {Average(array)}");
    }
}
int[] LoadFibbonacci(string input)
{

    int[] array;

    //Identify the first 2 elements of the array
    array = new int[int.Parse(input)];

    switch (array.Length)
    {
        case 0:
            Console.WriteLine($"Average of these {array.Length} numbers: 0");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        case 1:
            array[0] = 0;
            break;
        case 2:
            array[0] = 0;
            array[1] = 1;
            break;
        default:
            array[0] = 0;
            array[1] = 1;
            break;
    }
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

double Average(int[] array)
{
    int count = 0;double total = 0;
    foreach (var item in array)
    {
        total += item;
        count++;
    }
    return total / count;
}

bool IsDigit(string input)
{
    foreach (char c in input)
    {
        if (!char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}