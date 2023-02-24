// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//              находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] rowSum(int[,] inArray)                // Вычисление суммы в каждой строке.
{
    int[] result = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            result[i] = sum;
        }
    }
    return result;
}

void PrinRowtMinSum(int[] array)            // Поиск и печать строки с наименьшей суммой элементов.
{
    int min = array[0];
    int index = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {index} строка");
    Console.WriteLine();
}

void PrintRowSum(int[] inArray)             // Для удобства !!! Печать массива сумм элементов в каждой строке.             
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.WriteLine($"сумма элементов в {i+1} строке = {inArray[i]}\t");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(row, col, 1, 10);
PrintArray(matrix);
Console.WriteLine();

int[] index = rowSum(matrix);
PrinRowtMinSum(rowSum(matrix));

Console.WriteLine();
PrintRowSum(index);