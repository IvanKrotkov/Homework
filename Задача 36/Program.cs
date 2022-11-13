/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}

void SumElArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        i++;
    }
    System.Console.WriteLine("Сумма элементов на нечётных позициях:" + sum);
}

SumElArray(GetArray(6));