/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] MultiplicationMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int resultMultiplication = 0;
    int[,] collectedMatrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSecond.GetLength(0); k++)
            {
                resultMultiplication += matrixFirst[i, k] * matrixSecond[k, j];
            }

            collectedMatrix[i, j] = resultMultiplication;
            resultMultiplication = 0;
        }
    }
    return collectedMatrix;
}


void PrintResult(int[,] array)
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

int[,] matrixFirst = new int[,] {{2,4},
                                 {3,2}};
int[,] matrixSecond = new int[,] {{3,4},
                                  {3,3}};
                                
if(matrixFirst.GetLength(1)==matrixSecond.GetLength(0))
{
    PrintResult(MultiplicationMatrix(matrixFirst, matrixSecond));
}
else
{
    System.Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы matrixFirst не равно количеству строк матрицы matrixSecond.");
}