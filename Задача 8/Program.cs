//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
for (int c = 1; c<a; c++)
{
    if(c%2==0)
    {
        System.Console.WriteLine(c);
    }
}

