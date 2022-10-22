/*Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Cube(int input)
{
  for (int i = 1; i <= input; i++)
  {
    double num = i;
    System.Console.WriteLine(Math.Pow(num,3));
  }
}

System.Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine()!);
Cube(inputNumber);
