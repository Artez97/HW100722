/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(-99, 100);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void Sum(int[] arr)
{
    int razn = 0;
    int max = 0;
    int min = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[0] > arr[1])
            max = arr[0];
        else
            max = arr[1];
        if (arr[2] > max)
            max = arr[2];
        else
            max = max;
        if (arr[3] > max)
            max = arr[3];
        else
            max = max;


        if (arr[0] < arr[1])
            min = arr[0];
        else
            min = arr[1];
        if (arr[2] < min)
            min = arr[2];
        else
            min = min;
        if (arr[3] < min)
            min = arr[3];
        else
            min = min;
        razn = max - min;
    }


    Console.WriteLine($"Макс число массива  {max} ");
    Console.WriteLine($"Мин число массива  {min} ");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max} - {min} = {razn}");
}



int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
Sum(array);