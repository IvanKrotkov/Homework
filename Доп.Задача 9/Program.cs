/* Напишите программу, которая принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
string Diff(int num)
{
    string i = "Да";
    string m = "Нет";
    if (num % 7 == 0 && num % 23 == 0)
    {
        return i;
    }
    else
    {
        return m;
    }
}
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Diff(number));