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


void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


string[] CreateNewArray(string[] array)
{
    string[] newarray = new string[size];
       for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
        
    return newarray;
}


string[] names = CreateStringArray(size);




//Задача 2.Написать программу, которая на вход принимает 2 массива строк и возвращает массив из попарно объединеннных исходных элементов
