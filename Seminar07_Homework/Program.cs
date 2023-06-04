//Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
/*
Console.Clear();
double[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    double minVal = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input maximum: ");
    double maxVal = Convert.ToDouble(Console.ReadLine());

    double[,] created2Array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            created2Array[i, j] =Math.Round(minVal + (maxVal-minVal) * (new Random().NextDouble()), 2);
        }
    }
    return created2Array;
}

void Print2Array(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (array2d[i, j]<0) Console.Write(array2d[i, j] + "\t");
            else Console.Write(" " + array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2dArray = Create2DArray();
Print2Array(new2dArray);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Clear();
double[,] Create2DArray()
{
    int m = 10;
    int n = 10;
    double minVal = -100;
    double maxVal = 100;

    double[,] created2Array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            created2Array[i, j] =Math.Round(minVal + (maxVal-minVal) * (new Random().NextDouble()), 2);
        }
    }
    return created2Array;
}

void Print2Array(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (array2d[i, j]<0) Console.Write(array2d[i, j] + "\t");
            else Console.Write(" " + array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementInIndex (double [,] arrayCheck, int c, int d)
{
    if (c<=0 || d<=0 || c>arrayCheck.GetLength(0) || d>arrayCheck.GetLength(1))
    {
        Console.WriteLine($"You have enetered wrong cell index. Please start your request again.");
    }
    else Console.WriteLine($"The value of the element at [{c}, {d}] cell is {arrayCheck[c-1,d-1]}.");
}

Console.Write("Input row number of your element: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number of your element: ");
int b = Convert.ToInt32(Console.ReadLine());

double [,] array2d = Create2DArray();
Print2Array(array2d);
ElementInIndex(array2d, a, b);
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Clear();
int[,] Create2DArray()
{
    int m = 10;
    int n = 10;
    int minVal = -10;
    int maxVal = 10;

    int[,] created2Array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (array2d[i, j] < 0) Console.Write(array2d[i, j] + "\t");
            else Console.Write(" " + array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MeanSum(int[,] arrayMS)
{
    double sum;
    Console.WriteLine("Arithmetical means for each column are:");
    for (int j = 0; j < arrayMS.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arrayMS.GetLength(0); i++)
        {
            sum += arrayMS[i, j];
        }
        if (sum < 0) Console.Write(Math.Round(sum/arrayMS.GetLength(0), 1) + "\t");
        else Console.Write(" " + Math.Round(sum/arrayMS.GetLength(0), 1) + "\t");
    }
    Console.WriteLine();
}

int[,] array2d = Create2DArray();
Print2Array(array2d);
MeanSum(array2d);
*/