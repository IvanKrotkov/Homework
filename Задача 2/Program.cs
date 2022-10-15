System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
int max = a;
if(a>b)
{
    System.Console.WriteLine($"Максимальное число:{max}");
}
else 
{
    max = b;    
    System.Console.WriteLine($"Максимальное число:{max}");
}