/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int SumNaturalNumbers(int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        return 0;
    }
    return minValue + SumNaturalNumbers(minValue + 1, maxValue);
}

System.Console.WriteLine(SumNaturalNumbers(4, 8));