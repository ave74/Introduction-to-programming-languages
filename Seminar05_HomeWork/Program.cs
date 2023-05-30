//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
/*
Console.Clear();
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int[] array1)
{
    int count=0;
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
        if (array1 [i] % 2 == 0)
           count++;
    }
    Console.WriteLine();
    Console.Write($"There are {count} even numbers");
}

int sizeArray = 10;
int minVal = 100;
int maxVal = 999;

int[] arrayStart = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayStart);
*/

//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Clear();
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int[] array1)
{
    int sum=0;
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
        if (i % 2 != 0)
           sum+=array1[i];
    }
    Console.WriteLine();
    Console.Write($"{sum} is the sum of array elements with odd indexes");
}

int sizeArray = 10;
int minVal = -100;
int maxVal = 100;

int[] arrayStart = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayStart);
*/

//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Clear();
double[] CreateRandomArray(int size, int minVal, int maxVal)
{
    double[] newArray = new double[size];
    double a = 0;
    double b = 0;

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    return newArray;
}

void ShowArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    Console.Write(array[0] + " ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Maximum value is {max}, minimum value is {min}");
    Console.Write($"Difference between max and min values of array elements is {Math.Round((max - min), 2)}");
}

int sizeArray = 10;
int minVal = -100;
int maxVal = 100;

double[] arrayStart = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayStart);
*/