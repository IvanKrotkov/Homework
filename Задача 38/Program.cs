/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


void DiffMaxMin(double[] array)
{
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < max && array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    System.Console.WriteLine("Разница между максимальным и минимальным элементом массива:" + diff);
}

double[] array = { 5, -3, 3.5, 5.11, 5.132 };
DiffMaxMin(array);


