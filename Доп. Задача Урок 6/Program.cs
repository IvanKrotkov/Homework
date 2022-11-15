/*Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.*/

int MEX(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool noFound = true;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] == i)
            {
                noFound = false;
                break;
            }
        }
        if (noFound)
        {
            return i;
        }
    }
    return array.Length;
}
void PrintMex(int mex)
{
    System.Console.WriteLine(mex);
}

int[] array = { 0, 2, 3, 1, 4 };
PrintMex(MEX(array));

//В этом задании я использовал гугл, поскольку у меня возникли затруднения, и я вообще не имел представления как это осуществить.
