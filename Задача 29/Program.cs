/* Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void PrintArray(int[] array, int lenght)
{
    System.Console.Write("[");
    for (int j = 0; j < lenght; j++)
    {
        System.Console.Write(array[j]);
        if (j < lenght - 1)
        {
            System.Console.Write(",");
        }
    }
    System.Console.Write("]");
}

int[] CreateRandomArray(int lenght, int maxValue)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, maxValue);
    }
    return array;
  
}
System.Console.WriteLine("Введите длину массива:");
int lenghtArray = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число, которое будет границей диапазона на выбор случайного числа");
int maxValue = int.Parse(Console.ReadLine()!);
CreateRandomArray(lenghtArray,maxValue);
PrintArray(CreateRandomArray(lenghtArray,maxValue), lenghtArray);