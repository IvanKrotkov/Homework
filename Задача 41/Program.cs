/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/


int[] FormMassive(int amountEl)
{
    int[] array = new int[amountEl];
    for (int i = 0; i < amountEl; i++)
    {
        System.Console.WriteLine("Введите число:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void AmountNumber(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            amount++;
        }
    }
    System.Console.WriteLine("Количество чисел больше 0:" + amount);
}

System.Console.WriteLine("Сколько чисел вы хотите ввести?:");
int amountEl = int.Parse(Console.ReadLine()!);
AmountNumber(FormMassive(amountEl));