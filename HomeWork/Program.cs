﻿string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        array[i] = Console.ReadLine();
    }

    return array;
}


void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


int NumberOfWords(string[] array)
{
    int count = 0;
    int length = array.Length;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
            count++;

    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateStringArray(size);

Console.WriteLine("Number of word is " + NumberOfWords(array));

