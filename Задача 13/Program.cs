/* Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int ThirdDigital (int num)
{
     while (num>1000)
    {
      num = (num - num%10)/10;
      
    }
    if (num<1000&&num>100)
        {
        return num%10;
        }
    
    else 
    {
        System.Console.WriteLine("Третьей цифры нет");
        return num;
    }
}

System.Console.WriteLine("Введите число:");
int InputNumber = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(ThirdDigital(InputNumber));
