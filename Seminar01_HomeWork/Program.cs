/*
//Задача 2
//Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число больше, а какое меньше

Console.Clear();
Console.Write("Input 1st number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int num2=Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine($"Your first number is {num1}, second number is {num2}. First number is bigger than second one.");
}
else
{
    if(num1==num2)
    {
       Console.WriteLine($"Your first number is {num1} and second number is {num2}. These numbers are equal."); 
    }
    else
    {
    Console.WriteLine($"Your first number is {num1}, second number is {num2}. Second number is bigger than first one.");
    }
}

//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Input 1st number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int num2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3rd number: ");
int num3=Convert.ToInt32(Console.ReadLine());

int max=num1;

if(num2>num1 && num2>num3) max=num2;
if(num3>num2 && num3>num1) max=num3;

Console.WriteLine($"Maximum number is {max}");

//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на 2 без остатка)

Console.Clear();
Console.Write("Input your number: ");
int num=Convert.ToInt32(Console.ReadLine());

if(num%2==0)
{
    Console.WriteLine("Your number is even number.");
}
else
{
    Console.WriteLine("Your number is odd number.");
}

//Задача 8
//Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N

Console.Clear();
Console.Write("Input positive number: ");
int num=Convert.ToInt32(Console.ReadLine());

int count=2;

Console.WriteLine("Even numbers from 1 until " + num + " are: ");

while(count<=num)
{
    if(count%2==0) Console.Write(count + " ");
    count++;
}
*/