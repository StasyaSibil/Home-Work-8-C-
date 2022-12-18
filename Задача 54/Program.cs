// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


var arr = GetArray();
Sorting(arr);

int[,] GetArray()
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}


void Sorting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int y = 0; y < array.GetLength(1) - 1; y++)
            {
                if (array[i, y] < array[i, y + 1])
                {
                    var pos = y + 1;
                    var current = array[i, pos];
                    array[i, pos] = array[i, y];
                    array[i, y] = current;
                }
            }
        }
    }

    Write(array);
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