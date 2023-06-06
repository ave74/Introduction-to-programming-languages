//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
void ShowNumbers (int numbers)
{
    if (numbers>1) ShowNumbers(numbers-1);
    Console.Write(numbers+" ");
}
ShowNumbers(5);
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
int SumDigits (int num)
{
    if (num<0) num*=-1;
    if (num>0) return SumDigits(num/10)+num%10;
    else return 0
}

int res = SumDigits(987);
Console.Write (res);
*/

//Напишите программу, которая на вход принимает два числа А и В,
//и возводит число А в целую степень В с помощью рекурсии

double FindPower (int a, int b)
{
    if (b<0) return FindPower(a, b+1) /a;
    if (b>0) return FindPower(a, b-1) * a;
    else return 1.0;
}

double res = FindPower(2, 3);
Console.Write (res);