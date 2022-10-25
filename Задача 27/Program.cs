/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

int SumDigitalInNumber(int number)
{
    int summ = 0;
    for (int i = 0; i < number; i++)
    {
        summ = summ + number%10;
        number = number/10;
    }
    return summ;
}

System.Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(SumDigitalInNumber(inputNumber));