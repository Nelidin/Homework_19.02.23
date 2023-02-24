// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
//                 построчно выводить массив, добавляя индексы каждого элемента.

//          Массив размером 2 x 2 x 2:
//                                     66(0,0,0) 25(0,1,0)
//                                     34(1,0,0) 41(1,1,0)
//                                     27(0,0,1) 90(0,1,1)
//                                     26(1,0,1) 55(1,1,1)

Console.Clear();

void GetArray(int[,,] inArray)
{
    int count = int.Parse(Console.ReadLine()!); ;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                inArray[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] inArray3D)
{
    for (int i = 0; i < inArray3D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < inArray3D.GetLength(2); k++)
            {
                Console.Write($"{inArray3D[i, j, k]}({i},{j},{k})\t");
            }
        }
    }
}

int[,,] matrix = new int[2, 2, 2];
Console.Write("Введите двузначное число: ");
GetArray(matrix);
PrintIndex(matrix);
Console.WriteLine();