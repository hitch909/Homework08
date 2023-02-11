//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("длинна столбцов не должна превышать длинну строк");
Console.Write($"введите длинну строк массивов,\t");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"введите длинну столбцов массивов,\t");
int n = int.Parse(Console.ReadLine()!);
if (n > m) Console.WriteLine("длинна столбцов не должна превышать длинну строк");                                                                                   //за пределы массива.
else
{
    int[,] ferstArray = new int[m, n]; //первый массив
    CreateArray(ferstArray);
    PrintArray(ferstArray);

    Console.WriteLine();

    int[,] secondArray = new int[m, n]; // второй массив
    CreateArray(secondArray);
    PrintArray(secondArray);

    Console.WriteLine();

    int[,] resultArray = new int[m, n];   // третий массив
    FillArray(resultArray, secondArray, ferstArray);
    PrintArray(resultArray);

    void CreateArray(int[,] array)         // создание и заполнение массива
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 5);
            }
        }
    }

    void PrintArray(int[,] matr)                 // вывод в консоль массива
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();

    void FillArray(int[,] resultArray, int[,] secondArray, int[,] ferstArray)   //создание третьего массива
    {
        for (int i = 0; i < ferstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                int summ = 0;
                for (int k = 0; k < secondArray.GetLength(1); k++)
                {
                    summ += ferstArray[i, k] * secondArray[k, j];
                }
                resultArray[i, j] = summ;
            }
        }
    }
}
