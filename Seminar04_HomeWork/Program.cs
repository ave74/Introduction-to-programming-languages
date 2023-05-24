//Задача 25. Напишите цикл, который принимает на вход 2 числа (А и В) и возводит число А в натуральную степень В.
/*
Console.Clear();

void Power (int a, int b)
{
    if(b>0)
    {
        int temp=1;
        for(int i=1; i<=b; i++)
            temp*=a;
        Console.WriteLine($"Number A={a} in power B={b} is {temp}");   
    }
    else Console.WriteLine("Number B has impossible value.");
}

Console.Write("Input integer number A: ");
int un_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number B > 0: ");
int un_B = Convert.ToInt32(Console.ReadLine());

Power(un_A, un_B);
*/
/*
//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

void Summa(int a)
{
    int temp=Math.Abs(a);
    int sum=0;
    while (temp>=1)
    {
        sum=sum+temp%10;
        temp/=10;
    }
    Console.WriteLine($"Your number is {a} and the sum of it's digits is {sum}.");
}

Console.Write("Input integer number A: ");
int un_A = Convert.ToInt32(Console.ReadLine());

Summa(un_A);
*/
/*
//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] CreateNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Enter count of elements: ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateNewArray(countOfElements, minVal, maxVal);
ShowArray(array1);
*/