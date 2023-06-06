//Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.Clear();
void ShowNumbers(int numbers)
{
    Console.Write(numbers + " ");
    if (numbers > 1) ShowNumbers(numbers - 1);
}

ShowNumbers(10);
*/

//Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
/*
Console.Clear();
int SumDigits(int m, int n)
{
    if (m == n) return m;
    if (m < n) return n + SumDigits(m, n - 1);
    return n + SumDigits(m, n + 1);           
}

int res = SumDigits(2, 6);
Console.Write(res);
*/

//Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
Console.Clear();
int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

int res = Akk(5, 0);
Console.Write(res);
*/