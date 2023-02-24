// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:                                       Формула:
//                                            2 4 | 3 4            a b | e f   || = (a*e + b*g)  |  = (a*f + b*h)
//                                            3 2 | 3 3            c d | g h   || = (c*e + d*g)  |  = (c*f + d*h)

// Результирующая матрица будет:
//                                             18 20
//                                             15 18


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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;

            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] firstMatrix = GetArray(row, col, 1, 10);
int[,] secondMatrix = GetArray(row, col, 1, 10);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] resultArray = MatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine($"Произведение первой и второй матриц: ");
    Console.WriteLine();
    PrintArray(resultArray);
}
else
    Console.WriteLine($"Нельзя перемножить!");