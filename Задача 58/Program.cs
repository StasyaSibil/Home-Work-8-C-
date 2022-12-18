// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите кол-во строк");
int r = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов");
int c = int.Parse(Console.ReadLine());

var arrayA = GetArray(r, c);
var arrayB = GetArray(r, c);

int[,] res = new int[r, c];

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
        res[i, j] = 0;
        for (int k = 0; k < arrayA.GetLength(1); k++)
        {
            res[i, j] += arrayA[i, k] * arrayB[k, j];
        }
    }
}

Write(res);

void Write(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[i, x]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int r, int c)
{
    var array = new int[r, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}