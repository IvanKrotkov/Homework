// Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число:");
int c = int.Parse(Console.ReadLine()!);
int max(int a ,int b ,int c)
{
    int max1 = a;
    if (b>max1) max1 = b;
    if (c>max1) max1 = c;
    return max1;
}
int max2 = max(a,b,c);  
System.Console.WriteLine($"Максимальное число:{max2}");