/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void GetArrayRandomThreeDimensional(int coordinateX, int coordinateY, int coordinateZ)
{
    int[,,] threeDimensionalArray = new int[coordinateX, coordinateY, coordinateZ];
    for (int i = 0; i < coordinateZ; i++)
    {
        for (int j = 0; j < coordinateX; j++)
        {
            for (int k = 0; k < coordinateY; k++)
            {
                Random rnd = new Random();
                threeDimensionalArray[j, k, i] = rnd.Next(10, 100);
                System.Console.Write($"{threeDimensionalArray[j, k, i]}({j},{k},{i})\t");
            }
            System.Console.WriteLine();
        }
    }
}
GetArrayRandomThreeDimensional(2,2,2);


