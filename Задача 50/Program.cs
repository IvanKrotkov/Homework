/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int[,] array = new int[,] {{1,4,7,2},
                           {5,9,2,3},
                           {8,4,2,4}};
System.Console.WriteLine("Номер строки:");
int row = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Номер столбца:");
int column = int.Parse(Console.ReadLine()!);
if (row > array.GetLength(0) || column > array.GetLength(1))
{
    System.Console.WriteLine("Такого элемента нет");

}
else
{
    FindElInArray(array, row, column);
}

int FindElInArray(int[,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[row, column])
            {
                System.Console.WriteLine(array[i, j]);
                return  array[i, j];
            }
        }
    }
    return -1;
}