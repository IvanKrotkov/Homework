/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int SumInRowArray(int[,] array, int indexRow)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[indexRow, i];
    }
    return sum;
}

int FindMinSumInRow(int[,] array)
{
    int minIndexRow = 0;
    int minSum = SumInRowArray(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (SumInRowArray(array, i) < minSum)
        {
            minIndexRow = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов:{minIndexRow}");
    return minIndexRow;
}
int[,] array = new int[,] {{10, 4, 7, 2},
                           {5, 9, 2, 3},
                           {8, 4, 2, 4},
                           {1, 2, 4, 3},
                           {0, 2, 0, 0}};

FindMinSumInRow(array);