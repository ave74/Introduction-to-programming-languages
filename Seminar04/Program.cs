/*
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
Console.Clear();
void FindSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Sum of elements from 1 to {a} is {sum}");
}

Console.Write("Input your number: ");
int un = Convert.ToInt32(Console.ReadLine());

if (un >= 1)
{
    FindSum(un);
}
else Console.WriteLine("Impossible value");
*/

/*
//Напишите программу, которая принимает на вход число и выдаёт количество в нём цифр.
Console.Clear();
int CountOfDigits(int a)
{
    int count = 1;
    while (a >= 10)
    {
        a = a / 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int un = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your number has {CountOfDigits(Math.Abs(un))} digits");
*/

/*
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
//0!=1
Console.Clear();
void MultiFinder (int n)
{
    int multi=1;
    for(int i=1; i<=n; i++)
    {
        multi*=i;        
    }
    Console.Write($"Multiplication of numbers from 1 to {n} is {multi}");
}

Console.Write("Input number: ");
int un= Convert.ToInt32(Console.ReadLine());

if (un>0) MultiFinder (un);
else Console.WriteLine("Impossible value");
*/

/*
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
//типа - [1,0,1,1,0,1,0,0]
Console.Clear();
int[] CreateNewArray(int size, int min, int max) //Метод создания массива
{
    int[] array = new int[size]; //new - выделение памяти под массив
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) //.Length - считает количество элементов в массиве
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter count of elements: ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
int minVal = 0;
int maxVal = 1;

int[] array1 = CreateNewArray(countOfElements, minVal, maxVal);
ShowArray(array1);
*/