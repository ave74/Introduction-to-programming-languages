//Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Clear();
int [] InputArr (int count)
 {
    int [] array = new int [count];
    for (int i=0; i<count; i++)
    {
        Console.Write($"Input element {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
 }

 void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int PositiveCount (int [] array)
{
    int posCount=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) posCount++;
    }
    return posCount;
}

Console.Write("Input number of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());

if (countOfElem<=0)
{
    while (countOfElem<=0)
    {
        Console.WriteLine("Impossible value");
        Console.Write("Imput number of elements: ");
        countOfElem = Convert.ToInt32(Console.ReadLine());
    }
}

int [] array;
array=InputArr(countOfElem);
PrintArray(array);
Console.WriteLine($"Number of elements > 0 is {PositiveCount(array)}");
*/

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y=k1*x+b1, y=k2*x+b2. Значения k1, b1, k2, b2 - задаются пользователем.
/*
Console.Clear();
Console.Write("Input coefficient for line1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input constant for line1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coefficient for line2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input constant for line2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

bool CheckIfCross(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Lines are identical");
        return false;
    }
    else if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Lines are parallel");
        return false;
    }
    return true;
}

if (CheckIfCross(k1, b1, k2, b2))
    Console.Write($"Intersection of these lines is at ({(b2 - b1) / (k1 - k2)}, {k1 * (b2 - b1) / (k1 - k2) + b1})");
*/