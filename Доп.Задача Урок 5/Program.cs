/* Дан массив чисел. Напишите функцию, которая ищет заданное число в 
массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.*/

int NumberSearch(int[] arr, int searchNumber)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==searchNumber)
        {
            System.Console.WriteLine("Индекс числа:"+i);
            return i;
        }
        else if(i==arr.Length-1)
        {
            System.Console.WriteLine("Числа в массиве нет");
        }
    }
    return -1;
}

int[] array = { 1, 14, 43 };
NumberSearch(array, 43);