//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] array = { {34, 12, 78, 43},
                 { 8, 14, 19, 18},
                 { 25,28, 26, 20},
                 { 11,18, 20, 25} };

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] nextArray = array;
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
SortArray(array);

void PrintNextArray(int[,] nextArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}

PrintArray(nextArray);
Console.WriteLine();
Console.WriteLine();
PrintNextArray(array);
