/* Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void GetArray(int[] array, int lenght)
{
    for (int j = 0; j < lenght; j++)
    {
        System.Console.Write(array[j]);
        if (j < lenght - 1)
        {
            System.Console.Write(",");
        }
    }
}

void Massive(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    System.Console.Write("[");
    GetArray(array, lenght);
    System.Console.Write("]");
}
System.Console.WriteLine("Введите длину массива:");
int lenghtArray = int.Parse(Console.ReadLine()!);
Massive(lenghtArray);