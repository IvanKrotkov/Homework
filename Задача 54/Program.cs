/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] SortingRowsArrayDescendingFirstStep(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {

            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }

    return array;
}
int[,] SortingRowsArrayDescendingSecondStep(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortingRowsArrayDescendingFirstStep(array);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[,] {{1, 4, 7, 2},
                           {5, 9, 2, 3},
                           {8, 4, 2, 4},
                                        };

SortingRowsArrayDescendingSecondStep(array);
PrintArray(array);
