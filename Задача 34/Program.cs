/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}

void ParityEl(int[] array)
{
    int parity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            parity++;
        }
    }
    System.Console.WriteLine("Кол-во чётных чисел:" + parity);
}

ParityEl(GetArray(4));