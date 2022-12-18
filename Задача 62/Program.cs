// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

var arr = GetArray();
Write(arr);

int[,] GetArray()
{
    int lenght = 4;
    int[,] array = new int[lenght, lenght];
    int i = 0; 
    int j = 0;
    int index = 1;
    for (int x = 0; x < lenght * lenght; x++)
    {
        int k = 0;
        do { array[i, j++] = index++; } while (++k < lenght - 1);
        for (k = 0; k < lenght - 1; k++) array[i++, j] = index++;
        for (k = 0; k < lenght - 1; k++) array[i, j--] = index++;
        for (k = 0; k < lenght - 1; k++) array[i--, j] = index++;
        ++i; ++j;
        lenght = lenght < 2 ? 0 : lenght - 2;
    }

    return array;
}

void Write(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}