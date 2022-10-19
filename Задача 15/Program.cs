/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли
этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
string Week(int num)
{
    string i ="Да";
    string m = "Нет";
    if(num==6||num==7)
    {
        return i;
    }
    else
    {
        return m;
    }

}

System.Console.WriteLine("Введите день недели:");
int InputNumber = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Week(InputNumber));
