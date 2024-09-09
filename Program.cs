// See https://aka.ms/new-console-template for more information

int[] arrayOfNumbers = GenerateRandomNumberArray(1000);
PrintArray(arrayOfNumbers);
SortArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);

int[] GenerateRandomNumberArray(int length)
{
    List<int> listOfNumbers = [];
    for (int i = 0; i < length; i++)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10000);
        listOfNumbers.Add(randomNumber);
    }
    return listOfNumbers.ToArray();
}

void PrintArray(int[] array)
{
    Console.WriteLine("[");
    foreach (var number in array)
    {
        Console.Write($"{number}, ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int left = array[i];
                array[i] = array[j];
                array[j] = left;
            }
        }
    }
}