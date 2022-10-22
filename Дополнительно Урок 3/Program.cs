/* Напишите программу, которая принимает на вход 
число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11

void SimpleNumber(int input)
{
 int count = 2;
 while (count<input)
 {
    if (count%2==0 | count%3==0 | count%5==0 | count%7==0)
    {
        count++;
    }
    else 
    {
        System.Console.WriteLine(count);
        count++;
    }
    count++;
 }
}

System.Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine()!);
SimpleNumber(inputNumber);
*/