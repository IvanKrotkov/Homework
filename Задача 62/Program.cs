/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] SpiralFillArrayAdd(int rows, int columns)
{
    int[,] spiralFilledArray = new int[rows, columns];
    int elementInArray = 1;
    while (element <= rows * columns)
    {
        for (int i = 0; i < columns; i++)
        {
            if(element >rows * columns) 
            {
                return spiralFilledArray;
            }
            if (element <= rows)
            {
                spiralFilledArray[0, i] = element;
                element++;

            }
            else if (element >= rows && element < rows+columns-1)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    spiralFilledArray[j, columns-1] = element;
                    element++;
                }

            }
            else if (element >= rows+columns-1 && element <= rows+(columns-1)*2)
            {
                for (int l = columns-1; l >= 0; l--)
                {
                    spiralFilledArray[rows-1, l] = element;
                    element++;
                }
            }
            else if (element > rows+(columns-1)*2 && element < rows+(columns-1)*2+(rows-1))
            {
                for (int m = rows/2; m > 0 ; m--)
                {
                    spiralFilledArray[m , 0] = element;
                    element++;
                }
            }
            else if (element >= rows+(columns-1)*2+(rows-1)  && element < (rows*2)+(columns-1)*2)
            {
                for (int n = rows/columns; n <= columns/2; n++)
                {
                    spiralFilledArray[rows/columns, n] = element;
                    element++;
                }
            }
            else if (element >= rows*columns-1 && element <= rows*columns)
            {
                for (int k = columns/2; k >= rows/columns; k--)
                {
                    spiralFilledArray[rows/2, k] = element;
                    element++;
                } 
            }
        }
    }
    return spiralFilledArray;
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

PrintArray(SpiralFillArrayAdd(5, 5));
