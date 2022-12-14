/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void AverageElInColumns(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum = Math.Round(sum /= array.GetLength(0),1);
        System.Console.WriteLine(sum);
        sum = 0;
    }
}

int[,] array = new int[,]{{1, 4, 7, 2},
                          {5, 9, 2, 3},
                          {8 ,4 ,2 ,4}};
AverageElInColumns(array);