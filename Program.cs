// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] arrayOfIntegers = [12, 21, 34, 43, 56, 65, 78, 87, 910, 109, 1112, 1211, 1314, 1413, 15];
int[] largeArrayOfIntegers = new int[10000];

SearchFor(15, arrayOfIntegers);
SearchFor(404, arrayOfIntegers);
GenerateRandomArrayOfIntegers(largeArrayOfIntegers);
int target = SelectRandomTargetIn(largeArrayOfIntegers);
SearchFor(target, largeArrayOfIntegers);

void SearchFor(int number, int[] arrayOfIntegers)
{
    string returnIndex = $"{number} Not Found";

    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        if (arrayOfIntegers[i] == number)
        {
            returnIndex = $"Found {number} at index {i}";
            break;
        }
    }
    Console.WriteLine(returnIndex);
}

void GenerateRandomArrayOfIntegers(int[] arrayOfIntegers)
{
    int generationCount = arrayOfIntegers.Length;
    string generationStatusMessage = $"Generating {generationCount.ToString()} more numbers.";
    Console.WriteLine(generationStatusMessage);
    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        generationStatusMessage = $"Generating {(generationCount - i).ToString()} more numbers.";
        ClearLine(2);
        Console.WriteLine(generationStatusMessage);
        arrayOfIntegers[i] = GenerateRandomNumber(i, arrayOfIntegers);
    }
    ClearLine(2);
    generationStatusMessage = $"DONE!";
    Console.WriteLine(generationStatusMessage);
}

int GenerateRandomNumber(int length, int[] arrayOfIntegers)
{
    Random randomNumber = new Random();
    int newNumber = randomNumber.Next(0, 10000);
    for (int i = 0; i < length; i++)
    {
        if (arrayOfIntegers[i] == newNumber)
        {
            return GenerateRandomNumber(length, arrayOfIntegers);
        }
    }
    return newNumber;
}

int SelectRandomTargetIn(int[] arrayOfIntegers)
{
    Random randomNumber = new Random();
    int newNumber = randomNumber.Next(0, arrayOfIntegers.Length - 1);
    Console.WriteLine($"{arrayOfIntegers[newNumber]} was selected as the target.");
    return arrayOfIntegers[newNumber];
}

void ClearLine(int row)
{
    Console.SetCursorPosition(0, row);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, row);
}