/* Напишите программу, которая принимает на вход 
число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11*/

void SimpleNumber(int input)
{
  for (int i = 2; i <= input; i++)
  {
    if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0) 
    {
        System.Console.WriteLine(i);
    }
    if(i==2||i==3||i==5||i==7)
    {
        System.Console.WriteLine(i);
    }
  }
 
}

System.Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine()!);
SimpleNumber(inputNumber);
