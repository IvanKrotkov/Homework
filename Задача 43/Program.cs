/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void Intersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            System.Console.WriteLine("Прямые совпадают");
        }
        else
        {
            System.Console.WriteLine("Прямые не совпадают и параллельны");
        }
    }
    else
    {  
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        System.Console.WriteLine("Точка пересечения:" + "(" + x + ";" + y + ")");
    }
}



System.Console.WriteLine("Введите число k1:");
double k1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b1:");
double b1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число k2:");
double k2 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b2:");
double b2 = double.Parse(Console.ReadLine()!);
Intersection(b1, k1, b2, k2);
