// See https://aka.ms/new-console-template for more information

int[] arrayOfIntegers = [12, 21, 34, 43, 56, 65, 78, 87, 910, 109, 1112, 1211, 1314, 1413, 15];

string SearchFor(int number)
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
    return returnIndex;
}

Console.WriteLine(SearchFor(15));
Console.WriteLine(SearchFor(404));