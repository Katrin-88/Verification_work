string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        array[i] = Console.ReadLine();
    }

    return array;
}