/*Задайте одномерный массив из 123 случайных чисел. 
Найдите количество двухзначных элементов массива.
Пример для массива из 5, а не 123 элементов.
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 500);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(string.Empty);
}

int AmbiguityNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            sum += 1;
        }
    }
    return sum;
}
int[] massive = GetArray(123);
PrintArray(massive);
System.Console.WriteLine(AmbiguityNumber(massive));

