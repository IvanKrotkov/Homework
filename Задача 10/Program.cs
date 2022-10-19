/* Напишите программу, которая принимает на вход трёхзначное
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int ThreeDigital(int number)
{
    if (number>100&&number<1000)
    {
        return ((number-number%10)%100)/10;
    }
    else
    {
        return 0;
    }  
}
System.Console.WriteLine("Введите число");
int InputNumber = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(ThreeDigital(InputNumber));