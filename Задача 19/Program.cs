/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

void CheckPalindrom(int number)
{
  if (number/10000==number%10 && number%10000/1000==number%100/10)
  {
    System.Console.WriteLine("Да");
  }
  else
  {
    System.Console.WriteLine("Нет");
  }
}

System.Console.WriteLine("Введите число");
int inputNumber = int.Parse (Console.ReadLine()!);
CheckPalindrom(inputNumber);