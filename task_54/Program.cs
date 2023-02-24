// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//                    Например, задан массив:
//                                                         1 4 7 2
//                                                         5 9 2 3
//                                                         8 4 2 4
//                    В итоге получается вот такой массив:
//                                                         7 4 2 1
//                                                         9 5 3 2
//                                                         8 4 4 2

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortDecreasing(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, k] > inArray[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temp = inArray[i, j];
            inArray[i, j] = inArray[i, maxPosition];
            inArray[i, maxPosition] = temp;
        }
    }
    return inArray;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 10);
PrintArray(array2D);
Console.WriteLine();
Console.WriteLine($"Отсортированный по убыванию массив:");
Console.WriteLine();
int[,] sorArray = SortDecreasing(array2D);
PrintArray(array2D);




