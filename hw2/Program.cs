/*Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0

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

    int summ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        summ = arr[1] + arr[3];


    }


    Console.WriteLine($"Кол-во чётных чисел  {summ} ");
}



int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
Sum(array);