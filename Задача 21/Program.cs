/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double DistanceBetPoint(int x1, int y1, int z1,int x2, int y2, int z2)
{
 return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+ (z1-z2)*(z1-z2));
}

System.Console.WriteLine($"Введите  x координаты первой точки: ");
int x1 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine($"Введите  y координаты первой точки: ");
int y1 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine($"Введите  z координаты первой точки: ");
int z1 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine($"Введите  x координаты второй точки: ");
int x2 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine($"Введите  y координаты второй точки: ");
int y2 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine($"Введите  z координаты второй точки: ");
int z2 = int.Parse (Console.ReadLine()!);
System.Console.WriteLine(DistanceBetPoint(x1,y1,z1,x2,y2,z2));