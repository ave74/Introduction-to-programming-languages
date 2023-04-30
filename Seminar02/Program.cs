/*
//Задание 1
//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

int Digits(int number)
{
    //1. выделить цифры числа
    int ed = number % 10;
    int dec = number / 10;
    //2. сравнить цифры
    if (ed>dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
    //3. сообщить результат
}

Console.Clear();
Console.Write("Input number: ");
int user_number=Convert.ToInt32(Console.ReadLine());

if (user_number>9 && user_number<100)
{
    int res=Digits(user_number);
    Console.WriteLine($"The biggest digit is {res}");
}
else
{
    Console.WriteLine("Imposible value ");
}


//Задача 1 (невозвратный метод)

void Digit1 (int number)
{
    int ed = number % 10;
    int dec = number / 10;
    if (ed>dec)
    {
    Console.WriteLine("The biggest digit is " + ed);
    }
    else
    {
        Console.WriteLine("The biggest digit is " + dec);
    }
}

Console.Clear();
Console.Write("Input number: ");
int user_number=Convert.ToInt32(Console.ReadLine());

if (user_number>9 && user_number<100)
{
       Digit1(user_number);
}
else
{
    Console.WriteLine("Imposible value ");
}
*/

//Задача 2
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

