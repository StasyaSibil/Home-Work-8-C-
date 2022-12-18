// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
 
var arr = GetArray();
Write(arr);
MinString(arr);

int[,] GetArray()
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void MinString(int[,] array)
{
    bool init = false;
    int min = 0;
    int pos = 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sum = sum + array[i, j];            
        }

        if (sum < min || !init)
        {
            min = sum;
            pos = i+1;
            init = true;
        }
    }
    Console.Write($"{pos} строка");
}

void Write(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[i, x]} ");
        }
        Console.WriteLine();
    }
}