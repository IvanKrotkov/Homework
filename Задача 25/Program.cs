/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int Exponentiate(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

System.Console.WriteLine("Введите число A:");
int numberA = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Exponentiate(numberA,numberB));