/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void Intersection(double b1, double k1, double b2, double k2)
{
    double x;
    double y;
    if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны - точек пересечения нет, или прямые совпадают - кол-во точек пересечения равно бесконечности");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
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
