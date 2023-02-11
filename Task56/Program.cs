//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] matrix = GetArray(4, 3);  // заполняем матрицу
PrintArray(matrix);              //выводим матрицу в консоль
Console.WriteLine();
SumArray(matrix);                //находим суммы элементов массива
int[,] GetArray(int m, int n)     
{
    int[,] matrix = new int[m, n];//создаем матрицу
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,6}\t", matr[i, j]);
        }
        Console.WriteLine();
    }
}

void SumArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summRows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summRows += matrix[i, j];
        }
        Console.WriteLine("сумма элементов в строке {0} = {1}", i + 1, summRows);
    }
}

int sumLine = SumLineArray(matrix, 0);
int SumLineArray(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int minSumLine = 0;
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineArray(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
